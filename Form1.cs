using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using MQTTnet;
using System.Threading;
using MQTTnet.Adapter;
using MQTTnet.Diagnostics;
using MQTTnet.Protocol;
using MQTTnet.Server;
using MQTTnet.Client.Receiving;
using MQTTnet.Client;
using MQTTnet.Client.Options;
using MQTTnet.Client.Connecting;
using MQTTnet.Client.Disconnecting;
using System.IO;
using SimpleMQTT.core;
using System.Runtime.Serialization;

namespace SimpleMQTT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void Init()
        {
            _updateMonitorAction = new Action<string>((s) =>
            {
                lbxMonitor.Items.Add(s);
                if (lbxMonitor.Items.Count > 1000)
                {
                    lbxMonitor.Items.RemoveAt(0);
                }
                var visibleItems = lbxMonitor.ClientRectangle.Height / lbxMonitor.ItemHeight;

                lbxMonitor.TopIndex = lbxMonitor.Items.Count - visibleItems + 1;
            });
            //消息质量默认选择2：ExactlyOnce
            /*0=AtMostOnce
            1=AtLeastOnce
            2=ExactlyOnce
            */
            cmbQos.SelectedIndex = 2;
            cmbRetain.SelectedIndex = 0;
            StartMqttServer();
        }


        private Action<string> _updateMonitorAction;

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                Init();
                JObject jo = ReadConfiguration() as JObject;
                lblPort.Text += mqttServer.Options.DefaultEndpointOptions.Port.ToString();
                lblUserName.Text += jo["Users"][0]["UserName"].ToString();
                lblPWD.Text += jo["Users"][0]["Password"].ToString();

                txtPort.Text = mqttServer.Options.DefaultEndpointOptions.Port.ToString();
                txtUserName.Text = jo["Users"][0]["UserName"].ToString();
                txtPWD.Text = jo["Users"][0]["Password"].ToString();
            }
            catch (Exception ex)
            {
                lbxMonitor.BeginInvoke(_updateMonitorAction, 
                    Logger.TraceLog(Logger.Level.Fatal, "MQTT Server start fail.> \r\n" + ex.Message));
                return;
            }
        }

        private void lbxMonitor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 'c' || e.KeyChar == 'C')
            {
                if (DialogResult.Yes == MessageBox.Show("Clear the Monotor View?", "Info", MessageBoxButtons.YesNo))
                {
                    lbxMonitor.Items.Clear();
                }
            }

        }

        #region MQTT Server
        public MqttServer mqttServer = null;

        public async void StartMqttServer()
        {
            try
            {
                if (mqttServer == null)
                {
                    var config = ReadConfiguration();
                    var optionsBuilder = new MqttServerOptionsBuilder()
                    .WithDefaultEndpoint().WithDefaultEndpointPort(int.Parse(config["Port"].ToString())).WithConnectionValidator(
                        c =>
                        {
                            var currentUser = config["Users"][0]["UserName"].ToString();
                            var currentPWD = config["Users"][0]["Password"].ToString();

                            if (currentUser == null || currentPWD == null)
                            {
                                c.ReasonCode = MqttConnectReasonCode.BadUserNameOrPassword;
                                return;
                            }

                            if (c.Username != currentUser)
                            {
                                c.ReasonCode = MqttConnectReasonCode.BadUserNameOrPassword;
                                return;
                            }

                            if (c.Password != currentPWD)
                            {
                                c.ReasonCode = MqttConnectReasonCode.BadUserNameOrPassword;
                                return;
                            }

                            c.ReasonCode = MqttConnectReasonCode.Success;
                        }).WithSubscriptionInterceptor(
                        c =>
                        {
                            c.AcceptSubscription = true;
                        }).WithApplicationMessageInterceptor(
                        c =>
                        {
                            c.AcceptPublish = true;
                        });

                    mqttServer = new MqttFactory().CreateMqttServer() as MqttServer;
                    mqttServer.StartedHandler = new MqttServerStartedHandlerDelegate(OnMqttServerStarted);
                    mqttServer.StoppedHandler = new MqttServerStoppedHandlerDelegate(OnMqttServerStopped);

                    mqttServer.ClientConnectedHandler = new MqttServerClientConnectedHandlerDelegate(OnMqttServerClientConnected);
                    mqttServer.ClientDisconnectedHandler = new MqttServerClientDisconnectedHandlerDelegate(OnMqttServerClientDisconnected);
                    mqttServer.ClientSubscribedTopicHandler = new MqttServerClientSubscribedHandlerDelegate(OnMqttServerClientSubscribedTopic);
                    mqttServer.ClientUnsubscribedTopicHandler = new MqttServerClientUnsubscribedTopicHandlerDelegate(OnMqttServerClientUnsubscribedTopic);
                    mqttServer.ApplicationMessageReceivedHandler = new MqttApplicationMessageReceivedHandlerDelegate(OnMqttServer_ApplicationMessageReceived);


                    await mqttServer.StartAsync(optionsBuilder.Build());
                    lbxMonitor.BeginInvoke(_updateMonitorAction,
                        Logger.TraceLog(Logger.Level.Info, "MQTT Server is started."));

                }
            }
            catch (Exception ex)
            {
                lbxMonitor.BeginInvoke(_updateMonitorAction,
                            Logger.TraceLog(Logger.Level.Fatal, $"MQTT Server start fail.>{ex.Message}"));
            }
        }

        public async void StopMqttServer()
        {
            if (mqttServer == null) return;
            try
            {
                await mqttServer?.StopAsync();
                mqttServer = null;
                lbxMonitor.BeginInvoke(_updateMonitorAction,
                        Logger.TraceLog(Logger.Level.Info, "MQTT Server is stopped."));
            }
            catch (Exception ex)
            {
                lbxMonitor.BeginInvoke(_updateMonitorAction,
                            Logger.TraceLog(Logger.Level.Fatal, $"MQTT Server stop fail.>{ex.Message}"));
            }
        }

        public async void ServerPublishMqttTopic(string topic, string payload)
        {
            var message = new MqttApplicationMessage()
            {
                Topic = topic,
                Payload = Encoding.UTF8.GetBytes(payload)
            };
            await mqttServer.PublishAsync(message);
            lbxMonitor.BeginInvoke(_updateMonitorAction,
                    Logger.TraceLog(Logger.Level.Info, string.Format("MQTT Broker发布主题[{0}]成功！", topic)));
        }
        public static JObject ReadConfiguration()
        {
            var filePath = $"./conf/config.json";

            // ReSharper disable once InvertIf
            if (File.Exists(filePath))
            {
                using (StreamReader r = new StreamReader(filePath))
                {
                    var json = r.ReadToEnd();
                    JObject jo = JsonConvert.DeserializeObject<JObject>(json);
                    return jo;
                }
            }
            return null;

        }
        public void OnMqttServerStarted(EventArgs e)
        {
            //Console.WriteLine("MQTT服务启动完成！");
            if (mqttServer.IsStarted)
            {
                pnlStatus.BeginInvoke(new Action<Color>((c) =>
                {
                    pnlStatus.BackColor = c;
                }), Color.LightGreen);

                lblStatus.BeginInvoke(new Action<string>((s) =>
                {
                    lblStatus.Text = s;
                }), "MQTT Server is Started.");

                btnServerStart.BeginInvoke(new Action<string, int, Color>((s, i, c) =>
                {
                    btnServerStart.Text = s;
                    btnServerStart.Tag = i;
                    btnServerStart.BackColor = c;
                }), "Stop", 1, Color.LightGreen);
            }
        }
        public void OnMqttServerStopped(EventArgs e)
        {
            //Console.WriteLine("MQTT服务停止完成！");
            if (!mqttServer.IsStarted)
            {
                pnlStatus.BeginInvoke(new Action<Color>((c) =>
                {
                    pnlStatus.BackColor = c;
                }), Color.LightGray);

                lblStatus.BeginInvoke(new Action<string>((s) =>
                {
                    lblStatus.Text = s;
                }), "MQTT Server is Stopped.");

                btnServerStart.BeginInvoke(new Action<string, int, Color>((s, i, c) =>
                {
                    btnServerStart.Text = s;
                    btnServerStart.Tag = i;
                    btnServerStart.BackColor = c;
                }), "Start", 0, Color.LightGray);
            }
        }
        public void OnMqttServerClientConnected(MqttServerClientConnectedEventArgs e)
        {
            //Console.WriteLine($"客户端[{e.ClientId}]已连接");
            lbxMonitor.BeginInvoke(_updateMonitorAction,
                    Logger.TraceLog(Logger.Level.Info, $"客户端[{e.ClientId}]已连接"));
            
            
        }

        public void OnMqttServerClientDisconnected(MqttServerClientDisconnectedEventArgs e)
        {
            //Console.WriteLine($"客户端[{e.ClientId}]已断开连接！");
            lbxMonitor.BeginInvoke(_updateMonitorAction,
                    Logger.TraceLog(Logger.Level.Info, $"客户端[{e.ClientId}]已断开连接！"));
        }

        public void OnMqttServerClientSubscribedTopic(MqttServerClientSubscribedTopicEventArgs e)
        {
            //Console.WriteLine($"客户端[{e.ClientId}]已成功订阅主题[{e.TopicFilter}]！");
            lbxMonitor.BeginInvoke(_updateMonitorAction,
                    Logger.TraceLog(Logger.Level.Info, $"客户端[{e.ClientId}]已成功订阅主题[{e.TopicFilter}]！"));
        }
        public void OnMqttServerClientUnsubscribedTopic(MqttServerClientUnsubscribedTopicEventArgs e)
        {
            //Console.WriteLine($"客户端[{e.ClientId}]已成功取消订阅主题[{e.TopicFilter}]！");
            lbxMonitor.BeginInvoke(_updateMonitorAction,
                    Logger.TraceLog(Logger.Level.Info, $"客户端[{e.ClientId}]已成功取消订阅主题[{e.TopicFilter}]！"));
        }

        public void OnMqttServer_ApplicationMessageReceived(MqttApplicationMessageReceivedEventArgs e)
        {
            //Console.WriteLine($"客户端[{e.ClientId}]>> 主题：{e.ApplicationMessage.Topic} 负荷：{Encoding.UTF8.GetString(e.ApplicationMessage.Payload)} Qos：{e.ApplicationMessage.QualityOfServiceLevel} 保留：{e.ApplicationMessage.Retain}");
            lbxMonitor.BeginInvoke(_updateMonitorAction,
                    Logger.TraceLog(Logger.Level.Info, 
                    $"客户端[{e.ClientId}]>> 主题：{e.ApplicationMessage.Topic} 负荷：{Encoding.UTF8.GetString(e.ApplicationMessage.Payload)} Qos：{e.ApplicationMessage.QualityOfServiceLevel} 保留：{e.ApplicationMessage.Retain}"));
        }

        #endregion

        #region MQTT Cliet

        private MqttClient mqttClient = null;
        private async Task ClientStart()
        {
            try
            {
                var tcpServer = txtIPAddr.Text;
                var tcpPort = int.Parse(txtPort.Text.Trim());
                var mqttUser = txtUserName.Text.Trim();
                var mqttPassword = txtPWD.Text.Trim();

                var mqttFactory = new MqttFactory();



                var options = new MqttClientOptions
                {
                    ClientId = txtClientID.Text.Trim(),
                    ProtocolVersion = MQTTnet.Formatter.MqttProtocolVersion.V311,
                    ChannelOptions = new MqttClientTcpOptions
                    {
                        Server = tcpServer,
                        Port = tcpPort
                    },
                    WillDelayInterval = 10,
                    WillMessage = new MqttApplicationMessage()
                    {
                        Topic = $"LastWill/{txtClientID.Text.Trim()}",
                        Payload= Encoding.UTF8.GetBytes("I Lost the connection!"),
                        QualityOfServiceLevel = MqttQualityOfServiceLevel.ExactlyOnce
                    }
                    
                };
                if (options.ChannelOptions == null)
                {
                    throw new InvalidOperationException();
                }

                if (!string.IsNullOrEmpty(mqttUser))
                {
                    options.Credentials = new MqttClientCredentials
                    {
                        Username = mqttUser,
                        Password = Encoding.UTF8.GetBytes(mqttPassword)
                    };
                }

                options.CleanSession = true;
                options.KeepAlivePeriod = TimeSpan.FromSeconds(5);

                mqttClient = mqttFactory.CreateMqttClient() as MqttClient;
                mqttClient.ConnectedHandler = new MqttClientConnectedHandlerDelegate(OnMqttClientConnected);
                mqttClient.DisconnectedHandler = new MqttClientDisconnectedHandlerDelegate(OnMqttClientDisConnected);
                mqttClient.ApplicationMessageReceivedHandler = new MqttApplicationMessageReceivedHandlerDelegate(OnSubscriberMessageReceived);
                await mqttClient.ConnectAsync(options);
                lbxMonitor.BeginInvoke(_updateMonitorAction,
                        Logger.TraceLog(Logger.Level.Info, $"客户端[{options.ClientId}]尝试连接..."));
            }
            catch (Exception ex)
            {
                lbxMonitor.BeginInvoke(_updateMonitorAction,
                        Logger.TraceLog(Logger.Level.Fatal, $"客户端尝试连接出错.>{ex.Message}"));
            }
        }

        private async Task ClientStop()
        {
            try
            {
                if (mqttClient == null) return;
                await mqttClient.DisconnectAsync();
                mqttClient = null;
            }
            catch (Exception ex)
            {
                lbxMonitor.BeginInvoke(_updateMonitorAction,
                        Logger.TraceLog(Logger.Level.Fatal, $"客户端尝试断开Server出错.>{ex.Message}"));
            }
        }

        public void OnMqttClientConnected(MqttClientConnectedEventArgs e)
        {
            //Console.WriteLine($"客户端[{e.ClientId}]已断开连接！");
            //btnConnect.Text = "Connected"; ;
            //btnConnect.BackColor = Color.LightGreen;
            //btnConnect.Tag = 1;

            btnConnect.BeginInvoke(new Action<string, int, Color>((s, i, c) =>
            {
                btnConnect.Text = s;
                btnConnect.Tag = i;
                btnConnect.BackColor = c;
            }), "Connected", 1, Color.LightGreen);

        }

        public void OnMqttClientDisConnected(MqttClientDisconnectedEventArgs e)
        {
            //Console.WriteLine($"客户端[{e.ClientId}]已断开连接！");
            btnConnect.BeginInvoke(new Action<string, int, Color>((s, i, c) =>
            {
                btnConnect.Text = s;
                btnConnect.Tag = i;
                btnConnect.BackColor = c;
            }), "Disonnected", 0, Color.LightGray);
        }

        public async void ClientPublishMqttTopic(string topic, string payload)
        {
            try
            {
                var message = new MqttApplicationMessage()
                {
                    Topic = topic,
                    Payload = Encoding.UTF8.GetBytes(payload),
                    QualityOfServiceLevel = (MqttQualityOfServiceLevel)cmbQos.SelectedIndex,
                    Retain = bool.Parse(cmbRetain.SelectedItem.ToString())
                };
                await mqttClient.PublishAsync(message);
                lbxMonitor.BeginInvoke(_updateMonitorAction,
                        Logger.TraceLog(Logger.Level.Info, string.Format("客户端[{0}]发布主题[{1}]成功！", mqttClient.Options.ClientId, topic)));
            }
            catch (Exception ex)
            {
                lbxMonitor.BeginInvoke(_updateMonitorAction,
                            Logger.TraceLog(Logger.Level.Fatal, string.Format("客户端[{0}]发布主题[{1}]异常！>{2}", mqttClient.Options.ClientId, topic,ex.Message)));
            }
        }

        public async void ClientSubscribeTopic(string topic)
        {
            await mqttClient.SubscribeAsync(topic);
            lbxMonitor.BeginInvoke(_updateMonitorAction,
                    Logger.TraceLog(Logger.Level.Info, string.Format("客户端[{0}]订阅主题[{1}]成功！", mqttClient.Options.ClientId, topic)));
        }

        public async void ClientUnSubscribeTopic(string topic)
        {
            await mqttClient.UnsubscribeAsync(topic);
            lbxMonitor.BeginInvoke(_updateMonitorAction,
                    Logger.TraceLog(Logger.Level.Info, string.Format("客户端[{0}]取消主题[{1}]成功！", mqttClient.Options.ClientId, topic)));
        }
        /// <summary>
        /// 当客户端接收到所订阅的主题消息时
        /// </summary>
        /// <param name="e"></param>
        private void OnSubscriberMessageReceived(MqttApplicationMessageReceivedEventArgs e)
        {
            string text = Encoding.UTF8.GetString(e.ApplicationMessage.Payload);
            string Topic = e.ApplicationMessage.Topic;
            string QoS = e.ApplicationMessage.QualityOfServiceLevel.ToString();
            string Retained = e.ApplicationMessage.Retain.ToString();
            lbxMonitor.BeginInvoke(_updateMonitorAction,
                    Logger.TraceLog(Logger.Level.Info, "MessageReceived >>Topic:" + Topic + "; QoS: " + QoS + "; Retained: " + Retained));
            lbxMonitor.BeginInvoke(_updateMonitorAction,
                    Logger.TraceLog(Logger.Level.Info, "MessageReceived >>Msg: " + text));
        }




        #endregion

        /// <summary>
        /// MQTT Borker主动发布消息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPublish_s_Click(object sender, EventArgs e)
        {
            try
            {
                string topic = rtbPublishTopic_S.Text;
                if (topic.Trim() == "")
                {
                    MessageBox.Show("Topic can not be none!", "Info", MessageBoxButtons.OK);
                    return;
                }
                //TODO:
                string payload = rtbPayload_S.Text;
                ServerPublishMqttTopic(topic, payload);
            }
            catch (Exception ex)
            {
                throw new ApplicationException();
            }
        }

        private async void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.Parse(btnConnect.Tag.ToString()) == 0)
                {
                    await ClientStart();
                    
                }
                else
                {
                    if (int.Parse(btnConnect.Tag.ToString()) == 1)
                    {
                        await ClientStop();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException();
            }
        }

        /// <summary>
        /// MQTT Client发布主题（设备上报Json报文）
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPublish_C_Click(object sender, EventArgs e)
        {
            try
            {
                if (mqttClient == null || !mqttClient.IsConnected)
                {
                    MessageBox.Show("Please connect to MQTT server firstly!", "Info", MessageBoxButtons.OK);
                    return;
                }
                string topic = rtbpubTopic_C.Text;
                if (topic.Trim() == "")
                {
                    MessageBox.Show("Topic can not be none!", "Info", MessageBoxButtons.OK);
                    return;
                }
                //TODO:
                string payload = rtbpubPayload_C.Text;
                ClientPublishMqttTopic(topic, payload);
            }
            catch (Exception ex)
            {
                throw new ApplicationException();
            }
        }

        private void btnSubscribe_Click(object sender, EventArgs e)
        {
            try
            {
                if (mqttClient == null || !mqttClient.IsConnected)
                {
                    MessageBox.Show("Please connect to MQTT server firstly!", "Info", MessageBoxButtons.OK);
                    return;
                }
                if (rtbSubTopic_C.Text.Trim() == "")
                {
                    MessageBox.Show("Topic can not be none!", "Info", MessageBoxButtons.OK);
                    return;
                }
                ClientSubscribeTopic(rtbSubTopic_C.Text);
            }
            catch (Exception ex)
            {
                throw new ApplicationException();
            }
        }

        private void lbxMonitor_DoubleClick(object sender, EventArgs e)
        {
            if (lbxMonitor.SelectedItem != null)
            {
                MessageBox.Show(lbxMonitor.SelectedItem.ToString(),"Detai Info");
            }
        }

        private void btnServerStart_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.Parse(btnServerStart.Tag.ToString()) == 0)
                {
                    StartMqttServer();
                }
                else
                {
                    if (int.Parse(btnServerStart.Tag.ToString()) == 1) StopMqttServer();
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException();
            }
        }
    }

}

using MQTTnet;
using System;
using System.Text;
using System.Threading;
using MQTTnet.Adapter;
using MQTTnet.Diagnostics;
using MQTTnet.Protocol;
using MQTTnet.Server;
using MQTTnet.Client.Receiving;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Threading.Tasks;

namespace SimpleMQTT.Core
{
    public class MQTTServer
    {
        public static MqttServer mqttServer = null;

        //static void Main(string[] args)
        //{
        //    //MqttNetTrace.TraceMessagePublished += MqttNetTrace_TraceMessagePublished;
        //    new Thread(StartMqttServer).Start();

        //    while (true)
        //    {
        //        var inputString = Console.ReadLine().ToLower().Trim();

        //        if (inputString == "exit")
        //        {
        //            mqttServer?.StopAsync();
        //            Console.WriteLine("MQTT服务异步停止...");
        //            break;
        //        }
        //        else if (inputString == "clients")
        //        {
        //            foreach (var item in mqttServer.GetClientStatusAsync().Result)
        //            {
        //                Console.WriteLine($"客户端标识：{item.ClientId}，协议版本：{item.ProtocolVersion}");
        //            }
        //        }
        //        else if (inputString == "publish")
        //        {
        //            Console.WriteLine("Please key in your topic:");
        //            string topic = Console.ReadLine();
        //            Console.WriteLine("Please key in your payload:");
        //            string payload = Console.ReadLine();
        //            PublishMqttTopic(topic, payload);
        //            Console.WriteLine($"主题消息[{topic}]发布成功！");
        //        }
        //        else
        //        {
        //            Console.WriteLine($"命令[{inputString}]无效！");
        //        }
        //    }
        //}

        public static async void StartMqttServer()
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
            }

        }

        public static async void PublishMqttTopic(string topic, string payload)
        {
            var message = new MqttApplicationMessage()
            {
                Topic = topic,
                Payload = Encoding.UTF8.GetBytes(payload)
            };
            await mqttServer.PublishAsync(message);
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
        public static void OnMqttServerStarted(EventArgs e)
        {
            //Console.WriteLine("MQTT服务启动完成！");
        }
        public static void OnMqttServerStopped(EventArgs e)
        {
            //Console.WriteLine("MQTT服务停止完成！");
        }
        public static void OnMqttServerClientConnected(MqttServerClientConnectedEventArgs e)
        {
            //Console.WriteLine($"客户端[{e.ClientId}]已连接");
        }

        public static void OnMqttServerClientDisconnected(MqttServerClientDisconnectedEventArgs e)
        {
            //Console.WriteLine($"客户端[{e.ClientId}]已断开连接！");
        }

        public static void OnMqttServerClientSubscribedTopic(MqttServerClientSubscribedTopicEventArgs e)
        {
            //Console.WriteLine($"客户端[{e.ClientId}]已成功订阅主题[{e.TopicFilter}]！");
        }
        public static void OnMqttServerClientUnsubscribedTopic(MqttServerClientUnsubscribedTopicEventArgs e)
        {
            //Console.WriteLine($"客户端[{e.ClientId}]已成功取消订阅主题[{e.TopicFilter}]！");
        }

        public static void OnMqttServer_ApplicationMessageReceived(MqttApplicationMessageReceivedEventArgs e)
        {
            //Console.WriteLine($"客户端[{e.ClientId}]>> 主题：{e.ApplicationMessage.Topic} 负荷：{Encoding.UTF8.GetString(e.ApplicationMessage.Payload)} Qos：{e.ApplicationMessage.QualityOfServiceLevel} 保留：{e.ApplicationMessage.Retain}");
        }

    }
}


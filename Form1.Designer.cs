namespace SimpleMQTT
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lbxMonitor = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPublish_s = new System.Windows.Forms.Button();
            this.rtbPayload_S = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rtbPublishTopic_S = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnServerStart = new System.Windows.Forms.Button();
            this.lblPWD = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblPort = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label9 = new System.Windows.Forms.Label();
            this.btnPublish_C = new System.Windows.Forms.Button();
            this.rtbpubPayload_C = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.rtbpubTopic_C = new System.Windows.Forms.RichTextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btnSubscribe = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.rtbSubTopic_C = new System.Windows.Forms.RichTextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cmbRetain = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cmbQos = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtClientID = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtIPAddr = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.txtPWD = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pnlStatus = new System.Windows.Forms.Panel();
            this.lblStatus = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.pnlStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel2);
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel4);
            this.splitContainer1.Panel2.Controls.Add(this.panel3);
            this.splitContainer1.Size = new System.Drawing.Size(2279, 1210);
            this.splitContainer1.SplitterDistance = 1108;
            this.splitContainer1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tabControl1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 310);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1106, 898);
            this.panel2.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1106, 898);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lbxMonitor);
            this.tabPage1.Location = new System.Drawing.Point(8, 39);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1090, 851);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Monitor";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lbxMonitor
            // 
            this.lbxMonitor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbxMonitor.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxMonitor.FormattingEnabled = true;
            this.lbxMonitor.ItemHeight = 28;
            this.lbxMonitor.Location = new System.Drawing.Point(3, 3);
            this.lbxMonitor.Name = "lbxMonitor";
            this.lbxMonitor.Size = new System.Drawing.Size(1084, 845);
            this.lbxMonitor.TabIndex = 0;
            this.lbxMonitor.DoubleClick += new System.EventHandler(this.lbxMonitor_DoubleClick);
            this.lbxMonitor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.lbxMonitor_KeyPress);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tableLayoutPanel2);
            this.tabPage2.Location = new System.Drawing.Point(8, 39);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1090, 851);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Setting";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.74256F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.25744F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 421F));
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnPublish_s, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.rtbPayload_S, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.rtbPublishTopic_S, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.658008F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.68831F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.658009F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 62.33767F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.658009F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1084, 845);
            this.tableLayoutPanel2.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(409, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Topic:";
            // 
            // btnPublish_s
            // 
            this.btnPublish_s.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPublish_s.Location = new System.Drawing.Point(418, 775);
            this.btnPublish_s.Name = "btnPublish_s";
            this.btnPublish_s.Size = new System.Drawing.Size(241, 64);
            this.btnPublish_s.TabIndex = 4;
            this.btnPublish_s.Text = "Publish";
            this.btnPublish_s.UseVisualStyleBackColor = true;
            this.btnPublish_s.Click += new System.EventHandler(this.btnPublish_s_Click);
            // 
            // rtbPayload_S
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.rtbPayload_S, 3);
            this.rtbPayload_S.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbPayload_S.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbPayload_S.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.rtbPayload_S.Location = new System.Drawing.Point(3, 247);
            this.rtbPayload_S.Name = "rtbPayload_S";
            this.rtbPayload_S.Size = new System.Drawing.Size(1078, 520);
            this.rtbPayload_S.TabIndex = 8;
            this.rtbPayload_S.Text = "";
            this.rtbPayload_S.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.lbxMonitor_KeyPress);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(409, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "Payload:";
            // 
            // rtbPublishTopic_S
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.rtbPublishTopic_S, 3);
            this.rtbPublishTopic_S.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbPublishTopic_S.Font = new System.Drawing.Font("Cambria", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbPublishTopic_S.Location = new System.Drawing.Point(3, 76);
            this.rtbPublishTopic_S.Name = "rtbPublishTopic_S";
            this.rtbPublishTopic_S.Size = new System.Drawing.Size(1078, 92);
            this.rtbPublishTopic_S.TabIndex = 6;
            this.rtbPublishTopic_S.Text = "";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnServerStart);
            this.panel1.Controls.Add(this.lblPWD);
            this.panel1.Controls.Add(this.lblUserName);
            this.panel1.Controls.Add(this.lblPort);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("宋体", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1106, 310);
            this.panel1.TabIndex = 0;
            // 
            // btnServerStart
            // 
            this.btnServerStart.BackColor = System.Drawing.Color.LightGreen;
            this.btnServerStart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnServerStart.Location = new System.Drawing.Point(765, 63);
            this.btnServerStart.Name = "btnServerStart";
            this.btnServerStart.Size = new System.Drawing.Size(257, 204);
            this.btnServerStart.TabIndex = 11;
            this.btnServerStart.Tag = "0";
            this.btnServerStart.Text = "Stop";
            this.btnServerStart.UseVisualStyleBackColor = false;
            this.btnServerStart.Click += new System.EventHandler(this.btnServerStart_Click);
            // 
            // lblPWD
            // 
            this.lblPWD.AutoSize = true;
            this.lblPWD.Location = new System.Drawing.Point(12, 237);
            this.lblPWD.Name = "lblPWD";
            this.lblPWD.Size = new System.Drawing.Size(188, 37);
            this.lblPWD.TabIndex = 3;
            this.lblPWD.Text = "Password:";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(12, 164);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(188, 37);
            this.lblUserName.TabIndex = 2;
            this.lblUserName.Text = "UserName:";
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Location = new System.Drawing.Point(12, 91);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(112, 37);
            this.lblPort.TabIndex = 1;
            this.lblPort.Text = "Port:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(377, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "MQTT Server/Broker";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.tabControl2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 363);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1165, 845);
            this.panel4.TabIndex = 3;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl2.Location = new System.Drawing.Point(0, 0);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(1165, 845);
            this.tabControl2.TabIndex = 9;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.tableLayoutPanel1);
            this.tabPage3.Location = new System.Drawing.Point(8, 39);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1149, 798);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Publish";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.74256F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.25744F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 421F));
            this.tableLayoutPanel1.Controls.Add(this.label9, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnPublish_C, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.rtbpubPayload_C, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.rtbpubTopic_C, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.658008F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.68831F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.658009F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 62.33767F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.658009F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1143, 792);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(447, 24);
            this.label9.TabIndex = 5;
            this.label9.Text = "Topic:";
            // 
            // btnPublish_C
            // 
            this.btnPublish_C.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPublish_C.Location = new System.Drawing.Point(456, 724);
            this.btnPublish_C.Name = "btnPublish_C";
            this.btnPublish_C.Size = new System.Drawing.Size(262, 64);
            this.btnPublish_C.TabIndex = 4;
            this.btnPublish_C.Text = "Publish";
            this.btnPublish_C.UseVisualStyleBackColor = true;
            this.btnPublish_C.Click += new System.EventHandler(this.btnPublish_C_Click);
            // 
            // rtbpubPayload_C
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.rtbpubPayload_C, 3);
            this.rtbpubPayload_C.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbpubPayload_C.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbpubPayload_C.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.rtbpubPayload_C.Location = new System.Drawing.Point(3, 231);
            this.rtbpubPayload_C.Name = "rtbpubPayload_C";
            this.rtbpubPayload_C.Size = new System.Drawing.Size(1137, 487);
            this.rtbpubPayload_C.TabIndex = 8;
            this.rtbpubPayload_C.Text = "";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 182);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(447, 24);
            this.label8.TabIndex = 7;
            this.label8.Text = "Payload:";
            // 
            // rtbpubTopic_C
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.rtbpubTopic_C, 3);
            this.rtbpubTopic_C.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbpubTopic_C.Font = new System.Drawing.Font("Cambria", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbpubTopic_C.Location = new System.Drawing.Point(3, 71);
            this.rtbpubTopic_C.Name = "rtbpubTopic_C";
            this.rtbpubTopic_C.Size = new System.Drawing.Size(1137, 86);
            this.rtbpubTopic_C.TabIndex = 6;
            this.rtbpubTopic_C.Text = "";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.btnSubscribe);
            this.tabPage4.Controls.Add(this.label10);
            this.tabPage4.Controls.Add(this.rtbSubTopic_C);
            this.tabPage4.Location = new System.Drawing.Point(8, 39);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1149, 798);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "Subscribe";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // btnSubscribe
            // 
            this.btnSubscribe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSubscribe.Location = new System.Drawing.Point(503, 180);
            this.btnSubscribe.Name = "btnSubscribe";
            this.btnSubscribe.Size = new System.Drawing.Size(174, 84);
            this.btnSubscribe.TabIndex = 9;
            this.btnSubscribe.Text = "Subscribe";
            this.btnSubscribe.UseVisualStyleBackColor = true;
            this.btnSubscribe.Click += new System.EventHandler(this.btnSubscribe_Click);
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 25);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 24);
            this.label10.TabIndex = 7;
            this.label10.Text = "Topic:";
            // 
            // rtbSubTopic_C
            // 
            this.rtbSubTopic_C.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbSubTopic_C.Font = new System.Drawing.Font("Cambria", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbSubTopic_C.Location = new System.Drawing.Point(19, 52);
            this.rtbSubTopic_C.Name = "rtbSubTopic_C";
            this.rtbSubTopic_C.Size = new System.Drawing.Size(1113, 96);
            this.rtbSubTopic_C.TabIndex = 8;
            this.rtbSubTopic_C.Text = "";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label16);
            this.panel3.Controls.Add(this.label15);
            this.panel3.Controls.Add(this.cmbRetain);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.cmbQos);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.txtClientID);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.txtIPAddr);
            this.panel3.Controls.Add(this.btnConnect);
            this.panel3.Controls.Add(this.txtPWD);
            this.panel3.Controls.Add(this.txtUserName);
            this.panel3.Controls.Add(this.txtPort);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Font = new System.Drawing.Font("宋体", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1165, 363);
            this.panel3.TabIndex = 2;
            // 
            // cmbRetain
            // 
            this.cmbRetain.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRetain.FormattingEnabled = true;
            this.cmbRetain.Items.AddRange(new object[] {
            "False",
            "True"});
            this.cmbRetain.Location = new System.Drawing.Point(811, 291);
            this.cmbRetain.Name = "cmbRetain";
            this.cmbRetain.Size = new System.Drawing.Size(340, 45);
            this.cmbRetain.TabIndex = 18;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(1216, 598);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(93, 37);
            this.label14.TabIndex = 17;
            this.label14.Text = "QoS:";
            // 
            // cmbQos
            // 
            this.cmbQos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbQos.FormattingEnabled = true;
            this.cmbQos.Items.AddRange(new object[] {
            "AtMostOnce",
            "AtLeastOnce",
            "ExactlyOnce"});
            this.cmbQos.Location = new System.Drawing.Point(227, 291);
            this.cmbQos.Name = "cmbQos";
            this.cmbQos.Size = new System.Drawing.Size(340, 45);
            this.cmbQos.TabIndex = 16;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(48, 598);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(93, 37);
            this.label13.TabIndex = 15;
            this.label13.Text = "QoS:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(24, 230);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(188, 37);
            this.label12.TabIndex = 14;
            this.label12.Text = "ClientID:";
            // 
            // txtClientID
            // 
            this.txtClientID.Location = new System.Drawing.Point(227, 224);
            this.txtClientID.Name = "txtClientID";
            this.txtClientID.Size = new System.Drawing.Size(544, 50);
            this.txtClientID.TabIndex = 13;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(604, 88);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(36, 37);
            this.label11.TabIndex = 12;
            this.label11.Text = ":";
            // 
            // txtIPAddr
            // 
            this.txtIPAddr.Location = new System.Drawing.Point(227, 85);
            this.txtIPAddr.Name = "txtIPAddr";
            this.txtIPAddr.Size = new System.Drawing.Size(340, 50);
            this.txtIPAddr.TabIndex = 11;
            this.txtIPAddr.Text = "127.0.0.1";
            // 
            // btnConnect
            // 
            this.btnConnect.BackColor = System.Drawing.Color.LightGray;
            this.btnConnect.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConnect.Location = new System.Drawing.Point(857, 70);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(294, 204);
            this.btnConnect.TabIndex = 10;
            this.btnConnect.Tag = "0";
            this.btnConnect.Text = "Disconnected";
            this.btnConnect.UseVisualStyleBackColor = false;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // txtPWD
            // 
            this.txtPWD.Location = new System.Drawing.Point(609, 154);
            this.txtPWD.Name = "txtPWD";
            this.txtPWD.Size = new System.Drawing.Size(162, 50);
            this.txtPWD.TabIndex = 9;
            this.txtPWD.Text = "1833";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(227, 154);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(162, 50);
            this.txtUserName.TabIndex = 8;
            this.txtUserName.Text = "1833";
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(641, 85);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(130, 50);
            this.txtPort.TabIndex = 7;
            this.txtPort.Text = "1833";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(411, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(188, 37);
            this.label5.TabIndex = 6;
            this.label5.Text = "Password:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(188, 37);
            this.label6.TabIndex = 5;
            this.label6.Text = "UserName:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 98);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 37);
            this.label7.TabIndex = 4;
            this.label7.Text = "Port:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(20, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(237, 37);
            this.label4.TabIndex = 1;
            this.label4.Text = "MQTT Client";
            // 
            // pnlStatus
            // 
            this.pnlStatus.BackColor = System.Drawing.Color.LightGray;
            this.pnlStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlStatus.Controls.Add(this.lblStatus);
            this.pnlStatus.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlStatus.Location = new System.Drawing.Point(0, 1210);
            this.pnlStatus.Name = "pnlStatus";
            this.pnlStatus.Size = new System.Drawing.Size(2279, 60);
            this.pnlStatus.TabIndex = 1;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblStatus.Location = new System.Drawing.Point(12, 17);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(159, 33);
            this.lblStatus.TabIndex = 0;
            this.lblStatus.Text = "Not Start";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(24, 291);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(186, 74);
            this.label15.TabIndex = 19;
            this.label15.Text = "Qos:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(602, 294);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(300, 74);
            this.label16.TabIndex = 20;
            this.label16.Text = "Retain:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2279, 1270);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.pnlStatus);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Simple MQTT";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.pnlStatus.ResumeLayout(false);
            this.pnlStatus.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblPWD;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListBox lbxMonitor;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtPWD;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnPublish_C;
        private System.Windows.Forms.RichTextBox rtbpubPayload_C;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RichTextBox rtbpubTopic_C;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button btnSubscribe;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RichTextBox rtbSubTopic_C;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtIPAddr;
        private System.Windows.Forms.Button btnServerStart;
        private System.Windows.Forms.Panel pnlStatus;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtClientID;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPublish_s;
        private System.Windows.Forms.RichTextBox rtbPayload_S;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox rtbPublishTopic_S;
        private System.Windows.Forms.ComboBox cmbQos;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cmbRetain;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
    }
}


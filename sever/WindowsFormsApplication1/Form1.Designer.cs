namespace WindowsFormsApplication1
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bt_stoplisten = new System.Windows.Forms.Button();
            this.cmb_socket = new System.Windows.Forms.ComboBox();
            this.bt_startlisten = new System.Windows.Forms.Button();
            this.txb_port = new System.Windows.Forms.TextBox();
            this.txb_ip = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bt_clear = new System.Windows.Forms.Button();
            this.txt_log = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label24 = new System.Windows.Forms.Label();
            this.tb_co = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_hum = new System.Windows.Forms.TextBox();
            this.tb_tmp = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.颗粒物浓度 = new System.Windows.Forms.GroupBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tb_10_0um = new System.Windows.Forms.TextBox();
            this.tb_5_0um = new System.Windows.Forms.TextBox();
            this.tb_2_5um = new System.Windows.Forms.TextBox();
            this.tb_1_0um = new System.Windows.Forms.TextBox();
            this.tb_0_5um = new System.Windows.Forms.TextBox();
            this.tb_0_3um = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.PM10 = new System.Windows.Forms.TextBox();
            this.PM2_5 = new System.Windows.Forms.TextBox();
            this.PM1_0 = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.PM10_CF1 = new System.Windows.Forms.TextBox();
            this.PM2_5_CF1 = new System.Windows.Forms.TextBox();
            this.PM1_0_CF1 = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label23 = new System.Windows.Forms.Label();
            this.pb_pm10 = new System.Windows.Forms.PictureBox();
            this.label22 = new System.Windows.Forms.Label();
            this.pb_pm25 = new System.Windows.Forms.PictureBox();
            this.label21 = new System.Windows.Forms.Label();
            this.pb_pm1 = new System.Windows.Forms.PictureBox();
            this.label20 = new System.Windows.Forms.Label();
            this.pb_co = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.颗粒物浓度.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_pm10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_pm25)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_pm1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_co)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bt_stoplisten);
            this.groupBox1.Controls.Add(this.cmb_socket);
            this.groupBox1.Controls.Add(this.bt_startlisten);
            this.groupBox1.Controls.Add(this.txb_port);
            this.groupBox1.Controls.Add(this.txb_ip);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(26, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(647, 141);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Socket状态";
            // 
            // bt_stoplisten
            // 
            this.bt_stoplisten.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bt_stoplisten.Location = new System.Drawing.Point(433, 86);
            this.bt_stoplisten.Name = "bt_stoplisten";
            this.bt_stoplisten.Size = new System.Drawing.Size(98, 40);
            this.bt_stoplisten.TabIndex = 8;
            this.bt_stoplisten.Text = "停止监听";
            this.bt_stoplisten.UseVisualStyleBackColor = true;
            this.bt_stoplisten.Click += new System.EventHandler(this.bt_stoplisten_Click);
            // 
            // cmb_socket
            // 
            this.cmb_socket.FormattingEnabled = true;
            this.cmb_socket.Location = new System.Drawing.Point(371, 40);
            this.cmb_socket.Name = "cmb_socket";
            this.cmb_socket.Size = new System.Drawing.Size(264, 31);
            this.cmb_socket.TabIndex = 7;
            // 
            // bt_startlisten
            // 
            this.bt_startlisten.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bt_startlisten.Location = new System.Drawing.Point(273, 86);
            this.bt_startlisten.Name = "bt_startlisten";
            this.bt_startlisten.Size = new System.Drawing.Size(98, 40);
            this.bt_startlisten.TabIndex = 6;
            this.bt_startlisten.Text = "开启监听";
            this.bt_startlisten.UseVisualStyleBackColor = true;
            this.bt_startlisten.Click += new System.EventHandler(this.bt_startlisten_Click);
            // 
            // txb_port
            // 
            this.txb_port.Location = new System.Drawing.Point(79, 90);
            this.txb_port.Name = "txb_port";
            this.txb_port.Size = new System.Drawing.Size(98, 34);
            this.txb_port.TabIndex = 4;
            // 
            // txb_ip
            // 
            this.txb_ip.Location = new System.Drawing.Point(79, 40);
            this.txb_ip.Name = "txb_ip";
            this.txb_ip.Size = new System.Drawing.Size(174, 34);
            this.txb_ip.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(269, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "远程端口";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "PORT";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(39, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bt_clear);
            this.groupBox2.Controls.Add(this.txt_log);
            this.groupBox2.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.Location = new System.Drawing.Point(26, 383);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(647, 222);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "数据接收窗口";
            // 
            // bt_clear
            // 
            this.bt_clear.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bt_clear.Location = new System.Drawing.Point(537, 99);
            this.bt_clear.Name = "bt_clear";
            this.bt_clear.Size = new System.Drawing.Size(98, 40);
            this.bt_clear.TabIndex = 7;
            this.bt_clear.Text = "清空数据";
            this.bt_clear.UseVisualStyleBackColor = true;
            this.bt_clear.Click += new System.EventHandler(this.button2_Click);
            // 
            // txt_log
            // 
            this.txt_log.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_log.Location = new System.Drawing.Point(15, 48);
            this.txt_log.Multiline = true;
            this.txt_log.Name = "txt_log";
            this.txt_log.ReadOnly = true;
            this.txt_log.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_log.Size = new System.Drawing.Size(516, 148);
            this.txt_log.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label24);
            this.groupBox4.Controls.Add(this.tb_co);
            this.groupBox4.Controls.Add(this.label25);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.tb_hum);
            this.groupBox4.Controls.Add(this.tb_tmp);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox4.Location = new System.Drawing.Point(26, 186);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(647, 183);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "温湿度和CO浓度";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label24.ForeColor = System.Drawing.Color.Maroon;
            this.label24.Location = new System.Drawing.Point(244, 123);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(88, 30);
            this.label24.TabIndex = 11;
            this.label24.Text = "mg/m3";
            // 
            // tb_co
            // 
            this.tb_co.BackColor = System.Drawing.Color.Black;
            this.tb_co.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_co.ForeColor = System.Drawing.Color.White;
            this.tb_co.Location = new System.Drawing.Point(110, 123);
            this.tb_co.Name = "tb_co";
            this.tb_co.ReadOnly = true;
            this.tb_co.Size = new System.Drawing.Size(128, 38);
            this.tb_co.TabIndex = 10;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(22, 129);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(82, 24);
            this.label25.TabIndex = 9;
            this.label25.Text = "CO浓度";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.ForeColor = System.Drawing.Color.Maroon;
            this.label7.Location = new System.Drawing.Point(227, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 30);
            this.label7.TabIndex = 8;
            this.label7.Text = "℃";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(544, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 30);
            this.label6.TabIndex = 7;
            this.label6.Text = "%RH";
            // 
            // tb_hum
            // 
            this.tb_hum.BackColor = System.Drawing.Color.Black;
            this.tb_hum.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_hum.ForeColor = System.Drawing.Color.White;
            this.tb_hum.Location = new System.Drawing.Point(433, 59);
            this.tb_hum.Name = "tb_hum";
            this.tb_hum.ReadOnly = true;
            this.tb_hum.Size = new System.Drawing.Size(105, 38);
            this.tb_hum.TabIndex = 3;
            // 
            // tb_tmp
            // 
            this.tb_tmp.BackColor = System.Drawing.Color.Black;
            this.tb_tmp.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_tmp.ForeColor = System.Drawing.Color.White;
            this.tb_tmp.Location = new System.Drawing.Point(110, 59);
            this.tb_tmp.Name = "tb_tmp";
            this.tb_tmp.ReadOnly = true;
            this.tb_tmp.Size = new System.Drawing.Size(111, 38);
            this.tb_tmp.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(369, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 24);
            this.label5.TabIndex = 1;
            this.label5.Text = "湿度";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "温度";
            // 
            // 颗粒物浓度
            // 
            this.颗粒物浓度.Controls.Add(this.groupBox8);
            this.颗粒物浓度.Controls.Add(this.groupBox6);
            this.颗粒物浓度.Controls.Add(this.groupBox5);
            this.颗粒物浓度.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.颗粒物浓度.Location = new System.Drawing.Point(706, 26);
            this.颗粒物浓度.Name = "颗粒物浓度";
            this.颗粒物浓度.Size = new System.Drawing.Size(649, 579);
            this.颗粒物浓度.TabIndex = 14;
            this.颗粒物浓度.TabStop = false;
            this.颗粒物浓度.Text = "颗粒物浓度";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.label15);
            this.groupBox8.Controls.Add(this.label14);
            this.groupBox8.Controls.Add(this.label13);
            this.groupBox8.Controls.Add(this.label12);
            this.groupBox8.Controls.Add(this.label11);
            this.groupBox8.Controls.Add(this.label10);
            this.groupBox8.Controls.Add(this.tb_10_0um);
            this.groupBox8.Controls.Add(this.tb_5_0um);
            this.groupBox8.Controls.Add(this.tb_2_5um);
            this.groupBox8.Controls.Add(this.tb_1_0um);
            this.groupBox8.Controls.Add(this.tb_0_5um);
            this.groupBox8.Controls.Add(this.tb_0_3um);
            this.groupBox8.Location = new System.Drawing.Point(22, 235);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(598, 318);
            this.groupBox8.TabIndex = 3;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "0.1升空气中颗粒物个数";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label15.Location = new System.Drawing.Point(176, 268);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(178, 24);
            this.label15.TabIndex = 14;
            this.label15.Text = "直径在10um以下";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label14.Location = new System.Drawing.Point(176, 219);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(190, 24);
            this.label14.TabIndex = 13;
            this.label14.Text = "直径在5.0um以下";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label13.Location = new System.Drawing.Point(176, 173);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(190, 24);
            this.label13.TabIndex = 12;
            this.label13.Text = "直径在2.5um以下";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label12.Location = new System.Drawing.Point(176, 124);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(190, 24);
            this.label12.TabIndex = 11;
            this.label12.Text = "直径在1.0um以下";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.Location = new System.Drawing.Point(176, 84);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(190, 24);
            this.label11.TabIndex = 10;
            this.label11.Text = "直径在0.5um以下";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.Location = new System.Drawing.Point(176, 38);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(190, 24);
            this.label10.TabIndex = 9;
            this.label10.Text = "直径在0.3um以下";
            // 
            // tb_10_0um
            // 
            this.tb_10_0um.BackColor = System.Drawing.SystemColors.InfoText;
            this.tb_10_0um.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_10_0um.ForeColor = System.Drawing.Color.White;
            this.tb_10_0um.Location = new System.Drawing.Point(26, 265);
            this.tb_10_0um.Name = "tb_10_0um";
            this.tb_10_0um.ReadOnly = true;
            this.tb_10_0um.Size = new System.Drawing.Size(144, 38);
            this.tb_10_0um.TabIndex = 8;
            // 
            // tb_5_0um
            // 
            this.tb_5_0um.BackColor = System.Drawing.SystemColors.InfoText;
            this.tb_5_0um.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_5_0um.ForeColor = System.Drawing.Color.White;
            this.tb_5_0um.Location = new System.Drawing.Point(26, 216);
            this.tb_5_0um.Name = "tb_5_0um";
            this.tb_5_0um.ReadOnly = true;
            this.tb_5_0um.Size = new System.Drawing.Size(144, 38);
            this.tb_5_0um.TabIndex = 7;
            // 
            // tb_2_5um
            // 
            this.tb_2_5um.BackColor = System.Drawing.SystemColors.InfoText;
            this.tb_2_5um.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_2_5um.ForeColor = System.Drawing.Color.White;
            this.tb_2_5um.Location = new System.Drawing.Point(26, 170);
            this.tb_2_5um.Name = "tb_2_5um";
            this.tb_2_5um.ReadOnly = true;
            this.tb_2_5um.Size = new System.Drawing.Size(144, 38);
            this.tb_2_5um.TabIndex = 6;
            // 
            // tb_1_0um
            // 
            this.tb_1_0um.BackColor = System.Drawing.Color.Black;
            this.tb_1_0um.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_1_0um.ForeColor = System.Drawing.Color.White;
            this.tb_1_0um.Location = new System.Drawing.Point(26, 121);
            this.tb_1_0um.Name = "tb_1_0um";
            this.tb_1_0um.ReadOnly = true;
            this.tb_1_0um.Size = new System.Drawing.Size(144, 38);
            this.tb_1_0um.TabIndex = 5;
            // 
            // tb_0_5um
            // 
            this.tb_0_5um.BackColor = System.Drawing.SystemColors.InfoText;
            this.tb_0_5um.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_0_5um.ForeColor = System.Drawing.Color.White;
            this.tb_0_5um.Location = new System.Drawing.Point(26, 81);
            this.tb_0_5um.Name = "tb_0_5um";
            this.tb_0_5um.ReadOnly = true;
            this.tb_0_5um.Size = new System.Drawing.Size(144, 38);
            this.tb_0_5um.TabIndex = 4;
            // 
            // tb_0_3um
            // 
            this.tb_0_3um.BackColor = System.Drawing.SystemColors.InfoText;
            this.tb_0_3um.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_0_3um.ForeColor = System.Drawing.Color.White;
            this.tb_0_3um.Location = new System.Drawing.Point(26, 35);
            this.tb_0_3um.Name = "tb_0_3um";
            this.tb_0_3um.ReadOnly = true;
            this.tb_0_3um.Size = new System.Drawing.Size(144, 38);
            this.tb_0_3um.TabIndex = 3;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label9);
            this.groupBox6.Controls.Add(this.label8);
            this.groupBox6.Controls.Add(this.label16);
            this.groupBox6.Controls.Add(this.PM10);
            this.groupBox6.Controls.Add(this.PM2_5);
            this.groupBox6.Controls.Add(this.PM1_0);
            this.groupBox6.Location = new System.Drawing.Point(334, 33);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(286, 177);
            this.groupBox6.TabIndex = 1;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "大气环境下(单位ug/m3)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(140, 136);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 24);
            this.label9.TabIndex = 8;
            this.label9.Text = "PM10";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(140, 84);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 24);
            this.label8.TabIndex = 7;
            this.label8.Text = "PM2.5";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label16.Location = new System.Drawing.Point(140, 36);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(70, 24);
            this.label16.TabIndex = 6;
            this.label16.Text = "PM1.0";
            // 
            // PM10
            // 
            this.PM10.BackColor = System.Drawing.Color.Black;
            this.PM10.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.PM10.ForeColor = System.Drawing.Color.White;
            this.PM10.Location = new System.Drawing.Point(28, 130);
            this.PM10.Name = "PM10";
            this.PM10.ReadOnly = true;
            this.PM10.Size = new System.Drawing.Size(106, 38);
            this.PM10.TabIndex = 5;
            // 
            // PM2_5
            // 
            this.PM2_5.BackColor = System.Drawing.SystemColors.InfoText;
            this.PM2_5.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.PM2_5.ForeColor = System.Drawing.Color.White;
            this.PM2_5.Location = new System.Drawing.Point(28, 79);
            this.PM2_5.Name = "PM2_5";
            this.PM2_5.ReadOnly = true;
            this.PM2_5.Size = new System.Drawing.Size(106, 38);
            this.PM2_5.TabIndex = 4;
            // 
            // PM1_0
            // 
            this.PM1_0.BackColor = System.Drawing.SystemColors.InfoText;
            this.PM1_0.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.PM1_0.ForeColor = System.Drawing.Color.White;
            this.PM1_0.Location = new System.Drawing.Point(28, 33);
            this.PM1_0.Name = "PM1_0";
            this.PM1_0.ReadOnly = true;
            this.PM1_0.Size = new System.Drawing.Size(106, 38);
            this.PM1_0.TabIndex = 3;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label17);
            this.groupBox5.Controls.Add(this.label18);
            this.groupBox5.Controls.Add(this.label19);
            this.groupBox5.Controls.Add(this.PM10_CF1);
            this.groupBox5.Controls.Add(this.PM2_5_CF1);
            this.groupBox5.Controls.Add(this.PM1_0_CF1);
            this.groupBox5.ForeColor = System.Drawing.Color.Black;
            this.groupBox5.Location = new System.Drawing.Point(22, 32);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(282, 178);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "标准颗粒物(单位ug/m3)";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label17.Location = new System.Drawing.Point(138, 131);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(58, 24);
            this.label17.TabIndex = 5;
            this.label17.Text = "PM10";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label18.Location = new System.Drawing.Point(138, 86);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(70, 24);
            this.label18.TabIndex = 4;
            this.label18.Text = "PM2.5";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label19.Location = new System.Drawing.Point(138, 40);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(70, 24);
            this.label19.TabIndex = 3;
            this.label19.Text = "PM1.0";
            // 
            // PM10_CF1
            // 
            this.PM10_CF1.BackColor = System.Drawing.SystemColors.InfoText;
            this.PM10_CF1.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.PM10_CF1.ForeColor = System.Drawing.Color.White;
            this.PM10_CF1.Location = new System.Drawing.Point(26, 128);
            this.PM10_CF1.Name = "PM10_CF1";
            this.PM10_CF1.ReadOnly = true;
            this.PM10_CF1.Size = new System.Drawing.Size(106, 38);
            this.PM10_CF1.TabIndex = 2;
            // 
            // PM2_5_CF1
            // 
            this.PM2_5_CF1.BackColor = System.Drawing.SystemColors.InfoText;
            this.PM2_5_CF1.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.PM2_5_CF1.ForeColor = System.Drawing.Color.White;
            this.PM2_5_CF1.Location = new System.Drawing.Point(26, 79);
            this.PM2_5_CF1.Name = "PM2_5_CF1";
            this.PM2_5_CF1.ReadOnly = true;
            this.PM2_5_CF1.Size = new System.Drawing.Size(106, 38);
            this.PM2_5_CF1.TabIndex = 1;
            // 
            // PM1_0_CF1
            // 
            this.PM1_0_CF1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.PM1_0_CF1.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.PM1_0_CF1.ForeColor = System.Drawing.Color.White;
            this.PM1_0_CF1.Location = new System.Drawing.Point(26, 33);
            this.PM1_0_CF1.Name = "PM1_0_CF1";
            this.PM1_0_CF1.ReadOnly = true;
            this.PM1_0_CF1.Size = new System.Drawing.Size(106, 38);
            this.PM1_0_CF1.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label23);
            this.groupBox3.Controls.Add(this.pb_pm10);
            this.groupBox3.Controls.Add(this.label22);
            this.groupBox3.Controls.Add(this.pb_pm25);
            this.groupBox3.Controls.Add(this.label21);
            this.groupBox3.Controls.Add(this.pb_pm1);
            this.groupBox3.Controls.Add(this.label20);
            this.groupBox3.Controls.Add(this.pb_co);
            this.groupBox3.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox3.Location = new System.Drawing.Point(26, 626);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1056, 94);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "判断区";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label23.Location = new System.Drawing.Point(850, 47);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(89, 20);
            this.label23.TabIndex = 7;
            this.label23.Text = "PM10浓度";
            // 
            // pb_pm10
            // 
            this.pb_pm10.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.Y;
            this.pb_pm10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_pm10.Location = new System.Drawing.Point(945, 37);
            this.pb_pm10.Name = "pb_pm10";
            this.pb_pm10.Size = new System.Drawing.Size(72, 39);
            this.pb_pm10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_pm10.TabIndex = 6;
            this.pb_pm10.TabStop = false;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label22.Location = new System.Drawing.Point(560, 47);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(99, 20);
            this.label22.TabIndex = 5;
            this.label22.Text = "PM2.5浓度";
            // 
            // pb_pm25
            // 
            this.pb_pm25.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.Y;
            this.pb_pm25.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_pm25.Location = new System.Drawing.Point(665, 37);
            this.pb_pm25.Name = "pb_pm25";
            this.pb_pm25.Size = new System.Drawing.Size(72, 39);
            this.pb_pm25.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_pm25.TabIndex = 4;
            this.pb_pm25.TabStop = false;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label21.Location = new System.Drawing.Point(280, 47);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(99, 20);
            this.label21.TabIndex = 3;
            this.label21.Text = "PM1.0浓度";
            // 
            // pb_pm1
            // 
            this.pb_pm1.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.Y;
            this.pb_pm1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_pm1.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.pb_pm1.Location = new System.Drawing.Point(385, 37);
            this.pb_pm1.Name = "pb_pm1";
            this.pb_pm1.Size = new System.Drawing.Size(72, 39);
            this.pb_pm1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_pm1.TabIndex = 2;
            this.pb_pm1.TabStop = false;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label20.Location = new System.Drawing.Point(22, 47);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(69, 20);
            this.label20.TabIndex = 1;
            this.label20.Text = "CO浓度";
            // 
            // pb_co
            // 
            this.pb_co.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.Y;
            this.pb_co.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_co.Location = new System.Drawing.Point(97, 37);
            this.pb_co.Name = "pb_co";
            this.pb_co.Size = new System.Drawing.Size(72, 39);
            this.pb_co.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_co.TabIndex = 0;
            this.pb_co.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1372, 734);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.颗粒物浓度);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "空气质量检测系统";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.颗粒物浓度.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_pm10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_pm25)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_pm1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_co)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txb_ip;
        private System.Windows.Forms.TextBox txb_port;
        private System.Windows.Forms.Button bt_startlisten;
        private System.Windows.Forms.ComboBox cmb_socket;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_log;
        private System.Windows.Forms.Button bt_clear;
        private System.Windows.Forms.Button bt_stoplisten;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_hum;
        private System.Windows.Forms.TextBox tb_tmp;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox 颗粒物浓度;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tb_10_0um;
        private System.Windows.Forms.TextBox tb_5_0um;
        private System.Windows.Forms.TextBox tb_2_5um;
        private System.Windows.Forms.TextBox tb_1_0um;
        private System.Windows.Forms.TextBox tb_0_5um;
        private System.Windows.Forms.TextBox tb_0_3um;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox PM10;
        private System.Windows.Forms.TextBox PM2_5;
        private System.Windows.Forms.TextBox PM1_0;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox PM10_CF1;
        private System.Windows.Forms.TextBox PM2_5_CF1;
        private System.Windows.Forms.TextBox PM1_0_CF1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.PictureBox pb_co;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.PictureBox pb_pm1;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.PictureBox pb_pm10;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.PictureBox pb_pm25;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox tb_co;
        private System.Windows.Forms.Label label25;
    }
}


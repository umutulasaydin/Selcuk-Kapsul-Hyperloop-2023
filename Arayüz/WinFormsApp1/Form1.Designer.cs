namespace WinFormsApp1
{
    partial class Kapsul_Hyperloop
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.progress_bar_value = new System.Windows.Forms.Label();
            this.ping = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.serverIp = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.TextBox();
            this.login = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.frenNoktasi = new System.Windows.Forms.TextBox();
            this.fren_save = new System.Windows.Forms.Button();
            this.start = new System.Windows.Forms.Button();
            this.stop = new System.Windows.Forms.Button();
            this.emergency = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lev_start = new System.Windows.Forms.Button();
            this.lev_stop = new System.Windows.Forms.Button();
            this.motor_stop = new System.Windows.Forms.Button();
            this.motor_go = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.brake_close = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.fren_hareketsiz = new System.Windows.Forms.Button();
            this.brake_open = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.connect = new System.Windows.Forms.Button();
            this.max_hız = new System.Windows.Forms.Label();
            this.temp1 = new System.Windows.Forms.Label();
            this.temp2 = new System.Windows.Forms.Label();
            this.pow = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.velo_z = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.pos_x = new System.Windows.Forms.Label();
            this.pos_y = new System.Windows.Forms.Label();
            this.pos_z = new System.Windows.Forms.Label();
            this.velo_x = new System.Windows.Forms.Label();
            this.velo_y = new System.Windows.Forms.Label();
            this.acc_x = new System.Windows.Forms.Label();
            this.acc_y = new System.Windows.Forms.Label();
            this.acc_z = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.roll = new System.Windows.Forms.Label();
            this.yaw = new System.Windows.Forms.Label();
            this.pitch = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.phase = new System.Windows.Forms.Label();
            this.log = new System.Windows.Forms.RichTextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.save_csv = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.count = new System.Windows.Forms.Label();
            this.nav_test = new System.Windows.Forms.Button();
            this.test_text = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.kumanda = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(387, 793);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(589, 23);
            this.progressBar1.TabIndex = 0;
            // 
            // progress_bar_value
            // 
            this.progress_bar_value.AutoSize = true;
            this.progress_bar_value.Location = new System.Drawing.Point(671, 797);
            this.progress_bar_value.Name = "progress_bar_value";
            this.progress_bar_value.Size = new System.Drawing.Size(23, 15);
            this.progress_bar_value.TabIndex = 1;
            this.progress_bar_value.Text = "%0";
            // 
            // ping
            // 
            this.ping.AutoSize = true;
            this.ping.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ping.ForeColor = System.Drawing.Color.Red;
            this.ping.Location = new System.Drawing.Point(268, 793);
            this.ping.Name = "ping";
            this.ping.Size = new System.Drawing.Size(110, 25);
            this.ping.TabIndex = 2;
            this.ping.Text = "PING: 0 ms";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1095, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Pod IP:";
            // 
            // serverIp
            // 
            this.serverIp.Enabled = false;
            this.serverIp.Location = new System.Drawing.Point(1145, 25);
            this.serverIp.Name = "serverIp";
            this.serverIp.Size = new System.Drawing.Size(100, 23);
            this.serverIp.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Kullanıcı Adı:";
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(133, 22);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(100, 23);
            this.username.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(94, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Şifre:";
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(133, 56);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(100, 23);
            this.password.TabIndex = 9;
            this.password.UseSystemPasswordChar = true;
            // 
            // login
            // 
            this.login.Location = new System.Drawing.Point(143, 85);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(75, 23);
            this.login.TabIndex = 10;
            this.login.Text = "Giriş";
            this.login.UseVisualStyleBackColor = true;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1063, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "Fren Noktası:";
            // 
            // frenNoktasi
            // 
            this.frenNoktasi.Enabled = false;
            this.frenNoktasi.Location = new System.Drawing.Point(1145, 170);
            this.frenNoktasi.Name = "frenNoktasi";
            this.frenNoktasi.Size = new System.Drawing.Size(100, 23);
            this.frenNoktasi.TabIndex = 12;
            // 
            // fren_save
            // 
            this.fren_save.Enabled = false;
            this.fren_save.Location = new System.Drawing.Point(1251, 169);
            this.fren_save.Name = "fren_save";
            this.fren_save.Size = new System.Drawing.Size(75, 23);
            this.fren_save.TabIndex = 13;
            this.fren_save.Text = "Kaydet";
            this.fren_save.UseVisualStyleBackColor = true;
            this.fren_save.Click += new System.EventHandler(this.fren_save_Click);
            // 
            // start
            // 
            this.start.Enabled = false;
            this.start.Location = new System.Drawing.Point(1145, 216);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(130, 50);
            this.start.TabIndex = 14;
            this.start.Text = "BAŞLAT";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // stop
            // 
            this.stop.Enabled = false;
            this.stop.Location = new System.Drawing.Point(1145, 283);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(130, 50);
            this.stop.TabIndex = 15;
            this.stop.Text = "DURDUR";
            this.stop.UseVisualStyleBackColor = true;
            this.stop.Click += new System.EventHandler(this.stop_Click);
            // 
            // emergency
            // 
            this.emergency.Enabled = false;
            this.emergency.Location = new System.Drawing.Point(1145, 353);
            this.emergency.Name = "emergency";
            this.emergency.Size = new System.Drawing.Size(130, 50);
            this.emergency.TabIndex = 16;
            this.emergency.Text = "ACİL DURUM";
            this.emergency.UseVisualStyleBackColor = true;
            this.emergency.Click += new System.EventHandler(this.emergency_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(85, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 15);
            this.label5.TabIndex = 17;
            this.label5.Text = "Levitasyon";
            // 
            // lev_start
            // 
            this.lev_start.Enabled = false;
            this.lev_start.Location = new System.Drawing.Point(11, 50);
            this.lev_start.Name = "lev_start";
            this.lev_start.Size = new System.Drawing.Size(92, 33);
            this.lev_start.TabIndex = 18;
            this.lev_start.Text = "AÇ";
            this.lev_start.UseVisualStyleBackColor = true;
            this.lev_start.Click += new System.EventHandler(this.lev_start_Click);
            // 
            // lev_stop
            // 
            this.lev_stop.Enabled = false;
            this.lev_stop.Location = new System.Drawing.Point(130, 50);
            this.lev_stop.Name = "lev_stop";
            this.lev_stop.Size = new System.Drawing.Size(92, 33);
            this.lev_stop.TabIndex = 19;
            this.lev_stop.Text = "KAPA";
            this.lev_stop.UseVisualStyleBackColor = true;
            this.lev_stop.Click += new System.EventHandler(this.lev_stop_Click);
            // 
            // motor_stop
            // 
            this.motor_stop.Enabled = false;
            this.motor_stop.Location = new System.Drawing.Point(150, 44);
            this.motor_stop.Name = "motor_stop";
            this.motor_stop.Size = new System.Drawing.Size(71, 33);
            this.motor_stop.TabIndex = 25;
            this.motor_stop.Text = "DUR";
            this.motor_stop.UseVisualStyleBackColor = true;
            this.motor_stop.Click += new System.EventHandler(this.motor_stop_Click);
            // 
            // motor_go
            // 
            this.motor_go.Enabled = false;
            this.motor_go.Location = new System.Drawing.Point(81, 44);
            this.motor_go.Name = "motor_go";
            this.motor_go.Size = new System.Drawing.Size(67, 33);
            this.motor_go.TabIndex = 24;
            this.motor_go.Text = "İLERLE";
            this.motor_go.UseVisualStyleBackColor = true;
            this.motor_go.Click += new System.EventHandler(this.motor_go_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(93, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 15);
            this.label7.TabIndex = 23;
            this.label7.Text = "Motor";
            // 
            // brake_close
            // 
            this.brake_close.Enabled = false;
            this.brake_close.Location = new System.Drawing.Point(150, 45);
            this.brake_close.Name = "brake_close";
            this.brake_close.Size = new System.Drawing.Size(70, 33);
            this.brake_close.TabIndex = 28;
            this.brake_close.Text = "KAPA";
            this.brake_close.UseVisualStyleBackColor = true;
            this.brake_close.Click += new System.EventHandler(this.brake_close_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(97, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 15);
            this.label8.TabIndex = 26;
            this.label8.Text = "Fren";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.lev_start);
            this.panel1.Controls.Add(this.lev_stop);
            this.panel1.Location = new System.Drawing.Point(51, 119);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(231, 100);
            this.panel1.TabIndex = 29;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.button5);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.motor_go);
            this.panel3.Controls.Add(this.motor_stop);
            this.panel3.Location = new System.Drawing.Point(51, 225);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(231, 100);
            this.panel3.TabIndex = 31;
            // 
            // button5
            // 
            this.button5.Enabled = false;
            this.button5.Location = new System.Drawing.Point(11, 44);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(67, 33);
            this.button5.TabIndex = 26;
            this.button5.Text = "HIZLI";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.fren_hareketsiz);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.brake_open);
            this.panel4.Controls.Add(this.brake_close);
            this.panel4.Location = new System.Drawing.Point(51, 331);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(231, 100);
            this.panel4.TabIndex = 32;
            // 
            // fren_hareketsiz
            // 
            this.fren_hareketsiz.Enabled = false;
            this.fren_hareketsiz.Location = new System.Drawing.Point(81, 45);
            this.fren_hareketsiz.Name = "fren_hareketsiz";
            this.fren_hareketsiz.Size = new System.Drawing.Size(67, 33);
            this.fren_hareketsiz.TabIndex = 29;
            this.fren_hareketsiz.Text = "DUR";
            this.fren_hareketsiz.UseVisualStyleBackColor = true;
            this.fren_hareketsiz.Click += new System.EventHandler(this.fren_hareketsiz_Click);
            // 
            // brake_open
            // 
            this.brake_open.Enabled = false;
            this.brake_open.Location = new System.Drawing.Point(11, 45);
            this.brake_open.Name = "brake_open";
            this.brake_open.Size = new System.Drawing.Size(64, 33);
            this.brake_open.TabIndex = 27;
            this.brake_open.Text = "AÇ";
            this.brake_open.UseVisualStyleBackColor = true;
            this.brake_open.Click += new System.EventHandler(this.brake_open_Click);
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.button2);
            this.panel5.Controls.Add(this.button1);
            this.panel5.Controls.Add(this.label9);
            this.panel5.Location = new System.Drawing.Point(51, 437);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(231, 100);
            this.panel5.TabIndex = 33;
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(128, 42);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 33);
            this.button2.TabIndex = 29;
            this.button2.Text = "KAPA";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(11, 42);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 33);
            this.button1.TabIndex = 29;
            this.button1.Text = "AÇ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(87, 12);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 15);
            this.label9.TabIndex = 29;
            this.label9.Text = "Aktüator";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // connect
            // 
            this.connect.Enabled = false;
            this.connect.Location = new System.Drawing.Point(1256, 24);
            this.connect.Name = "connect";
            this.connect.Size = new System.Drawing.Size(75, 23);
            this.connect.TabIndex = 34;
            this.connect.Text = "Bağlan";
            this.connect.UseVisualStyleBackColor = true;
            this.connect.Click += new System.EventHandler(this.connect_Click);
            // 
            // max_hız
            // 
            this.max_hız.AutoSize = true;
            this.max_hız.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.max_hız.ForeColor = System.Drawing.Color.Black;
            this.max_hız.Location = new System.Drawing.Point(1108, 787);
            this.max_hız.Name = "max_hız";
            this.max_hız.Size = new System.Drawing.Size(222, 25);
            this.max_hız.TabIndex = 35;
            this.max_hız.Text = "Maksimum Hız : 0 km/h";
            // 
            // temp1
            // 
            this.temp1.AutoSize = true;
            this.temp1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.temp1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.temp1.Location = new System.Drawing.Point(1108, 425);
            this.temp1.Name = "temp1";
            this.temp1.Size = new System.Drawing.Size(154, 25);
            this.temp1.TabIndex = 36;
            this.temp1.Text = "Sıcaklık (1): 0 °C";
            // 
            // temp2
            // 
            this.temp2.AutoSize = true;
            this.temp2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.temp2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.temp2.Location = new System.Drawing.Point(1108, 479);
            this.temp2.Name = "temp2";
            this.temp2.Size = new System.Drawing.Size(154, 25);
            this.temp2.TabIndex = 37;
            this.temp2.Text = "Sıcaklık (2): 0 °C";
            // 
            // pow
            // 
            this.pow.AutoSize = true;
            this.pow.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pow.Location = new System.Drawing.Point(1108, 531);
            this.pow.Name = "pow";
            this.pow.Size = new System.Drawing.Size(196, 25);
            this.pow.TabIndex = 38;
            this.pow.Text = "Güç Tüketimi: 0 kWh";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.velo_z, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.label11, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label12, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label13, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label14, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label15, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label16, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.pos_x, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.pos_y, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.pos_z, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.velo_x, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.velo_y, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.acc_x, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.acc_y, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.acc_z, 3, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(414, 85);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(539, 389);
            this.tableLayoutPanel1.TabIndex = 39;
            // 
            // velo_z
            // 
            this.velo_z.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.velo_z.AutoSize = true;
            this.velo_z.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.velo_z.Location = new System.Drawing.Point(441, 230);
            this.velo_z.Name = "velo_z";
            this.velo_z.Size = new System.Drawing.Size(58, 25);
            this.velo_z.TabIndex = 40;
            this.velo_z.Text = "0 m/s";
            this.velo_z.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(27, 131);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(81, 30);
            this.label11.TabIndex = 0;
            this.label11.Text = "Konum";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(45, 228);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 30);
            this.label12.TabIndex = 1;
            this.label12.Text = "Hız";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(37, 325);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(60, 30);
            this.label13.TabIndex = 2;
            this.label13.Text = "İvme";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(155, 34);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(92, 30);
            this.label14.TabIndex = 3;
            this.label14.Text = "X Ekseni";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label15.Location = new System.Drawing.Point(290, 34);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(91, 30);
            this.label15.TabIndex = 4;
            this.label15.Text = "Y Ekseni";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label16.Location = new System.Drawing.Point(425, 34);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(91, 30);
            this.label16.TabIndex = 5;
            this.label16.Text = "Z Ekseni";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pos_x
            // 
            this.pos_x.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pos_x.AutoSize = true;
            this.pos_x.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pos_x.Location = new System.Drawing.Point(180, 133);
            this.pos_x.Name = "pos_x";
            this.pos_x.Size = new System.Drawing.Size(43, 25);
            this.pos_x.TabIndex = 6;
            this.pos_x.Text = "0 m";
            this.pos_x.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pos_y
            // 
            this.pos_y.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pos_y.AutoSize = true;
            this.pos_y.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pos_y.Location = new System.Drawing.Point(314, 133);
            this.pos_y.Name = "pos_y";
            this.pos_y.Size = new System.Drawing.Size(43, 25);
            this.pos_y.TabIndex = 7;
            this.pos_y.Text = "0 m";
            this.pos_y.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pos_z
            // 
            this.pos_z.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pos_z.AutoSize = true;
            this.pos_z.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pos_z.Location = new System.Drawing.Point(449, 133);
            this.pos_z.Name = "pos_z";
            this.pos_z.Size = new System.Drawing.Size(43, 25);
            this.pos_z.TabIndex = 8;
            this.pos_z.Text = "0 m";
            this.pos_z.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // velo_x
            // 
            this.velo_x.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.velo_x.AutoSize = true;
            this.velo_x.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.velo_x.Location = new System.Drawing.Point(172, 230);
            this.velo_x.Name = "velo_x";
            this.velo_x.Size = new System.Drawing.Size(58, 25);
            this.velo_x.TabIndex = 9;
            this.velo_x.Text = "0 m/s";
            this.velo_x.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // velo_y
            // 
            this.velo_y.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.velo_y.AutoSize = true;
            this.velo_y.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.velo_y.Location = new System.Drawing.Point(306, 230);
            this.velo_y.Name = "velo_y";
            this.velo_y.Size = new System.Drawing.Size(58, 25);
            this.velo_y.TabIndex = 10;
            this.velo_y.Text = "0 m/s";
            this.velo_y.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // acc_x
            // 
            this.acc_x.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.acc_x.AutoSize = true;
            this.acc_x.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.acc_x.Location = new System.Drawing.Point(161, 327);
            this.acc_x.Name = "acc_x";
            this.acc_x.Size = new System.Drawing.Size(81, 25);
            this.acc_x.TabIndex = 41;
            this.acc_x.Text = "0 m/s^2";
            this.acc_x.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // acc_y
            // 
            this.acc_y.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.acc_y.AutoSize = true;
            this.acc_y.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.acc_y.Location = new System.Drawing.Point(295, 327);
            this.acc_y.Name = "acc_y";
            this.acc_y.Size = new System.Drawing.Size(81, 25);
            this.acc_y.TabIndex = 42;
            this.acc_y.Text = "0 m/s^2";
            this.acc_y.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // acc_z
            // 
            this.acc_z.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.acc_z.AutoSize = true;
            this.acc_z.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.acc_z.Location = new System.Drawing.Point(430, 327);
            this.acc_z.Name = "acc_z";
            this.acc_z.Size = new System.Drawing.Size(81, 25);
            this.acc_z.TabIndex = 43;
            this.acc_z.Text = "0 m/s^2";
            this.acc_z.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Controls.Add(this.roll, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.yaw, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.pitch, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label17, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label18, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label19, 2, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(1014, 571);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(312, 199);
            this.tableLayoutPanel2.TabIndex = 40;
            // 
            // roll
            // 
            this.roll.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.roll.AutoSize = true;
            this.roll.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.roll.Location = new System.Drawing.Point(35, 136);
            this.roll.Name = "roll";
            this.roll.Size = new System.Drawing.Size(34, 25);
            this.roll.TabIndex = 9;
            this.roll.Text = "0 °";
            this.roll.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // yaw
            // 
            this.yaw.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.yaw.AutoSize = true;
            this.yaw.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.yaw.Location = new System.Drawing.Point(138, 136);
            this.yaw.Name = "yaw";
            this.yaw.Size = new System.Drawing.Size(34, 25);
            this.yaw.TabIndex = 8;
            this.yaw.Text = "0 °";
            this.yaw.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.yaw.Click += new System.EventHandler(this.label21_Click);
            // 
            // pitch
            // 
            this.pitch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pitch.AutoSize = true;
            this.pitch.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pitch.Location = new System.Drawing.Point(242, 136);
            this.pitch.Name = "pitch";
            this.pitch.Size = new System.Drawing.Size(34, 25);
            this.pitch.TabIndex = 7;
            this.pitch.Text = "0 °";
            this.pitch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label17
            // 
            this.label17.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label17.Location = new System.Drawing.Point(27, 35);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(50, 30);
            this.label17.TabIndex = 4;
            this.label17.Text = "Roll";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label18
            // 
            this.label18.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label18.Location = new System.Drawing.Point(128, 35);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(53, 30);
            this.label18.TabIndex = 5;
            this.label18.Text = "Yaw";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label19
            // 
            this.label19.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label19.Location = new System.Drawing.Point(229, 35);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(60, 30);
            this.label19.TabIndex = 6;
            this.label19.Text = "Pitch";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // phase
            // 
            this.phase.AutoSize = true;
            this.phase.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.phase.Location = new System.Drawing.Point(640, 758);
            this.phase.Name = "phase";
            this.phase.Size = new System.Drawing.Size(96, 21);
            this.phase.TabIndex = 41;
            this.phase.Text = "Hazırlanıyor";
            // 
            // log
            // 
            this.log.Location = new System.Drawing.Point(414, 524);
            this.log.Name = "log";
            this.log.Size = new System.Drawing.Size(539, 194);
            this.log.TabIndex = 42;
            this.log.Text = "";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // save_csv
            // 
            this.save_csv.Enabled = false;
            this.save_csv.Location = new System.Drawing.Point(51, 721);
            this.save_csv.Name = "save_csv";
            this.save_csv.Size = new System.Drawing.Size(108, 39);
            this.save_csv.TabIndex = 46;
            this.save_csv.Text = "CSV KAYDET";
            this.save_csv.UseVisualStyleBackColor = true;
            this.save_csv.Click += new System.EventHandler(this.save_csv_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(1064, 89);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(158, 25);
            this.label10.TabIndex = 47;
            this.label10.Text = "Reflektör Sayısı: ";
            // 
            // count
            // 
            this.count.AutoSize = true;
            this.count.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.count.Location = new System.Drawing.Point(1222, 89);
            this.count.Name = "count";
            this.count.Size = new System.Drawing.Size(23, 25);
            this.count.TabIndex = 48;
            this.count.Text = "0";
            // 
            // nav_test
            // 
            this.nav_test.Enabled = false;
            this.nav_test.Location = new System.Drawing.Point(51, 682);
            this.nav_test.Name = "nav_test";
            this.nav_test.Size = new System.Drawing.Size(108, 36);
            this.nav_test.TabIndex = 49;
            this.nav_test.Text = "TEST";
            this.nav_test.UseVisualStyleBackColor = true;
            this.nav_test.Click += new System.EventHandler(this.nav_test_Click);
            // 
            // test_text
            // 
            this.test_text.AutoSize = true;
            this.test_text.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.test_text.ForeColor = System.Drawing.Color.Red;
            this.test_text.Location = new System.Drawing.Point(323, 758);
            this.test_text.Name = "test_text";
            this.test_text.Size = new System.Drawing.Size(55, 25);
            this.test_text.TabIndex = 50;
            this.test_text.Text = "TEST";
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.button3);
            this.panel6.Controls.Add(this.button4);
            this.panel6.Controls.Add(this.label20);
            this.panel6.Location = new System.Drawing.Point(51, 552);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(231, 100);
            this.panel6.TabIndex = 34;
            // 
            // button3
            // 
            this.button3.Enabled = false;
            this.button3.Location = new System.Drawing.Point(128, 42);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(92, 33);
            this.button3.TabIndex = 29;
            this.button3.Text = "GERİ";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Enabled = false;
            this.button4.Location = new System.Drawing.Point(11, 42);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(92, 33);
            this.button4.TabIndex = 29;
            this.button4.Text = "İLERİ";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(100, 9);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(27, 15);
            this.label20.TabIndex = 29;
            this.label20.Text = "Yön";
            this.label20.Click += new System.EventHandler(this.label20_Click);
            // 
            // kumanda
            // 
            this.kumanda.Enabled = false;
            this.kumanda.Location = new System.Drawing.Point(51, 766);
            this.kumanda.Name = "kumanda";
            this.kumanda.Size = new System.Drawing.Size(108, 36);
            this.kumanda.TabIndex = 51;
            this.kumanda.Text = "KUMANDA";
            this.kumanda.UseVisualStyleBackColor = true;
            this.kumanda.Click += new System.EventHandler(this.kumanda_Click);
            // 
            // Kapsul_Hyperloop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1359, 846);
            this.Controls.Add(this.kumanda);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.test_text);
            this.Controls.Add(this.nav_test);
            this.Controls.Add(this.count);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.save_csv);
            this.Controls.Add(this.log);
            this.Controls.Add(this.phase);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.pow);
            this.Controls.Add(this.temp2);
            this.Controls.Add(this.temp1);
            this.Controls.Add(this.max_hız);
            this.Controls.Add(this.connect);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.emergency);
            this.Controls.Add(this.stop);
            this.Controls.Add(this.start);
            this.Controls.Add(this.fren_save);
            this.Controls.Add(this.frenNoktasi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.login);
            this.Controls.Add(this.password);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.username);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.serverIp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ping);
            this.Controls.Add(this.progress_bar_value);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.panel1);
            this.Name = "Kapsul_Hyperloop";
            this.Text = "Kapsül Hyperloop";
            this.Load += new System.EventHandler(this.Kapsul_Hyperloop_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ProgressBar progressBar1;
        private Label progress_bar_value;
        private Label ping;
        private Label label1;
        private TextBox serverIp;
        private Label label2;
        private TextBox username;
        private Label label3;
        private TextBox password;
        private Button login;
        private Label label4;
        private TextBox frenNoktasi;
        private Button fren_save;
        private Button start;
        private Button stop;
        private Button emergency;
        private Label label5;
        private Button lev_start;
        private Button lev_stop;
        private Button motor_stop;
        private Button motor_go;
        private Label label7;
        private Button brake_close;
        private Label label8;
        private Panel panel1;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Label label9;
        private Button connect;
        private Label max_hız;
        private Label temp1;
        private Label temp2;
        private Label pow;
        private TableLayoutPanel tableLayoutPanel1;
        private Label velo_z;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label pos_x;
        private Label pos_y;
        private Label pos_z;
        private Label velo_x;
        private Label velo_y;
        private Label acc_x;
        private Label acc_y;
        private Label acc_z;
        private TableLayoutPanel tableLayoutPanel2;
        private Label roll;
        private Label yaw;
        private Label pitch;
        private Label label17;
        private Label label18;
        private Label label19;
        private Label phase;
        private RichTextBox log;
        private System.Windows.Forms.Timer timer1;
        private Button save_csv;
        private Button brake_open;
        private Button button2;
        private Button button1;
        private Label label10;
        private Label count;
        private Button nav_test;
        private Label test_text;
        private Panel panel6;
        private Button button3;
        private Button button4;
        private Label label20;
        private Button button5;
        private Button kumanda;
        private Button fren_hareketsiz;
    }
}
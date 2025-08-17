namespace colorMod
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.connectBtn = new System.Windows.Forms.Button();
            this.portC = new System.Windows.Forms.ComboBox();
            this.stopC = new System.Windows.Forms.ComboBox();
            this.dataC = new System.Windows.Forms.ComboBox();
            this.baudC = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.parity = new System.Windows.Forms.Label();
            this.parityC = new System.Windows.Forms.ComboBox();
            this.stopbit = new System.Windows.Forms.Label();
            this.databit = new System.Windows.Forms.Label();
            this.baudrate = new System.Windows.Forms.Label();
            this.port = new System.Windows.Forms.Label();
            this.arduino = new System.IO.Ports.SerialPort(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.whiteTB = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TBwhite = new System.Windows.Forms.TrackBar();
            this.blueTB = new System.Windows.Forms.TextBox();
            this.greenTB = new System.Windows.Forms.TextBox();
            this.redTB = new System.Windows.Forms.TextBox();
            this.blue = new System.Windows.Forms.Label();
            this.green = new System.Windows.Forms.Label();
            this.red = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TBblue = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.TBgreen = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.TBred = new System.Windows.Forms.TrackBar();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button10 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.livel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TBwhite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBblue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBgreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBred)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // connectBtn
            // 
            this.connectBtn.Font = new System.Drawing.Font("Segoe UI Variable Display", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connectBtn.Location = new System.Drawing.Point(66, 260);
            this.connectBtn.Name = "connectBtn";
            this.connectBtn.Size = new System.Drawing.Size(137, 33);
            this.connectBtn.TabIndex = 0;
            this.connectBtn.Text = "CONNECT";
            this.connectBtn.UseVisualStyleBackColor = true;
            this.connectBtn.Click += new System.EventHandler(this.connectBtn_Click);
            // 
            // portC
            // 
            this.portC.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.portC.FormattingEnabled = true;
            this.portC.Location = new System.Drawing.Point(142, 42);
            this.portC.Name = "portC";
            this.portC.Size = new System.Drawing.Size(121, 28);
            this.portC.TabIndex = 1;
            this.portC.MouseClick += new System.Windows.Forms.MouseEventHandler(this.portC_MouseClick);
            // 
            // stopC
            // 
            this.stopC.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stopC.FormattingEnabled = true;
            this.stopC.Items.AddRange(new object[] {
            "Use Default",
            "One",
            "Two"});
            this.stopC.Location = new System.Drawing.Point(142, 132);
            this.stopC.Name = "stopC";
            this.stopC.Size = new System.Drawing.Size(121, 28);
            this.stopC.TabIndex = 2;
            // 
            // dataC
            // 
            this.dataC.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataC.FormattingEnabled = true;
            this.dataC.Items.AddRange(new object[] {
            "Use Default",
            "6",
            "7",
            "8"});
            this.dataC.Location = new System.Drawing.Point(142, 102);
            this.dataC.Name = "dataC";
            this.dataC.Size = new System.Drawing.Size(121, 28);
            this.dataC.TabIndex = 3;
            // 
            // baudC
            // 
            this.baudC.DisplayMember = "4800";
            this.baudC.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.baudC.FormattingEnabled = true;
            this.baudC.Items.AddRange(new object[] {
            "4800",
            "9600",
            "19200",
            "38400",
            "57600",
            "74880",
            "115200",
            "230400",
            "250000"});
            this.baudC.Location = new System.Drawing.Point(142, 72);
            this.baudC.Name = "baudC";
            this.baudC.Size = new System.Drawing.Size(121, 28);
            this.baudC.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.parity);
            this.groupBox1.Controls.Add(this.connectBtn);
            this.groupBox1.Controls.Add(this.parityC);
            this.groupBox1.Controls.Add(this.stopbit);
            this.groupBox1.Controls.Add(this.databit);
            this.groupBox1.Controls.Add(this.baudrate);
            this.groupBox1.Controls.Add(this.port);
            this.groupBox1.Controls.Add(this.portC);
            this.groupBox1.Controls.Add(this.baudC);
            this.groupBox1.Controls.Add(this.stopC);
            this.groupBox1.Controls.Add(this.dataC);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(273, 312);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SET PARAMETERS";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(21, 226);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(216, 17);
            this.label11.TabIndex = 18;
            this.label11.Text = " unless you know what you\'re doing";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(21, 208);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(223, 17);
            this.label10.TabIndex = 17;
            this.label10.Text = "Don\'t change the default parameters";
            // 
            // parity
            // 
            this.parity.AutoSize = true;
            this.parity.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parity.Location = new System.Drawing.Point(6, 165);
            this.parity.Name = "parity";
            this.parity.Size = new System.Drawing.Size(79, 20);
            this.parity.TabIndex = 11;
            this.parity.Text = "Parity Bits";
            // 
            // parityC
            // 
            this.parityC.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parityC.FormattingEnabled = true;
            this.parityC.Items.AddRange(new object[] {
            "Use Default",
            "Odd",
            "Even"});
            this.parityC.Location = new System.Drawing.Point(142, 162);
            this.parityC.Name = "parityC";
            this.parityC.Size = new System.Drawing.Size(121, 28);
            this.parityC.TabIndex = 10;
            // 
            // stopbit
            // 
            this.stopbit.AutoSize = true;
            this.stopbit.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stopbit.Location = new System.Drawing.Point(6, 135);
            this.stopbit.Name = "stopbit";
            this.stopbit.Size = new System.Drawing.Size(72, 20);
            this.stopbit.TabIndex = 9;
            this.stopbit.Text = "Stop Bits";
            // 
            // databit
            // 
            this.databit.AutoSize = true;
            this.databit.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.databit.Location = new System.Drawing.Point(6, 105);
            this.databit.Name = "databit";
            this.databit.Size = new System.Drawing.Size(72, 20);
            this.databit.TabIndex = 8;
            this.databit.Text = "Data Bits";
            // 
            // baudrate
            // 
            this.baudrate.AutoSize = true;
            this.baudrate.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.baudrate.Location = new System.Drawing.Point(6, 75);
            this.baudrate.Name = "baudrate";
            this.baudrate.Size = new System.Drawing.Size(79, 20);
            this.baudrate.TabIndex = 7;
            this.baudrate.Text = "Baud Rate";
            // 
            // port
            // 
            this.port.AutoSize = true;
            this.port.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.port.Location = new System.Drawing.Point(6, 45);
            this.port.Name = "port";
            this.port.Size = new System.Drawing.Size(38, 20);
            this.port.TabIndex = 6;
            this.port.Text = "Port";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI Variable Small Semibol", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(12, 323);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textBox1.Size = new System.Drawing.Size(269, 111);
            this.textBox1.TabIndex = 6;
            this.textBox1.Text = "Select the port to which your arduino is connected and click CONNECT. Make sure t" +
    "hat the colorMod sketch is uploaded to it. Otherwise, your arduino will not comm" +
    "unicate with this application.";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(12, 436);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(269, 10);
            this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar.TabIndex = 7;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.whiteTB);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.TBwhite);
            this.groupBox2.Controls.Add(this.blueTB);
            this.groupBox2.Controls.Add(this.greenTB);
            this.groupBox2.Controls.Add(this.redTB);
            this.groupBox2.Controls.Add(this.blue);
            this.groupBox2.Controls.Add(this.green);
            this.groupBox2.Controls.Add(this.red);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.TBblue);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.TBgreen);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.TBred);
            this.groupBox2.Enabled = false;
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(306, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(594, 357);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "CONTROL";
            // 
            // whiteTB
            // 
            this.whiteTB.BackColor = System.Drawing.Color.White;
            this.whiteTB.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.whiteTB.Location = new System.Drawing.Point(499, 300);
            this.whiteTB.Name = "whiteTB";
            this.whiteTB.Size = new System.Drawing.Size(66, 27);
            this.whiteTB.TabIndex = 24;
            this.whiteTB.Text = "0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(440, 303);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 20);
            this.label12.TabIndex = 23;
            this.label12.Text = "White:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 20);
            this.label4.TabIndex = 22;
            this.label4.Text = "WHITE";
            // 
            // TBwhite
            // 
            this.TBwhite.Location = new System.Drawing.Point(94, 231);
            this.TBwhite.Maximum = 255;
            this.TBwhite.Name = "TBwhite";
            this.TBwhite.Size = new System.Drawing.Size(482, 56);
            this.TBwhite.TabIndex = 21;
            this.TBwhite.Scroll += new System.EventHandler(this.TBwhite_Scroll);
            // 
            // blueTB
            // 
            this.blueTB.BackColor = System.Drawing.Color.White;
            this.blueTB.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blueTB.Location = new System.Drawing.Point(352, 299);
            this.blueTB.Name = "blueTB";
            this.blueTB.Size = new System.Drawing.Size(66, 27);
            this.blueTB.TabIndex = 20;
            this.blueTB.Text = "0";
            // 
            // greenTB
            // 
            this.greenTB.BackColor = System.Drawing.Color.White;
            this.greenTB.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.greenTB.Location = new System.Drawing.Point(215, 299);
            this.greenTB.Name = "greenTB";
            this.greenTB.Size = new System.Drawing.Size(66, 27);
            this.greenTB.TabIndex = 19;
            this.greenTB.Text = "0";
            // 
            // redTB
            // 
            this.redTB.BackColor = System.Drawing.Color.White;
            this.redTB.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.redTB.Location = new System.Drawing.Point(69, 299);
            this.redTB.Name = "redTB";
            this.redTB.Size = new System.Drawing.Size(66, 27);
            this.redTB.TabIndex = 18;
            this.redTB.Text = "0";
            this.redTB.TextChanged += new System.EventHandler(this.redTB_TextChanged);
            // 
            // blue
            // 
            this.blue.AutoSize = true;
            this.blue.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blue.Location = new System.Drawing.Point(304, 302);
            this.blue.Name = "blue";
            this.blue.Size = new System.Drawing.Size(42, 20);
            this.blue.TabIndex = 17;
            this.blue.Text = "Blue:";
            // 
            // green
            // 
            this.green.AutoSize = true;
            this.green.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.green.Location = new System.Drawing.Point(155, 302);
            this.green.Name = "green";
            this.green.Size = new System.Drawing.Size(54, 20);
            this.green.TabIndex = 16;
            this.green.Text = "Green:";
            // 
            // red
            // 
            this.red.AutoSize = true;
            this.red.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.red.Location = new System.Drawing.Point(25, 302);
            this.red.Name = "red";
            this.red.Size = new System.Drawing.Size(38, 20);
            this.red.TabIndex = 15;
            this.red.Text = "Red:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "BLUE";
            // 
            // TBblue
            // 
            this.TBblue.Location = new System.Drawing.Point(94, 163);
            this.TBblue.Maximum = 255;
            this.TBblue.Name = "TBblue";
            this.TBblue.Size = new System.Drawing.Size(482, 56);
            this.TBblue.TabIndex = 13;
            this.TBblue.Scroll += new System.EventHandler(this.TBblue_Scroll);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "GREEN";
            // 
            // TBgreen
            // 
            this.TBgreen.Location = new System.Drawing.Point(94, 95);
            this.TBgreen.Maximum = 255;
            this.TBgreen.Name = "TBgreen";
            this.TBgreen.Size = new System.Drawing.Size(482, 56);
            this.TBgreen.TabIndex = 11;
            this.TBgreen.Scroll += new System.EventHandler(this.TBgreen_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "RED";
            // 
            // TBred
            // 
            this.TBred.Location = new System.Drawing.Point(94, 33);
            this.TBred.Maximum = 255;
            this.TBred.Name = "TBred";
            this.TBred.Size = new System.Drawing.Size(482, 56);
            this.TBred.TabIndex = 9;
            this.TBred.Scroll += new System.EventHandler(this.TBred_Scroll);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.button10);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.trackBar1);
            this.groupBox4.Enabled = false;
            this.groupBox4.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(306, 5);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(594, 365);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "CONTROL";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(248, 147);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(17, 20);
            this.label9.TabIndex = 31;
            this.label9.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(13, 199);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(431, 20);
            this.label7.TabIndex = 30;
            this.label7.Text = "NOTE : Higher delay values might result in less smooth fades.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(382, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 20);
            this.label6.TabIndex = 29;
            this.label6.Text = "520ms";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(91, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 20);
            this.label5.TabIndex = 28;
            this.label5.Text = "10ms";
            // 
            // button10
            // 
            this.button10.Font = new System.Drawing.Font("Segoe UI Variable Display", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.Location = new System.Drawing.Point(138, 240);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(190, 47);
            this.button10.TabIndex = 27;
            this.button10.Text = "START";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 111);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "DELAY";
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(87, 102);
            this.trackBar1.Maximum = 255;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(357, 56);
            this.trackBar1.TabIndex = 13;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI Variable Display", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(429, 376);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 69);
            this.button1.TabIndex = 9;
            this.button1.Text = "TURN OFF ALL COLORS";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.White;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Segoe UI Variable Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.Gray;
            this.textBox2.Location = new System.Drawing.Point(558, 395);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(342, 27);
            this.textBox2.TabIndex = 11;
            // 
            // livel
            // 
            this.livel.Font = new System.Drawing.Font("Segoe UI Variable Display", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.livel.Location = new System.Drawing.Point(306, 376);
            this.livel.Name = "livel";
            this.livel.Size = new System.Drawing.Size(114, 70);
            this.livel.TabIndex = 11;
            this.livel.Text = "DYNAMIC LIGHTING";
            this.livel.UseVisualStyleBackColor = true;
            this.livel.Click += new System.EventHandler(this.livel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(912, 458);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.livel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox4);
            this.Font = new System.Drawing.Font("Segoe UI Variable Display", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "COLORMOD";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TBwhite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBblue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBgreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBred)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button connectBtn;
        private System.Windows.Forms.ComboBox portC;
        private System.Windows.Forms.ComboBox stopC;
        private System.Windows.Forms.ComboBox dataC;
        private System.Windows.Forms.ComboBox baudC;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label parity;
        private System.Windows.Forms.ComboBox parityC;
        private System.Windows.Forms.Label stopbit;
        private System.Windows.Forms.Label databit;
        private System.Windows.Forms.Label baudrate;
        private System.Windows.Forms.Label port;
        private System.IO.Ports.SerialPort arduino;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar TBred;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar TBblue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar TBgreen;
        private System.Windows.Forms.TextBox blueTB;
        private System.Windows.Forms.TextBox greenTB;
        private System.Windows.Forms.TextBox redTB;
        private System.Windows.Forms.Label blue;
        private System.Windows.Forms.Label green;
        private System.Windows.Forms.Label red;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button livel;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar TBwhite;
        private System.Windows.Forms.TextBox whiteTB;
        private System.Windows.Forms.Label label12;
    }
}


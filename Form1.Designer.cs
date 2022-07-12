namespace OPCUAReadData
{
    partial class Form1
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
            this.lbStatusMsg = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTimeStamp = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtM2Position = new System.Windows.Forms.TextBox();
            this.txtM2Mode = new System.Windows.Forms.TextBox();
            this.txtM2Name = new System.Windows.Forms.TextBox();
            this.lbM2Status = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtM2Temp = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtM1Position = new System.Windows.Forms.TextBox();
            this.txtM1Mode = new System.Windows.Forms.TextBox();
            this.txtM1Name = new System.Windows.Forms.TextBox();
            this.lbM1Status = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtM1Temp = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.txtS2Value = new System.Windows.Forms.TextBox();
            this.label32 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.lbS2Status = new System.Windows.Forms.Label();
            this.txtS2Name = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.txtS1Value = new System.Windows.Forms.TextBox();
            this.label31 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.lbS1Status = new System.Windows.Forms.Label();
            this.txtS1Name = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.label23 = new System.Windows.Forms.Label();
            this.txtRB2Position = new System.Windows.Forms.TextBox();
            this.txtRB2Mode = new System.Windows.Forms.TextBox();
            this.lbRB2Status = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.txtRB2Temp = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.txtRB2Name = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtRB1Position = new System.Windows.Forms.TextBox();
            this.txtRB1Mode = new System.Windows.Forms.TextBox();
            this.lbRB1Status = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.txtRB1Temp = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.txtRB1Name = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtServerAddr = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.UpdateTimer = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbStatusMsg
            // 
            this.lbStatusMsg.AutoSize = true;
            this.lbStatusMsg.Location = new System.Drawing.Point(190, 17);
            this.lbStatusMsg.Name = "lbStatusMsg";
            this.lbStatusMsg.Size = new System.Drawing.Size(190, 20);
            this.lbStatusMsg.TabIndex = 0;
            this.lbStatusMsg.Text = "Connection Status Message";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(575, 22);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(94, 29);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(575, 79);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(94, 29);
            this.btnStop.TabIndex = 1;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "TimeStamp";
            // 
            // txtTimeStamp
            // 
            this.txtTimeStamp.Location = new System.Drawing.Point(136, 64);
            this.txtTimeStamp.Name = "txtTimeStamp";
            this.txtTimeStamp.Size = new System.Drawing.Size(339, 27);
            this.txtTimeStamp.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Location = new System.Drawing.Point(13, 131);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(478, 466);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Motor Data";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.txtM2Position);
            this.groupBox5.Controls.Add(this.txtM2Mode);
            this.groupBox5.Controls.Add(this.txtM2Name);
            this.groupBox5.Controls.Add(this.lbM2Status);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Controls.Add(this.label13);
            this.groupBox5.Controls.Add(this.txtM2Temp);
            this.groupBox5.Controls.Add(this.label14);
            this.groupBox5.Location = new System.Drawing.Point(239, 48);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(227, 407);
            this.groupBox5.TabIndex = 18;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Motor 2";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 251);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(120, 20);
            this.label9.TabIndex = 26;
            this.label9.Text = "Operating Status";
            // 
            // txtM2Position
            // 
            this.txtM2Position.Location = new System.Drawing.Point(104, 129);
            this.txtM2Position.Name = "txtM2Position";
            this.txtM2Position.Size = new System.Drawing.Size(100, 27);
            this.txtM2Position.TabIndex = 23;
            // 
            // txtM2Mode
            // 
            this.txtM2Mode.Location = new System.Drawing.Point(104, 182);
            this.txtM2Mode.Name = "txtM2Mode";
            this.txtM2Mode.Size = new System.Drawing.Size(100, 27);
            this.txtM2Mode.TabIndex = 24;
            // 
            // txtM2Name
            // 
            this.txtM2Name.Location = new System.Drawing.Point(93, 69);
            this.txtM2Name.Name = "txtM2Name";
            this.txtM2Name.Size = new System.Drawing.Size(125, 27);
            this.txtM2Name.TabIndex = 25;
            // 
            // lbM2Status
            // 
            this.lbM2Status.AutoSize = true;
            this.lbM2Status.Location = new System.Drawing.Point(144, 251);
            this.lbM2Status.Name = "lbM2Status";
            this.lbM2Status.Size = new System.Drawing.Size(60, 20);
            this.lbM2Status.TabIndex = 19;
            this.lbM2Status.Text = "IsActive";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(25, 129);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 20);
            this.label11.TabIndex = 20;
            this.label11.Text = "Position";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(25, 182);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(48, 20);
            this.label12.TabIndex = 21;
            this.label12.Text = "Mode";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(25, 69);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(49, 20);
            this.label13.TabIndex = 22;
            this.label13.Text = "Name";
            // 
            // txtM2Temp
            // 
            this.txtM2Temp.Location = new System.Drawing.Point(114, 310);
            this.txtM2Temp.Name = "txtM2Temp";
            this.txtM2Temp.Size = new System.Drawing.Size(90, 27);
            this.txtM2Temp.TabIndex = 18;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(15, 313);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(93, 20);
            this.label14.TabIndex = 17;
            this.label14.Text = "Temperature";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.txtM1Position);
            this.groupBox4.Controls.Add(this.txtM1Mode);
            this.groupBox4.Controls.Add(this.txtM1Name);
            this.groupBox4.Controls.Add(this.lbM1Status);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.txtM1Temp);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Location = new System.Drawing.Point(6, 48);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(227, 407);
            this.groupBox4.TabIndex = 17;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Motor 1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 251);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 20);
            this.label5.TabIndex = 26;
            this.label5.Text = "Operating Status";
            // 
            // txtM1Position
            // 
            this.txtM1Position.Location = new System.Drawing.Point(104, 129);
            this.txtM1Position.Name = "txtM1Position";
            this.txtM1Position.Size = new System.Drawing.Size(100, 27);
            this.txtM1Position.TabIndex = 23;
            // 
            // txtM1Mode
            // 
            this.txtM1Mode.Location = new System.Drawing.Point(104, 182);
            this.txtM1Mode.Name = "txtM1Mode";
            this.txtM1Mode.Size = new System.Drawing.Size(100, 27);
            this.txtM1Mode.TabIndex = 24;
            // 
            // txtM1Name
            // 
            this.txtM1Name.Location = new System.Drawing.Point(93, 69);
            this.txtM1Name.Name = "txtM1Name";
            this.txtM1Name.Size = new System.Drawing.Size(125, 27);
            this.txtM1Name.TabIndex = 25;
            // 
            // lbM1Status
            // 
            this.lbM1Status.AutoSize = true;
            this.lbM1Status.Location = new System.Drawing.Point(144, 251);
            this.lbM1Status.Name = "lbM1Status";
            this.lbM1Status.Size = new System.Drawing.Size(60, 20);
            this.lbM1Status.TabIndex = 19;
            this.lbM1Status.Text = "IsActive";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 20);
            this.label4.TabIndex = 20;
            this.label4.Text = "Position";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 182);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 20);
            this.label6.TabIndex = 21;
            this.label6.Text = "Mode";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 69);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 20);
            this.label7.TabIndex = 22;
            this.label7.Text = "Name";
            // 
            // txtM1Temp
            // 
            this.txtM1Temp.Location = new System.Drawing.Point(114, 310);
            this.txtM1Temp.Name = "txtM1Temp";
            this.txtM1Temp.Size = new System.Drawing.Size(90, 27);
            this.txtM1Temp.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 313);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 20);
            this.label8.TabIndex = 17;
            this.label8.Text = "Temperature";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox7);
            this.groupBox2.Controls.Add(this.groupBox6);
            this.groupBox2.Location = new System.Drawing.Point(497, 131);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(484, 466);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sensor Data ";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.txtS2Value);
            this.groupBox7.Controls.Add(this.label32);
            this.groupBox7.Controls.Add(this.label33);
            this.groupBox7.Controls.Add(this.lbS2Status);
            this.groupBox7.Controls.Add(this.txtS2Name);
            this.groupBox7.Controls.Add(this.label16);
            this.groupBox7.Location = new System.Drawing.Point(240, 48);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(238, 407);
            this.groupBox7.TabIndex = 1;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Sensor 2";
            // 
            // txtS2Value
            // 
            this.txtS2Value.Location = new System.Drawing.Point(136, 214);
            this.txtS2Value.Name = "txtS2Value";
            this.txtS2Value.Size = new System.Drawing.Size(97, 27);
            this.txtS2Value.TabIndex = 36;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(2, 217);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(131, 20);
            this.label32.TabIndex = 35;
            this.label32.Text = "Measurment Value";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(0, 146);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(120, 20);
            this.label33.TabIndex = 34;
            this.label33.Text = "Operating Status";
            // 
            // lbS2Status
            // 
            this.lbS2Status.AutoSize = true;
            this.lbS2Status.Location = new System.Drawing.Point(135, 146);
            this.lbS2Status.Name = "lbS2Status";
            this.lbS2Status.Size = new System.Drawing.Size(60, 20);
            this.lbS2Status.TabIndex = 33;
            this.lbS2Status.Text = "IsActive";
            // 
            // txtS2Name
            // 
            this.txtS2Name.Location = new System.Drawing.Point(81, 69);
            this.txtS2Name.Name = "txtS2Name";
            this.txtS2Name.Size = new System.Drawing.Size(125, 27);
            this.txtS2Name.TabIndex = 30;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(13, 69);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(49, 20);
            this.label16.TabIndex = 29;
            this.label16.Text = "Name";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.txtS1Value);
            this.groupBox6.Controls.Add(this.label31);
            this.groupBox6.Controls.Add(this.label29);
            this.groupBox6.Controls.Add(this.lbS1Status);
            this.groupBox6.Controls.Add(this.txtS1Name);
            this.groupBox6.Controls.Add(this.label15);
            this.groupBox6.Location = new System.Drawing.Point(6, 48);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(228, 407);
            this.groupBox6.TabIndex = 0;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Sensor 1";
            // 
            // txtS1Value
            // 
            this.txtS1Value.Location = new System.Drawing.Point(134, 214);
            this.txtS1Value.Name = "txtS1Value";
            this.txtS1Value.Size = new System.Drawing.Size(94, 27);
            this.txtS1Value.TabIndex = 32;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(6, 217);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(131, 20);
            this.label31.TabIndex = 31;
            this.label31.Text = "Measurment Value";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(4, 146);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(120, 20);
            this.label29.TabIndex = 30;
            this.label29.Text = "Operating Status";
            // 
            // lbS1Status
            // 
            this.lbS1Status.AutoSize = true;
            this.lbS1Status.Location = new System.Drawing.Point(139, 146);
            this.lbS1Status.Name = "lbS1Status";
            this.lbS1Status.Size = new System.Drawing.Size(60, 20);
            this.lbS1Status.TabIndex = 29;
            this.lbS1Status.Text = "IsActive";
            // 
            // txtS1Name
            // 
            this.txtS1Name.Location = new System.Drawing.Point(74, 69);
            this.txtS1Name.Name = "txtS1Name";
            this.txtS1Name.Size = new System.Drawing.Size(125, 27);
            this.txtS1Name.TabIndex = 28;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 69);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(49, 20);
            this.label15.TabIndex = 27;
            this.label15.Text = "Name";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox9);
            this.groupBox3.Controls.Add(this.groupBox8);
            this.groupBox3.Location = new System.Drawing.Point(987, 131);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(476, 466);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Robot Data";
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.label23);
            this.groupBox9.Controls.Add(this.txtRB2Position);
            this.groupBox9.Controls.Add(this.txtRB2Mode);
            this.groupBox9.Controls.Add(this.lbRB2Status);
            this.groupBox9.Controls.Add(this.label25);
            this.groupBox9.Controls.Add(this.label26);
            this.groupBox9.Controls.Add(this.txtRB2Temp);
            this.groupBox9.Controls.Add(this.label27);
            this.groupBox9.Controls.Add(this.txtRB2Name);
            this.groupBox9.Controls.Add(this.label28);
            this.groupBox9.Location = new System.Drawing.Point(250, 48);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(219, 407);
            this.groupBox9.TabIndex = 1;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Robot 2";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(12, 256);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(120, 20);
            this.label23.TabIndex = 45;
            this.label23.Text = "Operating Status";
            // 
            // txtRB2Position
            // 
            this.txtRB2Position.Location = new System.Drawing.Point(107, 134);
            this.txtRB2Position.Name = "txtRB2Position";
            this.txtRB2Position.Size = new System.Drawing.Size(100, 27);
            this.txtRB2Position.TabIndex = 43;
            // 
            // txtRB2Mode
            // 
            this.txtRB2Mode.Location = new System.Drawing.Point(107, 187);
            this.txtRB2Mode.Name = "txtRB2Mode";
            this.txtRB2Mode.Size = new System.Drawing.Size(100, 27);
            this.txtRB2Mode.TabIndex = 44;
            // 
            // lbRB2Status
            // 
            this.lbRB2Status.AutoSize = true;
            this.lbRB2Status.Location = new System.Drawing.Point(147, 256);
            this.lbRB2Status.Name = "lbRB2Status";
            this.lbRB2Status.Size = new System.Drawing.Size(60, 20);
            this.lbRB2Status.TabIndex = 40;
            this.lbRB2Status.Text = "IsActive";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(14, 134);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(61, 20);
            this.label25.TabIndex = 41;
            this.label25.Text = "Position";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(14, 187);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(48, 20);
            this.label26.TabIndex = 42;
            this.label26.Text = "Mode";
            // 
            // txtRB2Temp
            // 
            this.txtRB2Temp.Location = new System.Drawing.Point(117, 315);
            this.txtRB2Temp.Name = "txtRB2Temp";
            this.txtRB2Temp.Size = new System.Drawing.Size(90, 27);
            this.txtRB2Temp.TabIndex = 39;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(14, 318);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(93, 20);
            this.label27.TabIndex = 38;
            this.label27.Text = "Temperature";
            // 
            // txtRB2Name
            // 
            this.txtRB2Name.Location = new System.Drawing.Point(82, 64);
            this.txtRB2Name.Name = "txtRB2Name";
            this.txtRB2Name.Size = new System.Drawing.Size(125, 27);
            this.txtRB2Name.TabIndex = 37;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(14, 64);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(49, 20);
            this.label28.TabIndex = 36;
            this.label28.Text = "Name";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.label18);
            this.groupBox8.Controls.Add(this.txtRB1Position);
            this.groupBox8.Controls.Add(this.txtRB1Mode);
            this.groupBox8.Controls.Add(this.lbRB1Status);
            this.groupBox8.Controls.Add(this.label20);
            this.groupBox8.Controls.Add(this.label21);
            this.groupBox8.Controls.Add(this.txtRB1Temp);
            this.groupBox8.Controls.Add(this.label22);
            this.groupBox8.Controls.Add(this.txtRB1Name);
            this.groupBox8.Controls.Add(this.label17);
            this.groupBox8.Location = new System.Drawing.Point(25, 48);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(219, 407);
            this.groupBox8.TabIndex = 1;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Robot 1";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(7, 261);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(120, 20);
            this.label18.TabIndex = 35;
            this.label18.Text = "Operating Status";
            // 
            // txtRB1Position
            // 
            this.txtRB1Position.Location = new System.Drawing.Point(102, 139);
            this.txtRB1Position.Name = "txtRB1Position";
            this.txtRB1Position.Size = new System.Drawing.Size(100, 27);
            this.txtRB1Position.TabIndex = 33;
            // 
            // txtRB1Mode
            // 
            this.txtRB1Mode.Location = new System.Drawing.Point(102, 192);
            this.txtRB1Mode.Name = "txtRB1Mode";
            this.txtRB1Mode.Size = new System.Drawing.Size(100, 27);
            this.txtRB1Mode.TabIndex = 34;
            // 
            // lbRB1Status
            // 
            this.lbRB1Status.AutoSize = true;
            this.lbRB1Status.Location = new System.Drawing.Point(142, 261);
            this.lbRB1Status.Name = "lbRB1Status";
            this.lbRB1Status.Size = new System.Drawing.Size(60, 20);
            this.lbRB1Status.TabIndex = 30;
            this.lbRB1Status.Text = "IsActive";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(9, 139);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(61, 20);
            this.label20.TabIndex = 31;
            this.label20.Text = "Position";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(9, 192);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(48, 20);
            this.label21.TabIndex = 32;
            this.label21.Text = "Mode";
            // 
            // txtRB1Temp
            // 
            this.txtRB1Temp.Location = new System.Drawing.Point(112, 320);
            this.txtRB1Temp.Name = "txtRB1Temp";
            this.txtRB1Temp.Size = new System.Drawing.Size(90, 27);
            this.txtRB1Temp.TabIndex = 29;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(9, 323);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(93, 20);
            this.label22.TabIndex = 28;
            this.label22.Text = "Temperature";
            // 
            // txtRB1Name
            // 
            this.txtRB1Name.Location = new System.Drawing.Point(77, 69);
            this.txtRB1Name.Name = "txtRB1Name";
            this.txtRB1Name.Size = new System.Drawing.Size(125, 27);
            this.txtRB1Name.TabIndex = 27;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(9, 69);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(49, 20);
            this.label17.TabIndex = 26;
            this.label17.Text = "Name";
            // 
            // txtServerAddr
            // 
            this.txtServerAddr.Location = new System.Drawing.Point(987, 44);
            this.txtServerAddr.Name = "txtServerAddr";
            this.txtServerAddr.Size = new System.Drawing.Size(462, 27);
            this.txtServerAddr.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(848, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Server Address";
            // 
            // UpdateTimer
            // 
            this.UpdateTimer.Tick += new System.EventHandler(this.UpdateTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1472, 602);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtServerAddr);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtTimeStamp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lbStatusMsg);
            this.Name = "Form1";
            this.Text = "OPC UA Read Client";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbStatusMsg;
        private Button btnStart;
        private Button btnStop;
        private Label label2;
        private TextBox txtTimeStamp;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private TextBox txtServerAddr;
        private Label label3;
        private GroupBox groupBox5;
        private Label label9;
        private TextBox txtM2Position;
        private TextBox txtM2Mode;
        private TextBox txtM2Name;
        private Label lbM2Status;
        private Label label11;
        private Label label12;
        private Label label13;
        private TextBox txtM2Temp;
        private Label label14;
        private GroupBox groupBox4;
        private Label label5;
        private TextBox txtM1Position;
        private TextBox txtM1Mode;
        private TextBox txtM1Name;
        private Label lbM1Status;
        private Label label4;
        private Label label6;
        private Label label7;
        private TextBox txtM1Temp;
        private Label label8;
        private GroupBox groupBox6;
        private GroupBox groupBox7;
        private TextBox txtS2Value;
        private Label label32;
        private Label label33;
        private Label lbS2Status;
        private TextBox txtS2Name;
        private Label label16;
        private TextBox txtS1Value;
        private Label label31;
        private Label label29;
        private Label lbS1Status;
        private TextBox txtS1Name;
        private Label label15;
        private GroupBox groupBox9;
        private Label label23;
        private TextBox txtRB2Position;
        private TextBox txtRB2Mode;
        private Label lbRB2Status;
        private Label label25;
        private Label label26;
        private TextBox txtRB2Temp;
        private Label label27;
        private TextBox txtRB2Name;
        private Label label28;
        private GroupBox groupBox8;
        private Label label18;
        private TextBox txtRB1Position;
        private TextBox txtRB1Mode;
        private Label lbRB1Status;
        private Label label20;
        private Label label21;
        private TextBox txtRB1Temp;
        private Label label22;
        private TextBox txtRB1Name;
        private Label label17;
        private System.Windows.Forms.Timer UpdateTimer;
    }
}
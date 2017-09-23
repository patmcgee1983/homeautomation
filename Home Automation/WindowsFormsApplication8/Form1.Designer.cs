namespace WindowsFormsApplication8
{
    partial class Main
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
            this.label1 = new System.Windows.Forms.Label();
            this.serialConn1 = new AdvancedHMIDrivers.SerialDF1forSLCMicroCom(this.components);
            this.commTimer = new System.Windows.Forms.Timer(this.components);
            this.pictureBoxClock0 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.batteryPower1 = new System.Windows.Forms.NumericUpDown();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.switchForce5 = new System.Windows.Forms.PictureBox();
            this.switchForce4 = new System.Windows.Forms.PictureBox();
            this.switchForce3 = new System.Windows.Forms.PictureBox();
            this.switchForce2 = new System.Windows.Forms.PictureBox();
            this.switchForce1 = new System.Windows.Forms.PictureBox();
            this.switchForce0 = new System.Windows.Forms.PictureBox();
            this.onOff5 = new System.Windows.Forms.PictureBox();
            this.onOff4 = new System.Windows.Forms.PictureBox();
            this.onOff3 = new System.Windows.Forms.PictureBox();
            this.onOff2 = new System.Windows.Forms.PictureBox();
            this.onOff1 = new System.Windows.Forms.PictureBox();
            this.onOff0 = new System.Windows.Forms.PictureBox();
            this.textBoxOn0 = new System.Windows.Forms.TextBox();
            this.textBoxOn1 = new System.Windows.Forms.TextBox();
            this.textBoxOn2 = new System.Windows.Forms.TextBox();
            this.textBoxOn3 = new System.Windows.Forms.TextBox();
            this.textBoxOn4 = new System.Windows.Forms.TextBox();
            this.textBoxForce4 = new System.Windows.Forms.TextBox();
            this.textBoxForce3 = new System.Windows.Forms.TextBox();
            this.textBoxForce2 = new System.Windows.Forms.TextBox();
            this.textBoxForce1 = new System.Windows.Forms.TextBox();
            this.textBoxForce0 = new System.Windows.Forms.TextBox();
            this.textBoxForce5 = new System.Windows.Forms.TextBox();
            this.textBoxOn5 = new System.Windows.Forms.TextBox();
            this.textBoxConditionsMet5 = new System.Windows.Forms.TextBox();
            this.textBoxConditionsMet4 = new System.Windows.Forms.TextBox();
            this.textBoxConditionsMet3 = new System.Windows.Forms.TextBox();
            this.textBoxConditionsMet2 = new System.Windows.Forms.TextBox();
            this.textBoxConditionsMet1 = new System.Windows.Forms.TextBox();
            this.textBoxConditionsMet0 = new System.Windows.Forms.TextBox();
            this.imgTimer = new System.Windows.Forms.Timer(this.components);
            this.pictureBoxSchedule0 = new System.Windows.Forms.PictureBox();
            this.textBoxConnectionStatus = new System.Windows.Forms.TextBox();
            this.comboBoxComm = new System.Windows.Forms.ComboBox();
            this.listBoxEvents = new System.Windows.Forms.ListBox();
            this.pictureBoxSchedule1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxClock1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBoxSchedule2 = new System.Windows.Forms.PictureBox();
            this.pictureBoxClock2 = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.numericUpDown6 = new System.Windows.Forms.NumericUpDown();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.grouperDuration2 = new CodeVendor.Controls.Grouper();
            this.numericDurationMinute2 = new System.Windows.Forms.NumericUpDown();
            this.numericDurationHour2 = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.grouperTime2 = new CodeVendor.Controls.Grouper();
            this.numericTimeMinute2 = new System.Windows.Forms.NumericUpDown();
            this.numericTimeHour2 = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.grouperDay2 = new CodeVendor.Controls.Grouper();
            this.checkBoxSu2 = new System.Windows.Forms.CheckBox();
            this.checkBoxS2 = new System.Windows.Forms.CheckBox();
            this.checkBoxF2 = new System.Windows.Forms.CheckBox();
            this.checkBoxR2 = new System.Windows.Forms.CheckBox();
            this.checkBoxW2 = new System.Windows.Forms.CheckBox();
            this.checkBoxT2 = new System.Windows.Forms.CheckBox();
            this.checkBoxM2 = new System.Windows.Forms.CheckBox();
            this.grouperDuration1 = new CodeVendor.Controls.Grouper();
            this.numericDurationMinute1 = new System.Windows.Forms.NumericUpDown();
            this.numericDurationHour1 = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.grouperTime1 = new CodeVendor.Controls.Grouper();
            this.numericTimeMinute1 = new System.Windows.Forms.NumericUpDown();
            this.numericTimeHour1 = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.grouperDay1 = new CodeVendor.Controls.Grouper();
            this.checkBoxSu1 = new System.Windows.Forms.CheckBox();
            this.checkBoxS1 = new System.Windows.Forms.CheckBox();
            this.checkBoxF1 = new System.Windows.Forms.CheckBox();
            this.checkBoxR1 = new System.Windows.Forms.CheckBox();
            this.checkBoxW1 = new System.Windows.Forms.CheckBox();
            this.checkBoxT1 = new System.Windows.Forms.CheckBox();
            this.checkBoxM1 = new System.Windows.Forms.CheckBox();
            this.grouperDuration0 = new CodeVendor.Controls.Grouper();
            this.numericDurationMinute0 = new System.Windows.Forms.NumericUpDown();
            this.numericDurationHour0 = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.grouperTime0 = new CodeVendor.Controls.Grouper();
            this.numericTimeMinute0 = new System.Windows.Forms.NumericUpDown();
            this.numericTimeHour0 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.grouperDay0 = new CodeVendor.Controls.Grouper();
            this.checkBoxSu0 = new System.Windows.Forms.CheckBox();
            this.checkBoxS0 = new System.Windows.Forms.CheckBox();
            this.checkBoxF0 = new System.Windows.Forms.CheckBox();
            this.checkBoxR0 = new System.Windows.Forms.CheckBox();
            this.checkBoxW0 = new System.Windows.Forms.CheckBox();
            this.checkBoxT0 = new System.Windows.Forms.CheckBox();
            this.checkBoxM0 = new System.Windows.Forms.CheckBox();
            this.grouper1 = new CodeVendor.Controls.Grouper();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.grouper2 = new CodeVendor.Controls.Grouper();
            this.numericUpDown4 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown5 = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grouper3 = new CodeVendor.Controls.Grouper();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.numericUpDown7 = new System.Windows.Forms.NumericUpDown();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.grouper4 = new CodeVendor.Controls.Grouper();
            this.numericUpDown8 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown9 = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.grouper5 = new CodeVendor.Controls.Grouper();
            this.numericUpDown10 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown11 = new System.Windows.Forms.NumericUpDown();
            this.label15 = new System.Windows.Forms.Label();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.grouper6 = new CodeVendor.Controls.Grouper();
            this.checkBox8 = new System.Windows.Forms.CheckBox();
            this.checkBox9 = new System.Windows.Forms.CheckBox();
            this.checkBox10 = new System.Windows.Forms.CheckBox();
            this.checkBox11 = new System.Windows.Forms.CheckBox();
            this.checkBox12 = new System.Windows.Forms.CheckBox();
            this.checkBox13 = new System.Windows.Forms.CheckBox();
            this.checkBox14 = new System.Windows.Forms.CheckBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.numericUpDown12 = new System.Windows.Forms.NumericUpDown();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.grouper7 = new CodeVendor.Controls.Grouper();
            this.numericUpDown13 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown14 = new System.Windows.Forms.NumericUpDown();
            this.label17 = new System.Windows.Forms.Label();
            this.grouper8 = new CodeVendor.Controls.Grouper();
            this.numericUpDown15 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown16 = new System.Windows.Forms.NumericUpDown();
            this.label18 = new System.Windows.Forms.Label();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.grouper9 = new CodeVendor.Controls.Grouper();
            this.checkBox15 = new System.Windows.Forms.CheckBox();
            this.checkBox16 = new System.Windows.Forms.CheckBox();
            this.checkBox17 = new System.Windows.Forms.CheckBox();
            this.checkBox18 = new System.Windows.Forms.CheckBox();
            this.checkBox19 = new System.Windows.Forms.CheckBox();
            this.checkBox20 = new System.Windows.Forms.CheckBox();
            this.checkBox21 = new System.Windows.Forms.CheckBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label19 = new System.Windows.Forms.Label();
            this.numericUpDown17 = new System.Windows.Forms.NumericUpDown();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.serialConn1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClock0)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.batteryPower1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.switchForce5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.switchForce4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.switchForce3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.switchForce2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.switchForce1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.switchForce0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.onOff5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.onOff4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.onOff3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.onOff2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.onOff1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.onOff0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSchedule0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSchedule1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClock1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSchedule2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClock2)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.grouperDuration2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericDurationMinute2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericDurationHour2)).BeginInit();
            this.grouperTime2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericTimeMinute2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericTimeHour2)).BeginInit();
            this.grouperDay2.SuspendLayout();
            this.grouperDuration1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericDurationMinute1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericDurationHour1)).BeginInit();
            this.grouperTime1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericTimeMinute1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericTimeHour1)).BeginInit();
            this.grouperDay1.SuspendLayout();
            this.grouperDuration0.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericDurationMinute0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericDurationHour0)).BeginInit();
            this.grouperTime0.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericTimeMinute0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericTimeHour0)).BeginInit();
            this.grouperDay0.SuspendLayout();
            this.grouper1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.grouper2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grouper3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.grouper4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown9)).BeginInit();
            this.grouper5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.grouper6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            this.grouper7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown14)).BeginInit();
            this.grouper8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            this.grouper9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Minerva", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(177, -6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(680, 60);
            this.label1.TabIndex = 0;
            this.label1.Text = "Home Automation  - Version 1.0";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // serialConn1
            // 
            this.serialConn1.BaudRate = "AUTO";
            this.serialConn1.CheckSumType = MfgControl.AdvancedHMI.Drivers.DF1Transport.ChecksumOption.Crc;
            this.serialConn1.ComPort = "COM1";
            this.serialConn1.DisableSubscriptions = false;
            this.serialConn1.IniFileName = "";
            this.serialConn1.IniFileSection = null;
            this.serialConn1.IsPLC5 = false;
            this.serialConn1.MyNode = 0;
            this.serialConn1.Parity = System.IO.Ports.Parity.None;
            this.serialConn1.PollRateOverride = 500;
            this.serialConn1.TargetNode = 0;
            // 
            // commTimer
            // 
            this.commTimer.Enabled = true;
            this.commTimer.Interval = 500;
            this.commTimer.Tick += new System.EventHandler(this.commTimer_Tick);
            // 
            // pictureBoxClock0
            // 
            this.pictureBoxClock0.BackgroundImage = global::WindowsFormsApplication8.Resources.clock;
            this.pictureBoxClock0.Image = global::WindowsFormsApplication8.Properties.Resources.clock_small;
            this.pictureBoxClock0.Location = new System.Drawing.Point(687, 85);
            this.pictureBoxClock0.Name = "pictureBoxClock0";
            this.pictureBoxClock0.Size = new System.Drawing.Size(50, 50);
            this.pictureBoxClock0.TabIndex = 1;
            this.pictureBoxClock0.TabStop = false;
            this.pictureBoxClock0.Click += new System.EventHandler(this.pictureBoxClock0_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.batteryPower1);
            this.groupBox2.Controls.Add(this.pictureBox3);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(1060, 65);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(190, 88);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(119, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 37);
            this.label2.TabIndex = 3;
            this.label2.Text = "%";
            // 
            // batteryPower1
            // 
            this.batteryPower1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.batteryPower1.Location = new System.Drawing.Point(73, 23);
            this.batteryPower1.Name = "batteryPower1";
            this.batteryPower1.Size = new System.Drawing.Size(105, 47);
            this.batteryPower1.TabIndex = 2;
            this.batteryPower1.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::WindowsFormsApplication8.Resources.clock;
            this.pictureBox3.Image = global::WindowsFormsApplication8.Resources.battery_small;
            this.pictureBox3.Location = new System.Drawing.Point(17, 20);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(50, 50);
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            // 
            // switchForce5
            // 
            this.switchForce5.Image = global::WindowsFormsApplication8.Resources.force_off;
            this.switchForce5.Location = new System.Drawing.Point(185, 554);
            this.switchForce5.Name = "switchForce5";
            this.switchForce5.Size = new System.Drawing.Size(162, 75);
            this.switchForce5.TabIndex = 15;
            this.switchForce5.TabStop = false;
            this.switchForce5.Click += new System.EventHandler(this.switchForce5_Click);
            // 
            // switchForce4
            // 
            this.switchForce4.Image = global::WindowsFormsApplication8.Resources.force_off;
            this.switchForce4.Location = new System.Drawing.Point(185, 458);
            this.switchForce4.Name = "switchForce4";
            this.switchForce4.Size = new System.Drawing.Size(162, 75);
            this.switchForce4.TabIndex = 14;
            this.switchForce4.TabStop = false;
            this.switchForce4.Click += new System.EventHandler(this.switchForce4_Click);
            // 
            // switchForce3
            // 
            this.switchForce3.Image = global::WindowsFormsApplication8.Resources.force_off;
            this.switchForce3.Location = new System.Drawing.Point(185, 366);
            this.switchForce3.Name = "switchForce3";
            this.switchForce3.Size = new System.Drawing.Size(162, 75);
            this.switchForce3.TabIndex = 13;
            this.switchForce3.TabStop = false;
            this.switchForce3.Click += new System.EventHandler(this.switchForce3_Click);
            // 
            // switchForce2
            // 
            this.switchForce2.Image = global::WindowsFormsApplication8.Resources.force_off;
            this.switchForce2.Location = new System.Drawing.Point(185, 269);
            this.switchForce2.Name = "switchForce2";
            this.switchForce2.Size = new System.Drawing.Size(162, 75);
            this.switchForce2.TabIndex = 12;
            this.switchForce2.TabStop = false;
            this.switchForce2.Click += new System.EventHandler(this.switchForce2_Click);
            // 
            // switchForce1
            // 
            this.switchForce1.Image = global::WindowsFormsApplication8.Resources.force_off;
            this.switchForce1.Location = new System.Drawing.Point(185, 175);
            this.switchForce1.Name = "switchForce1";
            this.switchForce1.Size = new System.Drawing.Size(162, 75);
            this.switchForce1.TabIndex = 11;
            this.switchForce1.TabStop = false;
            this.switchForce1.Click += new System.EventHandler(this.switchForce1_Click);
            // 
            // switchForce0
            // 
            this.switchForce0.Image = global::WindowsFormsApplication8.Resources.force_off;
            this.switchForce0.Location = new System.Drawing.Point(185, 78);
            this.switchForce0.Name = "switchForce0";
            this.switchForce0.Size = new System.Drawing.Size(162, 75);
            this.switchForce0.TabIndex = 10;
            this.switchForce0.TabStop = false;
            this.switchForce0.Click += new System.EventHandler(this.switchForce0_Click);
            // 
            // onOff5
            // 
            this.onOff5.Image = global::WindowsFormsApplication8.Resources.switch_off_small;
            this.onOff5.Location = new System.Drawing.Point(17, 557);
            this.onOff5.Name = "onOff5";
            this.onOff5.Size = new System.Drawing.Size(162, 75);
            this.onOff5.TabIndex = 6;
            this.onOff5.TabStop = false;
            this.onOff5.Click += new System.EventHandler(this.onOff5_Click);
            // 
            // onOff4
            // 
            this.onOff4.Image = global::WindowsFormsApplication8.Resources.switch_off_small;
            this.onOff4.Location = new System.Drawing.Point(17, 458);
            this.onOff4.Name = "onOff4";
            this.onOff4.Size = new System.Drawing.Size(162, 75);
            this.onOff4.TabIndex = 5;
            this.onOff4.TabStop = false;
            this.onOff4.Click += new System.EventHandler(this.onOff4_Click);
            // 
            // onOff3
            // 
            this.onOff3.Image = global::WindowsFormsApplication8.Resources.switch_off_small;
            this.onOff3.Location = new System.Drawing.Point(17, 366);
            this.onOff3.Name = "onOff3";
            this.onOff3.Size = new System.Drawing.Size(162, 75);
            this.onOff3.TabIndex = 4;
            this.onOff3.TabStop = false;
            this.onOff3.Click += new System.EventHandler(this.onOff3_Click);
            // 
            // onOff2
            // 
            this.onOff2.Image = global::WindowsFormsApplication8.Resources.switch_off_small;
            this.onOff2.Location = new System.Drawing.Point(17, 269);
            this.onOff2.Name = "onOff2";
            this.onOff2.Size = new System.Drawing.Size(162, 75);
            this.onOff2.TabIndex = 3;
            this.onOff2.TabStop = false;
            this.onOff2.Click += new System.EventHandler(this.onOff2_Click);
            // 
            // onOff1
            // 
            this.onOff1.Image = global::WindowsFormsApplication8.Resources.switch_off_small;
            this.onOff1.Location = new System.Drawing.Point(17, 175);
            this.onOff1.Name = "onOff1";
            this.onOff1.Size = new System.Drawing.Size(162, 75);
            this.onOff1.TabIndex = 2;
            this.onOff1.TabStop = false;
            this.onOff1.Click += new System.EventHandler(this.onOff1_Click);
            // 
            // onOff0
            // 
            this.onOff0.Image = global::WindowsFormsApplication8.Resources.switch_off_small;
            this.onOff0.Location = new System.Drawing.Point(17, 78);
            this.onOff0.Name = "onOff0";
            this.onOff0.Size = new System.Drawing.Size(162, 75);
            this.onOff0.TabIndex = 1;
            this.onOff0.TabStop = false;
            this.onOff0.Click += new System.EventHandler(this.onOff0_Click);
            // 
            // textBoxOn0
            // 
            this.textBoxOn0.Location = new System.Drawing.Point(29, 664);
            this.textBoxOn0.Name = "textBoxOn0";
            this.textBoxOn0.Size = new System.Drawing.Size(18, 20);
            this.textBoxOn0.TabIndex = 16;
            this.textBoxOn0.TextChanged += new System.EventHandler(this.textBoxOn0_TextChanged);
            // 
            // textBoxOn1
            // 
            this.textBoxOn1.Location = new System.Drawing.Point(53, 664);
            this.textBoxOn1.Name = "textBoxOn1";
            this.textBoxOn1.Size = new System.Drawing.Size(18, 20);
            this.textBoxOn1.TabIndex = 17;
            this.textBoxOn1.TextChanged += new System.EventHandler(this.textBoxOn1_TextChanged);
            // 
            // textBoxOn2
            // 
            this.textBoxOn2.Location = new System.Drawing.Point(77, 664);
            this.textBoxOn2.Name = "textBoxOn2";
            this.textBoxOn2.Size = new System.Drawing.Size(18, 20);
            this.textBoxOn2.TabIndex = 18;
            this.textBoxOn2.TextChanged += new System.EventHandler(this.textBoxOn2_TextChanged);
            // 
            // textBoxOn3
            // 
            this.textBoxOn3.Location = new System.Drawing.Point(102, 664);
            this.textBoxOn3.Name = "textBoxOn3";
            this.textBoxOn3.Size = new System.Drawing.Size(18, 20);
            this.textBoxOn3.TabIndex = 19;
            this.textBoxOn3.TextChanged += new System.EventHandler(this.textBoxOn3_TextChanged);
            // 
            // textBoxOn4
            // 
            this.textBoxOn4.Location = new System.Drawing.Point(126, 664);
            this.textBoxOn4.Name = "textBoxOn4";
            this.textBoxOn4.Size = new System.Drawing.Size(18, 20);
            this.textBoxOn4.TabIndex = 20;
            this.textBoxOn4.TextChanged += new System.EventHandler(this.textBoxOn4_TextChanged);
            // 
            // textBoxForce4
            // 
            this.textBoxForce4.Location = new System.Drawing.Point(126, 690);
            this.textBoxForce4.Name = "textBoxForce4";
            this.textBoxForce4.Size = new System.Drawing.Size(18, 20);
            this.textBoxForce4.TabIndex = 25;
            // 
            // textBoxForce3
            // 
            this.textBoxForce3.Location = new System.Drawing.Point(102, 690);
            this.textBoxForce3.Name = "textBoxForce3";
            this.textBoxForce3.Size = new System.Drawing.Size(18, 20);
            this.textBoxForce3.TabIndex = 24;
            // 
            // textBoxForce2
            // 
            this.textBoxForce2.Location = new System.Drawing.Point(77, 690);
            this.textBoxForce2.Name = "textBoxForce2";
            this.textBoxForce2.Size = new System.Drawing.Size(18, 20);
            this.textBoxForce2.TabIndex = 23;
            // 
            // textBoxForce1
            // 
            this.textBoxForce1.Location = new System.Drawing.Point(53, 690);
            this.textBoxForce1.Name = "textBoxForce1";
            this.textBoxForce1.Size = new System.Drawing.Size(18, 20);
            this.textBoxForce1.TabIndex = 22;
            // 
            // textBoxForce0
            // 
            this.textBoxForce0.Location = new System.Drawing.Point(29, 690);
            this.textBoxForce0.Name = "textBoxForce0";
            this.textBoxForce0.Size = new System.Drawing.Size(18, 20);
            this.textBoxForce0.TabIndex = 21;
            // 
            // textBoxForce5
            // 
            this.textBoxForce5.Location = new System.Drawing.Point(150, 690);
            this.textBoxForce5.Name = "textBoxForce5";
            this.textBoxForce5.Size = new System.Drawing.Size(18, 20);
            this.textBoxForce5.TabIndex = 26;
            // 
            // textBoxOn5
            // 
            this.textBoxOn5.Location = new System.Drawing.Point(150, 664);
            this.textBoxOn5.Name = "textBoxOn5";
            this.textBoxOn5.Size = new System.Drawing.Size(18, 20);
            this.textBoxOn5.TabIndex = 27;
            this.textBoxOn5.TextChanged += new System.EventHandler(this.textBoxOn5_TextChanged);
            // 
            // textBoxConditionsMet5
            // 
            this.textBoxConditionsMet5.Location = new System.Drawing.Point(150, 638);
            this.textBoxConditionsMet5.Name = "textBoxConditionsMet5";
            this.textBoxConditionsMet5.Size = new System.Drawing.Size(18, 20);
            this.textBoxConditionsMet5.TabIndex = 33;
            // 
            // textBoxConditionsMet4
            // 
            this.textBoxConditionsMet4.Location = new System.Drawing.Point(126, 638);
            this.textBoxConditionsMet4.Name = "textBoxConditionsMet4";
            this.textBoxConditionsMet4.Size = new System.Drawing.Size(18, 20);
            this.textBoxConditionsMet4.TabIndex = 32;
            // 
            // textBoxConditionsMet3
            // 
            this.textBoxConditionsMet3.Location = new System.Drawing.Point(102, 638);
            this.textBoxConditionsMet3.Name = "textBoxConditionsMet3";
            this.textBoxConditionsMet3.Size = new System.Drawing.Size(18, 20);
            this.textBoxConditionsMet3.TabIndex = 31;
            // 
            // textBoxConditionsMet2
            // 
            this.textBoxConditionsMet2.Location = new System.Drawing.Point(77, 638);
            this.textBoxConditionsMet2.Name = "textBoxConditionsMet2";
            this.textBoxConditionsMet2.Size = new System.Drawing.Size(18, 20);
            this.textBoxConditionsMet2.TabIndex = 30;
            this.textBoxConditionsMet2.TextChanged += new System.EventHandler(this.textBoxConditionsMet2_TextChanged);
            // 
            // textBoxConditionsMet1
            // 
            this.textBoxConditionsMet1.Location = new System.Drawing.Point(53, 638);
            this.textBoxConditionsMet1.Name = "textBoxConditionsMet1";
            this.textBoxConditionsMet1.Size = new System.Drawing.Size(18, 20);
            this.textBoxConditionsMet1.TabIndex = 29;
            this.textBoxConditionsMet1.TextChanged += new System.EventHandler(this.textBoxConditionsMet1_TextChanged);
            // 
            // textBoxConditionsMet0
            // 
            this.textBoxConditionsMet0.Location = new System.Drawing.Point(29, 638);
            this.textBoxConditionsMet0.Name = "textBoxConditionsMet0";
            this.textBoxConditionsMet0.Size = new System.Drawing.Size(18, 20);
            this.textBoxConditionsMet0.TabIndex = 28;
            this.textBoxConditionsMet0.TextChanged += new System.EventHandler(this.textBoxConditionsMet0_TextChanged);
            // 
            // imgTimer
            // 
            this.imgTimer.Enabled = true;
            this.imgTimer.Tick += new System.EventHandler(this.imgTimer_Tick);
            // 
            // pictureBoxSchedule0
            // 
            this.pictureBoxSchedule0.BackgroundImage = global::WindowsFormsApplication8.Properties.Resources.calendar;
            this.pictureBoxSchedule0.Location = new System.Drawing.Point(353, 90);
            this.pictureBoxSchedule0.Name = "pictureBoxSchedule0";
            this.pictureBoxSchedule0.Size = new System.Drawing.Size(55, 50);
            this.pictureBoxSchedule0.TabIndex = 36;
            this.pictureBoxSchedule0.TabStop = false;
            this.pictureBoxSchedule0.Click += new System.EventHandler(this.pictureBoxSchedule0_Click);
            // 
            // textBoxConnectionStatus
            // 
            this.textBoxConnectionStatus.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxConnectionStatus.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBoxConnectionStatus.Font = new System.Drawing.Font("Cambria", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxConnectionStatus.Location = new System.Drawing.Point(17, 635);
            this.textBoxConnectionStatus.Name = "textBoxConnectionStatus";
            this.textBoxConnectionStatus.Size = new System.Drawing.Size(1233, 38);
            this.textBoxConnectionStatus.TabIndex = 38;
            this.textBoxConnectionStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // comboBoxComm
            // 
            this.comboBoxComm.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxComm.FormattingEnabled = true;
            this.comboBoxComm.Items.AddRange(new object[] {
            "COM1",
            "COM2",
            "COM3",
            "COM4"});
            this.comboBoxComm.Location = new System.Drawing.Point(187, 678);
            this.comboBoxComm.Name = "comboBoxComm";
            this.comboBoxComm.Size = new System.Drawing.Size(162, 40);
            this.comboBoxComm.TabIndex = 39;
            this.comboBoxComm.SelectedIndexChanged += new System.EventHandler(this.comboBoxComm_SelectedIndexChanged);
            // 
            // listBoxEvents
            // 
            this.listBoxEvents.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBoxEvents.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxEvents.FormattingEnabled = true;
            this.listBoxEvents.ItemHeight = 19;
            this.listBoxEvents.Location = new System.Drawing.Point(185, 638);
            this.listBoxEvents.Name = "listBoxEvents";
            this.listBoxEvents.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listBoxEvents.Size = new System.Drawing.Size(1065, 59);
            this.listBoxEvents.TabIndex = 40;
            this.listBoxEvents.Visible = false;
            // 
            // pictureBoxSchedule1
            // 
            this.pictureBoxSchedule1.BackgroundImage = global::WindowsFormsApplication8.Properties.Resources.calendar;
            this.pictureBoxSchedule1.Location = new System.Drawing.Point(353, 187);
            this.pictureBoxSchedule1.Name = "pictureBoxSchedule1";
            this.pictureBoxSchedule1.Size = new System.Drawing.Size(55, 50);
            this.pictureBoxSchedule1.TabIndex = 45;
            this.pictureBoxSchedule1.TabStop = false;
            this.pictureBoxSchedule1.Click += new System.EventHandler(this.pictureBoxSchedule1_Click);
            // 
            // pictureBoxClock1
            // 
            this.pictureBoxClock1.BackgroundImage = global::WindowsFormsApplication8.Resources.clock;
            this.pictureBoxClock1.Image = global::WindowsFormsApplication8.Properties.Resources.clock_small;
            this.pictureBoxClock1.Location = new System.Drawing.Point(687, 182);
            this.pictureBoxClock1.Name = "pictureBoxClock1";
            this.pictureBoxClock1.Size = new System.Drawing.Size(50, 50);
            this.pictureBoxClock1.TabIndex = 41;
            this.pictureBoxClock1.TabStop = false;
            this.pictureBoxClock1.Click += new System.EventHandler(this.pictureBoxClock1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.numericUpDown3);
            this.groupBox1.Controls.Add(this.pictureBox4);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(1060, 162);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(190, 88);
            this.groupBox1.TabIndex = 42;
            this.groupBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(119, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 37);
            this.label6.TabIndex = 3;
            this.label6.Text = "%";
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown3.Location = new System.Drawing.Point(73, 23);
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(105, 47);
            this.numericUpDown3.TabIndex = 2;
            this.numericUpDown3.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = global::WindowsFormsApplication8.Resources.clock;
            this.pictureBox4.Image = global::WindowsFormsApplication8.Resources.battery_small;
            this.pictureBox4.Location = new System.Drawing.Point(15, 20);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(50, 50);
            this.pictureBox4.TabIndex = 1;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBoxSchedule2
            // 
            this.pictureBoxSchedule2.BackgroundImage = global::WindowsFormsApplication8.Properties.Resources.calendar;
            this.pictureBoxSchedule2.Location = new System.Drawing.Point(353, 281);
            this.pictureBoxSchedule2.Name = "pictureBoxSchedule2";
            this.pictureBoxSchedule2.Size = new System.Drawing.Size(55, 50);
            this.pictureBoxSchedule2.TabIndex = 51;
            this.pictureBoxSchedule2.TabStop = false;
            this.pictureBoxSchedule2.Click += new System.EventHandler(this.pictureBoxSchedule2_Click);
            // 
            // pictureBoxClock2
            // 
            this.pictureBoxClock2.BackgroundImage = global::WindowsFormsApplication8.Resources.clock;
            this.pictureBoxClock2.Image = global::WindowsFormsApplication8.Properties.Resources.clock_small;
            this.pictureBoxClock2.Location = new System.Drawing.Point(687, 276);
            this.pictureBoxClock2.Name = "pictureBoxClock2";
            this.pictureBoxClock2.Size = new System.Drawing.Size(50, 50);
            this.pictureBoxClock2.TabIndex = 47;
            this.pictureBoxClock2.TabStop = false;
            this.pictureBoxClock2.Click += new System.EventHandler(this.pictureBoxClock2_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.numericUpDown6);
            this.groupBox3.Controls.Add(this.pictureBox5);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(1060, 256);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(190, 88);
            this.groupBox3.TabIndex = 48;
            this.groupBox3.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(119, 25);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 37);
            this.label10.TabIndex = 3;
            this.label10.Text = "%";
            // 
            // numericUpDown6
            // 
            this.numericUpDown6.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown6.Location = new System.Drawing.Point(73, 23);
            this.numericUpDown6.Name = "numericUpDown6";
            this.numericUpDown6.Size = new System.Drawing.Size(105, 47);
            this.numericUpDown6.TabIndex = 2;
            this.numericUpDown6.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackgroundImage = global::WindowsFormsApplication8.Resources.clock;
            this.pictureBox5.Image = global::WindowsFormsApplication8.Resources.battery_small;
            this.pictureBox5.Location = new System.Drawing.Point(15, 20);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(50, 50);
            this.pictureBox5.TabIndex = 1;
            this.pictureBox5.TabStop = false;
            // 
            // grouperDuration2
            // 
            this.grouperDuration2.BackgroundColor = System.Drawing.Color.White;
            this.grouperDuration2.BackgroundGradientColor = System.Drawing.Color.White;
            this.grouperDuration2.BackgroundGradientMode = CodeVendor.Controls.Grouper.GroupBoxGradientMode.None;
            this.grouperDuration2.BorderColor = System.Drawing.Color.Black;
            this.grouperDuration2.BorderThickness = 3F;
            this.grouperDuration2.Controls.Add(this.numericDurationMinute2);
            this.grouperDuration2.Controls.Add(this.numericDurationHour2);
            this.grouperDuration2.Controls.Add(this.label8);
            this.grouperDuration2.CustomGroupBoxColor = System.Drawing.Color.White;
            this.grouperDuration2.GroupImage = null;
            this.grouperDuration2.GroupTitle = "Duration";
            this.grouperDuration2.Location = new System.Drawing.Point(907, 256);
            this.grouperDuration2.Name = "grouperDuration2";
            this.grouperDuration2.Padding = new System.Windows.Forms.Padding(20);
            this.grouperDuration2.PaintGroupBox = false;
            this.grouperDuration2.RoundCorners = 10;
            this.grouperDuration2.ShadowColor = System.Drawing.Color.DarkGray;
            this.grouperDuration2.ShadowControl = false;
            this.grouperDuration2.ShadowThickness = 3;
            this.grouperDuration2.Size = new System.Drawing.Size(164, 88);
            this.grouperDuration2.TabIndex = 52;
            // 
            // numericDurationMinute2
            // 
            this.numericDurationMinute2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericDurationMinute2.Location = new System.Drawing.Point(92, 26);
            this.numericDurationMinute2.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numericDurationMinute2.Name = "numericDurationMinute2";
            this.numericDurationMinute2.Size = new System.Drawing.Size(59, 47);
            this.numericDurationMinute2.TabIndex = 8;
            // 
            // numericDurationHour2
            // 
            this.numericDurationHour2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericDurationHour2.Location = new System.Drawing.Point(15, 26);
            this.numericDurationHour2.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.numericDurationHour2.Name = "numericDurationHour2";
            this.numericDurationHour2.Size = new System.Drawing.Size(57, 47);
            this.numericDurationHour2.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(67, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 37);
            this.label8.TabIndex = 7;
            this.label8.Text = ":";
            // 
            // grouperTime2
            // 
            this.grouperTime2.BackgroundColor = System.Drawing.Color.White;
            this.grouperTime2.BackgroundGradientColor = System.Drawing.Color.White;
            this.grouperTime2.BackgroundGradientMode = CodeVendor.Controls.Grouper.GroupBoxGradientMode.None;
            this.grouperTime2.BorderColor = System.Drawing.Color.Black;
            this.grouperTime2.BorderThickness = 3F;
            this.grouperTime2.Controls.Add(this.numericTimeMinute2);
            this.grouperTime2.Controls.Add(this.numericTimeHour2);
            this.grouperTime2.Controls.Add(this.label9);
            this.grouperTime2.CustomGroupBoxColor = System.Drawing.Color.White;
            this.grouperTime2.GroupImage = null;
            this.grouperTime2.GroupTitle = "Enable on Time";
            this.grouperTime2.Location = new System.Drawing.Point(743, 256);
            this.grouperTime2.Name = "grouperTime2";
            this.grouperTime2.Padding = new System.Windows.Forms.Padding(20);
            this.grouperTime2.PaintGroupBox = false;
            this.grouperTime2.RoundCorners = 10;
            this.grouperTime2.ShadowColor = System.Drawing.Color.DarkGray;
            this.grouperTime2.ShadowControl = false;
            this.grouperTime2.ShadowThickness = 3;
            this.grouperTime2.Size = new System.Drawing.Size(164, 88);
            this.grouperTime2.TabIndex = 50;
            // 
            // numericTimeMinute2
            // 
            this.numericTimeMinute2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericTimeMinute2.Location = new System.Drawing.Point(92, 26);
            this.numericTimeMinute2.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numericTimeMinute2.Name = "numericTimeMinute2";
            this.numericTimeMinute2.Size = new System.Drawing.Size(59, 47);
            this.numericTimeMinute2.TabIndex = 8;
            // 
            // numericTimeHour2
            // 
            this.numericTimeHour2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericTimeHour2.Location = new System.Drawing.Point(15, 26);
            this.numericTimeHour2.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.numericTimeHour2.Name = "numericTimeHour2";
            this.numericTimeHour2.Size = new System.Drawing.Size(57, 47);
            this.numericTimeHour2.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(67, 28);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(26, 37);
            this.label9.TabIndex = 7;
            this.label9.Text = ":";
            // 
            // grouperDay2
            // 
            this.grouperDay2.BackgroundColor = System.Drawing.Color.White;
            this.grouperDay2.BackgroundGradientColor = System.Drawing.Color.White;
            this.grouperDay2.BackgroundGradientMode = CodeVendor.Controls.Grouper.GroupBoxGradientMode.None;
            this.grouperDay2.BorderColor = System.Drawing.Color.Black;
            this.grouperDay2.BorderThickness = 3F;
            this.grouperDay2.Controls.Add(this.checkBoxSu2);
            this.grouperDay2.Controls.Add(this.checkBoxS2);
            this.grouperDay2.Controls.Add(this.checkBoxF2);
            this.grouperDay2.Controls.Add(this.checkBoxR2);
            this.grouperDay2.Controls.Add(this.checkBoxW2);
            this.grouperDay2.Controls.Add(this.checkBoxT2);
            this.grouperDay2.Controls.Add(this.checkBoxM2);
            this.grouperDay2.CustomGroupBoxColor = System.Drawing.Color.White;
            this.grouperDay2.GroupImage = null;
            this.grouperDay2.GroupTitle = "Enable on Day";
            this.grouperDay2.Location = new System.Drawing.Point(414, 256);
            this.grouperDay2.Name = "grouperDay2";
            this.grouperDay2.Padding = new System.Windows.Forms.Padding(20);
            this.grouperDay2.PaintGroupBox = false;
            this.grouperDay2.RoundCorners = 10;
            this.grouperDay2.ShadowColor = System.Drawing.Color.DarkGray;
            this.grouperDay2.ShadowControl = false;
            this.grouperDay2.ShadowThickness = 3;
            this.grouperDay2.Size = new System.Drawing.Size(256, 88);
            this.grouperDay2.TabIndex = 49;
            // 
            // checkBoxSu2
            // 
            this.checkBoxSu2.AutoSize = true;
            this.checkBoxSu2.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxSu2.Location = new System.Drawing.Point(201, 50);
            this.checkBoxSu2.Name = "checkBoxSu2";
            this.checkBoxSu2.Size = new System.Drawing.Size(55, 23);
            this.checkBoxSu2.TabIndex = 14;
            this.checkBoxSu2.Text = "Sun";
            this.checkBoxSu2.UseVisualStyleBackColor = true;
            this.checkBoxSu2.CheckedChanged += new System.EventHandler(this.checkBoxSu2_CheckedChanged);
            // 
            // checkBoxS2
            // 
            this.checkBoxS2.AutoSize = true;
            this.checkBoxS2.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxS2.Location = new System.Drawing.Point(144, 50);
            this.checkBoxS2.Name = "checkBoxS2";
            this.checkBoxS2.Size = new System.Drawing.Size(51, 23);
            this.checkBoxS2.TabIndex = 13;
            this.checkBoxS2.Text = "Sat";
            this.checkBoxS2.UseVisualStyleBackColor = true;
            this.checkBoxS2.CheckedChanged += new System.EventHandler(this.checkBoxS2_CheckedChanged);
            // 
            // checkBoxF2
            // 
            this.checkBoxF2.AutoSize = true;
            this.checkBoxF2.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxF2.Location = new System.Drawing.Point(78, 50);
            this.checkBoxF2.Name = "checkBoxF2";
            this.checkBoxF2.Size = new System.Drawing.Size(46, 23);
            this.checkBoxF2.TabIndex = 12;
            this.checkBoxF2.Text = "Fri";
            this.checkBoxF2.UseVisualStyleBackColor = true;
            this.checkBoxF2.CheckedChanged += new System.EventHandler(this.checkBoxF2_CheckedChanged);
            // 
            // checkBoxR2
            // 
            this.checkBoxR2.AutoSize = true;
            this.checkBoxR2.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxR2.Location = new System.Drawing.Point(13, 50);
            this.checkBoxR2.Name = "checkBoxR2";
            this.checkBoxR2.Size = new System.Drawing.Size(61, 23);
            this.checkBoxR2.TabIndex = 11;
            this.checkBoxR2.Text = "Thur";
            this.checkBoxR2.UseVisualStyleBackColor = true;
            this.checkBoxR2.CheckedChanged += new System.EventHandler(this.checkBoxR2_CheckedChanged);
            // 
            // checkBoxW2
            // 
            this.checkBoxW2.AutoSize = true;
            this.checkBoxW2.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxW2.Location = new System.Drawing.Point(144, 23);
            this.checkBoxW2.Name = "checkBoxW2";
            this.checkBoxW2.Size = new System.Drawing.Size(59, 23);
            this.checkBoxW2.TabIndex = 10;
            this.checkBoxW2.Text = "Wed";
            this.checkBoxW2.UseVisualStyleBackColor = true;
            this.checkBoxW2.CheckedChanged += new System.EventHandler(this.checkBoxW2_CheckedChanged);
            // 
            // checkBoxT2
            // 
            this.checkBoxT2.AutoSize = true;
            this.checkBoxT2.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxT2.Location = new System.Drawing.Point(78, 23);
            this.checkBoxT2.Name = "checkBoxT2";
            this.checkBoxT2.Size = new System.Drawing.Size(60, 23);
            this.checkBoxT2.TabIndex = 9;
            this.checkBoxT2.Text = "Tues";
            this.checkBoxT2.UseVisualStyleBackColor = true;
            this.checkBoxT2.CheckedChanged += new System.EventHandler(this.checkBoxT2_CheckedChanged);
            // 
            // checkBoxM2
            // 
            this.checkBoxM2.AutoSize = true;
            this.checkBoxM2.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxM2.Location = new System.Drawing.Point(13, 23);
            this.checkBoxM2.Name = "checkBoxM2";
            this.checkBoxM2.Size = new System.Drawing.Size(59, 23);
            this.checkBoxM2.TabIndex = 8;
            this.checkBoxM2.Text = "Mon";
            this.checkBoxM2.UseVisualStyleBackColor = true;
            this.checkBoxM2.CheckedChanged += new System.EventHandler(this.checkBoxM2_CheckedChanged);
            // 
            // grouperDuration1
            // 
            this.grouperDuration1.BackgroundColor = System.Drawing.Color.White;
            this.grouperDuration1.BackgroundGradientColor = System.Drawing.Color.White;
            this.grouperDuration1.BackgroundGradientMode = CodeVendor.Controls.Grouper.GroupBoxGradientMode.None;
            this.grouperDuration1.BorderColor = System.Drawing.Color.Black;
            this.grouperDuration1.BorderThickness = 3F;
            this.grouperDuration1.Controls.Add(this.numericDurationMinute1);
            this.grouperDuration1.Controls.Add(this.numericDurationHour1);
            this.grouperDuration1.Controls.Add(this.label7);
            this.grouperDuration1.CustomGroupBoxColor = System.Drawing.Color.White;
            this.grouperDuration1.GroupImage = null;
            this.grouperDuration1.GroupTitle = "Duration";
            this.grouperDuration1.Location = new System.Drawing.Point(907, 162);
            this.grouperDuration1.Name = "grouperDuration1";
            this.grouperDuration1.Padding = new System.Windows.Forms.Padding(20);
            this.grouperDuration1.PaintGroupBox = false;
            this.grouperDuration1.RoundCorners = 10;
            this.grouperDuration1.ShadowColor = System.Drawing.Color.DarkGray;
            this.grouperDuration1.ShadowControl = false;
            this.grouperDuration1.ShadowThickness = 3;
            this.grouperDuration1.Size = new System.Drawing.Size(164, 88);
            this.grouperDuration1.TabIndex = 46;
            // 
            // numericDurationMinute1
            // 
            this.numericDurationMinute1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericDurationMinute1.Location = new System.Drawing.Point(92, 26);
            this.numericDurationMinute1.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numericDurationMinute1.Name = "numericDurationMinute1";
            this.numericDurationMinute1.Size = new System.Drawing.Size(59, 47);
            this.numericDurationMinute1.TabIndex = 8;
            this.numericDurationMinute1.ValueChanged += new System.EventHandler(this.numericDurationMinute1_ValueChanged_1);
            // 
            // numericDurationHour1
            // 
            this.numericDurationHour1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericDurationHour1.Location = new System.Drawing.Point(15, 26);
            this.numericDurationHour1.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.numericDurationHour1.Name = "numericDurationHour1";
            this.numericDurationHour1.Size = new System.Drawing.Size(57, 47);
            this.numericDurationHour1.TabIndex = 6;
            this.numericDurationHour1.ValueChanged += new System.EventHandler(this.numericDurationHour1_ValueChanged_1);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(67, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 37);
            this.label7.TabIndex = 7;
            this.label7.Text = ":";
            // 
            // grouperTime1
            // 
            this.grouperTime1.BackgroundColor = System.Drawing.Color.White;
            this.grouperTime1.BackgroundGradientColor = System.Drawing.Color.White;
            this.grouperTime1.BackgroundGradientMode = CodeVendor.Controls.Grouper.GroupBoxGradientMode.None;
            this.grouperTime1.BorderColor = System.Drawing.Color.Black;
            this.grouperTime1.BorderThickness = 3F;
            this.grouperTime1.Controls.Add(this.numericTimeMinute1);
            this.grouperTime1.Controls.Add(this.numericTimeHour1);
            this.grouperTime1.Controls.Add(this.label5);
            this.grouperTime1.CustomGroupBoxColor = System.Drawing.Color.White;
            this.grouperTime1.GroupImage = null;
            this.grouperTime1.GroupTitle = "Enable on Time";
            this.grouperTime1.Location = new System.Drawing.Point(743, 162);
            this.grouperTime1.Name = "grouperTime1";
            this.grouperTime1.Padding = new System.Windows.Forms.Padding(20);
            this.grouperTime1.PaintGroupBox = false;
            this.grouperTime1.RoundCorners = 10;
            this.grouperTime1.ShadowColor = System.Drawing.Color.DarkGray;
            this.grouperTime1.ShadowControl = false;
            this.grouperTime1.ShadowThickness = 3;
            this.grouperTime1.Size = new System.Drawing.Size(164, 88);
            this.grouperTime1.TabIndex = 44;
            // 
            // numericTimeMinute1
            // 
            this.numericTimeMinute1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericTimeMinute1.Location = new System.Drawing.Point(92, 26);
            this.numericTimeMinute1.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numericTimeMinute1.Name = "numericTimeMinute1";
            this.numericTimeMinute1.Size = new System.Drawing.Size(59, 47);
            this.numericTimeMinute1.TabIndex = 8;
            this.numericTimeMinute1.ValueChanged += new System.EventHandler(this.numericTimeMinute1_ValueChanged);
            // 
            // numericTimeHour1
            // 
            this.numericTimeHour1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericTimeHour1.Location = new System.Drawing.Point(15, 26);
            this.numericTimeHour1.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.numericTimeHour1.Name = "numericTimeHour1";
            this.numericTimeHour1.Size = new System.Drawing.Size(57, 47);
            this.numericTimeHour1.TabIndex = 6;
            this.numericTimeHour1.ValueChanged += new System.EventHandler(this.numericTimeHour1_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(67, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 37);
            this.label5.TabIndex = 7;
            this.label5.Text = ":";
            // 
            // grouperDay1
            // 
            this.grouperDay1.BackgroundColor = System.Drawing.Color.White;
            this.grouperDay1.BackgroundGradientColor = System.Drawing.Color.White;
            this.grouperDay1.BackgroundGradientMode = CodeVendor.Controls.Grouper.GroupBoxGradientMode.None;
            this.grouperDay1.BorderColor = System.Drawing.Color.Black;
            this.grouperDay1.BorderThickness = 3F;
            this.grouperDay1.Controls.Add(this.checkBoxSu1);
            this.grouperDay1.Controls.Add(this.checkBoxS1);
            this.grouperDay1.Controls.Add(this.checkBoxF1);
            this.grouperDay1.Controls.Add(this.checkBoxR1);
            this.grouperDay1.Controls.Add(this.checkBoxW1);
            this.grouperDay1.Controls.Add(this.checkBoxT1);
            this.grouperDay1.Controls.Add(this.checkBoxM1);
            this.grouperDay1.CustomGroupBoxColor = System.Drawing.Color.White;
            this.grouperDay1.GroupImage = null;
            this.grouperDay1.GroupTitle = "Enable on Day";
            this.grouperDay1.Location = new System.Drawing.Point(414, 162);
            this.grouperDay1.Name = "grouperDay1";
            this.grouperDay1.Padding = new System.Windows.Forms.Padding(20);
            this.grouperDay1.PaintGroupBox = false;
            this.grouperDay1.RoundCorners = 10;
            this.grouperDay1.ShadowColor = System.Drawing.Color.DarkGray;
            this.grouperDay1.ShadowControl = false;
            this.grouperDay1.ShadowThickness = 3;
            this.grouperDay1.Size = new System.Drawing.Size(256, 88);
            this.grouperDay1.TabIndex = 43;
            // 
            // checkBoxSu1
            // 
            this.checkBoxSu1.AutoSize = true;
            this.checkBoxSu1.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxSu1.Location = new System.Drawing.Point(201, 50);
            this.checkBoxSu1.Name = "checkBoxSu1";
            this.checkBoxSu1.Size = new System.Drawing.Size(55, 23);
            this.checkBoxSu1.TabIndex = 14;
            this.checkBoxSu1.Text = "Sun";
            this.checkBoxSu1.UseVisualStyleBackColor = true;
            this.checkBoxSu1.CheckedChanged += new System.EventHandler(this.checkBoxSu1_CheckedChanged);
            // 
            // checkBoxS1
            // 
            this.checkBoxS1.AutoSize = true;
            this.checkBoxS1.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxS1.Location = new System.Drawing.Point(144, 50);
            this.checkBoxS1.Name = "checkBoxS1";
            this.checkBoxS1.Size = new System.Drawing.Size(51, 23);
            this.checkBoxS1.TabIndex = 13;
            this.checkBoxS1.Text = "Sat";
            this.checkBoxS1.UseVisualStyleBackColor = true;
            this.checkBoxS1.CheckedChanged += new System.EventHandler(this.checkBoxS1_CheckedChanged);
            // 
            // checkBoxF1
            // 
            this.checkBoxF1.AutoSize = true;
            this.checkBoxF1.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxF1.Location = new System.Drawing.Point(78, 50);
            this.checkBoxF1.Name = "checkBoxF1";
            this.checkBoxF1.Size = new System.Drawing.Size(46, 23);
            this.checkBoxF1.TabIndex = 12;
            this.checkBoxF1.Text = "Fri";
            this.checkBoxF1.UseVisualStyleBackColor = true;
            this.checkBoxF1.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // checkBoxR1
            // 
            this.checkBoxR1.AutoSize = true;
            this.checkBoxR1.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxR1.Location = new System.Drawing.Point(13, 50);
            this.checkBoxR1.Name = "checkBoxR1";
            this.checkBoxR1.Size = new System.Drawing.Size(61, 23);
            this.checkBoxR1.TabIndex = 11;
            this.checkBoxR1.Text = "Thur";
            this.checkBoxR1.UseVisualStyleBackColor = true;
            this.checkBoxR1.CheckedChanged += new System.EventHandler(this.checkBoxR1_CheckedChanged);
            // 
            // checkBoxW1
            // 
            this.checkBoxW1.AutoSize = true;
            this.checkBoxW1.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxW1.Location = new System.Drawing.Point(144, 23);
            this.checkBoxW1.Name = "checkBoxW1";
            this.checkBoxW1.Size = new System.Drawing.Size(59, 23);
            this.checkBoxW1.TabIndex = 10;
            this.checkBoxW1.Text = "Wed";
            this.checkBoxW1.UseVisualStyleBackColor = true;
            this.checkBoxW1.CheckedChanged += new System.EventHandler(this.checkBoxW1_CheckedChanged);
            // 
            // checkBoxT1
            // 
            this.checkBoxT1.AutoSize = true;
            this.checkBoxT1.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxT1.Location = new System.Drawing.Point(78, 23);
            this.checkBoxT1.Name = "checkBoxT1";
            this.checkBoxT1.Size = new System.Drawing.Size(60, 23);
            this.checkBoxT1.TabIndex = 9;
            this.checkBoxT1.Text = "Tues";
            this.checkBoxT1.UseVisualStyleBackColor = true;
            this.checkBoxT1.CheckedChanged += new System.EventHandler(this.checkBoxT1_CheckedChanged);
            // 
            // checkBoxM1
            // 
            this.checkBoxM1.AutoSize = true;
            this.checkBoxM1.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxM1.Location = new System.Drawing.Point(13, 23);
            this.checkBoxM1.Name = "checkBoxM1";
            this.checkBoxM1.Size = new System.Drawing.Size(59, 23);
            this.checkBoxM1.TabIndex = 8;
            this.checkBoxM1.Text = "Mon";
            this.checkBoxM1.UseVisualStyleBackColor = true;
            this.checkBoxM1.CheckedChanged += new System.EventHandler(this.checkBoxM1_CheckedChanged);
            // 
            // grouperDuration0
            // 
            this.grouperDuration0.BackgroundColor = System.Drawing.Color.White;
            this.grouperDuration0.BackgroundGradientColor = System.Drawing.Color.White;
            this.grouperDuration0.BackgroundGradientMode = CodeVendor.Controls.Grouper.GroupBoxGradientMode.None;
            this.grouperDuration0.BorderColor = System.Drawing.Color.Black;
            this.grouperDuration0.BorderThickness = 3F;
            this.grouperDuration0.Controls.Add(this.numericDurationMinute0);
            this.grouperDuration0.Controls.Add(this.numericDurationHour0);
            this.grouperDuration0.Controls.Add(this.label4);
            this.grouperDuration0.CustomGroupBoxColor = System.Drawing.Color.White;
            this.grouperDuration0.GroupImage = null;
            this.grouperDuration0.GroupTitle = "Duration";
            this.grouperDuration0.Location = new System.Drawing.Point(907, 65);
            this.grouperDuration0.Name = "grouperDuration0";
            this.grouperDuration0.Padding = new System.Windows.Forms.Padding(20);
            this.grouperDuration0.PaintGroupBox = false;
            this.grouperDuration0.RoundCorners = 10;
            this.grouperDuration0.ShadowColor = System.Drawing.Color.DarkGray;
            this.grouperDuration0.ShadowControl = false;
            this.grouperDuration0.ShadowThickness = 3;
            this.grouperDuration0.Size = new System.Drawing.Size(164, 88);
            this.grouperDuration0.TabIndex = 37;
            // 
            // numericDurationMinute0
            // 
            this.numericDurationMinute0.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericDurationMinute0.Location = new System.Drawing.Point(92, 26);
            this.numericDurationMinute0.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numericDurationMinute0.Name = "numericDurationMinute0";
            this.numericDurationMinute0.Size = new System.Drawing.Size(59, 47);
            this.numericDurationMinute0.TabIndex = 8;
            this.numericDurationMinute0.ValueChanged += new System.EventHandler(this.numericDurationMinute0_ValueChanged);
            // 
            // numericDurationHour0
            // 
            this.numericDurationHour0.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericDurationHour0.Location = new System.Drawing.Point(15, 26);
            this.numericDurationHour0.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.numericDurationHour0.Name = "numericDurationHour0";
            this.numericDurationHour0.Size = new System.Drawing.Size(57, 47);
            this.numericDurationHour0.TabIndex = 6;
            this.numericDurationHour0.ValueChanged += new System.EventHandler(this.numericDurationHour0_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(67, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 37);
            this.label4.TabIndex = 7;
            this.label4.Text = ":";
            // 
            // grouperTime0
            // 
            this.grouperTime0.BackgroundColor = System.Drawing.Color.White;
            this.grouperTime0.BackgroundGradientColor = System.Drawing.Color.White;
            this.grouperTime0.BackgroundGradientMode = CodeVendor.Controls.Grouper.GroupBoxGradientMode.None;
            this.grouperTime0.BorderColor = System.Drawing.Color.Black;
            this.grouperTime0.BorderThickness = 3F;
            this.grouperTime0.Controls.Add(this.numericTimeMinute0);
            this.grouperTime0.Controls.Add(this.numericTimeHour0);
            this.grouperTime0.Controls.Add(this.label3);
            this.grouperTime0.CustomGroupBoxColor = System.Drawing.Color.White;
            this.grouperTime0.GroupImage = null;
            this.grouperTime0.GroupTitle = "Enable on Time";
            this.grouperTime0.Location = new System.Drawing.Point(743, 65);
            this.grouperTime0.Name = "grouperTime0";
            this.grouperTime0.Padding = new System.Windows.Forms.Padding(20);
            this.grouperTime0.PaintGroupBox = false;
            this.grouperTime0.RoundCorners = 10;
            this.grouperTime0.ShadowColor = System.Drawing.Color.DarkGray;
            this.grouperTime0.ShadowControl = false;
            this.grouperTime0.ShadowThickness = 3;
            this.grouperTime0.Size = new System.Drawing.Size(164, 88);
            this.grouperTime0.TabIndex = 36;
            // 
            // numericTimeMinute0
            // 
            this.numericTimeMinute0.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericTimeMinute0.Location = new System.Drawing.Point(92, 26);
            this.numericTimeMinute0.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numericTimeMinute0.Name = "numericTimeMinute0";
            this.numericTimeMinute0.Size = new System.Drawing.Size(59, 47);
            this.numericTimeMinute0.TabIndex = 8;
            this.numericTimeMinute0.ValueChanged += new System.EventHandler(this.numericMinute0_ValueChanged);
            // 
            // numericTimeHour0
            // 
            this.numericTimeHour0.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericTimeHour0.Location = new System.Drawing.Point(15, 26);
            this.numericTimeHour0.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.numericTimeHour0.Name = "numericTimeHour0";
            this.numericTimeHour0.Size = new System.Drawing.Size(57, 47);
            this.numericTimeHour0.TabIndex = 6;
            this.numericTimeHour0.ValueChanged += new System.EventHandler(this.numericHour0_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(67, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 37);
            this.label3.TabIndex = 7;
            this.label3.Text = ":";
            // 
            // grouperDay0
            // 
            this.grouperDay0.BackgroundColor = System.Drawing.Color.White;
            this.grouperDay0.BackgroundGradientColor = System.Drawing.Color.White;
            this.grouperDay0.BackgroundGradientMode = CodeVendor.Controls.Grouper.GroupBoxGradientMode.None;
            this.grouperDay0.BorderColor = System.Drawing.Color.Black;
            this.grouperDay0.BorderThickness = 3F;
            this.grouperDay0.Controls.Add(this.checkBoxSu0);
            this.grouperDay0.Controls.Add(this.checkBoxS0);
            this.grouperDay0.Controls.Add(this.checkBoxF0);
            this.grouperDay0.Controls.Add(this.checkBoxR0);
            this.grouperDay0.Controls.Add(this.checkBoxW0);
            this.grouperDay0.Controls.Add(this.checkBoxT0);
            this.grouperDay0.Controls.Add(this.checkBoxM0);
            this.grouperDay0.CustomGroupBoxColor = System.Drawing.Color.White;
            this.grouperDay0.GroupImage = null;
            this.grouperDay0.GroupTitle = "Enable on Day";
            this.grouperDay0.Location = new System.Drawing.Point(414, 65);
            this.grouperDay0.Name = "grouperDay0";
            this.grouperDay0.Padding = new System.Windows.Forms.Padding(20);
            this.grouperDay0.PaintGroupBox = false;
            this.grouperDay0.RoundCorners = 10;
            this.grouperDay0.ShadowColor = System.Drawing.Color.DarkGray;
            this.grouperDay0.ShadowControl = false;
            this.grouperDay0.ShadowThickness = 3;
            this.grouperDay0.Size = new System.Drawing.Size(256, 88);
            this.grouperDay0.TabIndex = 35;
            // 
            // checkBoxSu0
            // 
            this.checkBoxSu0.AutoSize = true;
            this.checkBoxSu0.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxSu0.Location = new System.Drawing.Point(201, 50);
            this.checkBoxSu0.Name = "checkBoxSu0";
            this.checkBoxSu0.Size = new System.Drawing.Size(55, 23);
            this.checkBoxSu0.TabIndex = 14;
            this.checkBoxSu0.Text = "Sun";
            this.checkBoxSu0.UseVisualStyleBackColor = true;
            this.checkBoxSu0.CheckedChanged += new System.EventHandler(this.checkBoxSu_CheckedChanged);
            // 
            // checkBoxS0
            // 
            this.checkBoxS0.AutoSize = true;
            this.checkBoxS0.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxS0.Location = new System.Drawing.Point(144, 50);
            this.checkBoxS0.Name = "checkBoxS0";
            this.checkBoxS0.Size = new System.Drawing.Size(51, 23);
            this.checkBoxS0.TabIndex = 13;
            this.checkBoxS0.Text = "Sat";
            this.checkBoxS0.UseVisualStyleBackColor = true;
            this.checkBoxS0.CheckedChanged += new System.EventHandler(this.checkBoxS_CheckedChanged);
            // 
            // checkBoxF0
            // 
            this.checkBoxF0.AutoSize = true;
            this.checkBoxF0.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxF0.Location = new System.Drawing.Point(78, 50);
            this.checkBoxF0.Name = "checkBoxF0";
            this.checkBoxF0.Size = new System.Drawing.Size(46, 23);
            this.checkBoxF0.TabIndex = 12;
            this.checkBoxF0.Text = "Fri";
            this.checkBoxF0.UseVisualStyleBackColor = true;
            this.checkBoxF0.CheckedChanged += new System.EventHandler(this.checkBoxF_CheckedChanged);
            // 
            // checkBoxR0
            // 
            this.checkBoxR0.AutoSize = true;
            this.checkBoxR0.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxR0.Location = new System.Drawing.Point(13, 50);
            this.checkBoxR0.Name = "checkBoxR0";
            this.checkBoxR0.Size = new System.Drawing.Size(61, 23);
            this.checkBoxR0.TabIndex = 11;
            this.checkBoxR0.Text = "Thur";
            this.checkBoxR0.UseVisualStyleBackColor = true;
            this.checkBoxR0.CheckedChanged += new System.EventHandler(this.checkBoxR_CheckedChanged);
            // 
            // checkBoxW0
            // 
            this.checkBoxW0.AutoSize = true;
            this.checkBoxW0.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxW0.Location = new System.Drawing.Point(144, 23);
            this.checkBoxW0.Name = "checkBoxW0";
            this.checkBoxW0.Size = new System.Drawing.Size(59, 23);
            this.checkBoxW0.TabIndex = 10;
            this.checkBoxW0.Text = "Wed";
            this.checkBoxW0.UseVisualStyleBackColor = true;
            this.checkBoxW0.CheckedChanged += new System.EventHandler(this.checkBoxW_CheckedChanged);
            // 
            // checkBoxT0
            // 
            this.checkBoxT0.AutoSize = true;
            this.checkBoxT0.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxT0.Location = new System.Drawing.Point(78, 23);
            this.checkBoxT0.Name = "checkBoxT0";
            this.checkBoxT0.Size = new System.Drawing.Size(60, 23);
            this.checkBoxT0.TabIndex = 9;
            this.checkBoxT0.Text = "Tues";
            this.checkBoxT0.UseVisualStyleBackColor = true;
            this.checkBoxT0.CheckedChanged += new System.EventHandler(this.checkBoxT_CheckedChanged);
            // 
            // checkBoxM0
            // 
            this.checkBoxM0.AutoSize = true;
            this.checkBoxM0.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxM0.Location = new System.Drawing.Point(13, 23);
            this.checkBoxM0.Name = "checkBoxM0";
            this.checkBoxM0.Size = new System.Drawing.Size(59, 23);
            this.checkBoxM0.TabIndex = 8;
            this.checkBoxM0.Text = "Mon";
            this.checkBoxM0.UseVisualStyleBackColor = true;
            this.checkBoxM0.CheckedChanged += new System.EventHandler(this.checkBoxM_CheckedChanged_1);
            // 
            // grouper1
            // 
            this.grouper1.BackgroundColor = System.Drawing.Color.White;
            this.grouper1.BackgroundGradientColor = System.Drawing.Color.White;
            this.grouper1.BackgroundGradientMode = CodeVendor.Controls.Grouper.GroupBoxGradientMode.None;
            this.grouper1.BorderColor = System.Drawing.Color.Black;
            this.grouper1.BorderThickness = 3F;
            this.grouper1.Controls.Add(this.numericUpDown1);
            this.grouper1.Controls.Add(this.numericUpDown2);
            this.grouper1.Controls.Add(this.label11);
            this.grouper1.CustomGroupBoxColor = System.Drawing.Color.White;
            this.grouper1.GroupImage = null;
            this.grouper1.GroupTitle = "Duration";
            this.grouper1.Location = new System.Drawing.Point(907, 353);
            this.grouper1.Name = "grouper1";
            this.grouper1.Padding = new System.Windows.Forms.Padding(20);
            this.grouper1.PaintGroupBox = false;
            this.grouper1.RoundCorners = 10;
            this.grouper1.ShadowColor = System.Drawing.Color.DarkGray;
            this.grouper1.ShadowControl = false;
            this.grouper1.ShadowThickness = 3;
            this.grouper1.Size = new System.Drawing.Size(164, 88);
            this.grouper1.TabIndex = 58;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.Location = new System.Drawing.Point(92, 26);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(59, 47);
            this.numericUpDown1.TabIndex = 8;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown2.Location = new System.Drawing.Point(15, 26);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(57, 47);
            this.numericUpDown2.TabIndex = 6;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(67, 28);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(26, 37);
            this.label11.TabIndex = 7;
            this.label11.Text = ":";
            // 
            // grouper2
            // 
            this.grouper2.BackgroundColor = System.Drawing.Color.White;
            this.grouper2.BackgroundGradientColor = System.Drawing.Color.White;
            this.grouper2.BackgroundGradientMode = CodeVendor.Controls.Grouper.GroupBoxGradientMode.None;
            this.grouper2.BorderColor = System.Drawing.Color.Black;
            this.grouper2.BorderThickness = 3F;
            this.grouper2.Controls.Add(this.numericUpDown4);
            this.grouper2.Controls.Add(this.numericUpDown5);
            this.grouper2.Controls.Add(this.label12);
            this.grouper2.CustomGroupBoxColor = System.Drawing.Color.White;
            this.grouper2.GroupImage = null;
            this.grouper2.GroupTitle = "Enable on Time";
            this.grouper2.Location = new System.Drawing.Point(743, 353);
            this.grouper2.Name = "grouper2";
            this.grouper2.Padding = new System.Windows.Forms.Padding(20);
            this.grouper2.PaintGroupBox = false;
            this.grouper2.RoundCorners = 10;
            this.grouper2.ShadowColor = System.Drawing.Color.DarkGray;
            this.grouper2.ShadowControl = false;
            this.grouper2.ShadowThickness = 3;
            this.grouper2.Size = new System.Drawing.Size(164, 88);
            this.grouper2.TabIndex = 56;
            // 
            // numericUpDown4
            // 
            this.numericUpDown4.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown4.Location = new System.Drawing.Point(92, 26);
            this.numericUpDown4.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numericUpDown4.Name = "numericUpDown4";
            this.numericUpDown4.Size = new System.Drawing.Size(59, 47);
            this.numericUpDown4.TabIndex = 8;
            // 
            // numericUpDown5
            // 
            this.numericUpDown5.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown5.Location = new System.Drawing.Point(15, 26);
            this.numericUpDown5.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.numericUpDown5.Name = "numericUpDown5";
            this.numericUpDown5.Size = new System.Drawing.Size(57, 47);
            this.numericUpDown5.TabIndex = 6;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(67, 28);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(26, 37);
            this.label12.TabIndex = 7;
            this.label12.Text = ":";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::WindowsFormsApplication8.Properties.Resources.calendar;
            this.pictureBox1.Location = new System.Drawing.Point(353, 378);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(55, 50);
            this.pictureBox1.TabIndex = 57;
            this.pictureBox1.TabStop = false;
            // 
            // grouper3
            // 
            this.grouper3.BackgroundColor = System.Drawing.Color.White;
            this.grouper3.BackgroundGradientColor = System.Drawing.Color.White;
            this.grouper3.BackgroundGradientMode = CodeVendor.Controls.Grouper.GroupBoxGradientMode.None;
            this.grouper3.BorderColor = System.Drawing.Color.Black;
            this.grouper3.BorderThickness = 3F;
            this.grouper3.Controls.Add(this.checkBox1);
            this.grouper3.Controls.Add(this.checkBox2);
            this.grouper3.Controls.Add(this.checkBox3);
            this.grouper3.Controls.Add(this.checkBox4);
            this.grouper3.Controls.Add(this.checkBox5);
            this.grouper3.Controls.Add(this.checkBox6);
            this.grouper3.Controls.Add(this.checkBox7);
            this.grouper3.CustomGroupBoxColor = System.Drawing.Color.White;
            this.grouper3.GroupImage = null;
            this.grouper3.GroupTitle = "Enable on Day";
            this.grouper3.Location = new System.Drawing.Point(414, 353);
            this.grouper3.Name = "grouper3";
            this.grouper3.Padding = new System.Windows.Forms.Padding(20);
            this.grouper3.PaintGroupBox = false;
            this.grouper3.RoundCorners = 10;
            this.grouper3.ShadowColor = System.Drawing.Color.DarkGray;
            this.grouper3.ShadowControl = false;
            this.grouper3.ShadowThickness = 3;
            this.grouper3.Size = new System.Drawing.Size(256, 88);
            this.grouper3.TabIndex = 55;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(201, 50);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(55, 23);
            this.checkBox1.TabIndex = 14;
            this.checkBox1.Text = "Sun";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox2.Location = new System.Drawing.Point(144, 50);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(51, 23);
            this.checkBox2.TabIndex = 13;
            this.checkBox2.Text = "Sat";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox3.Location = new System.Drawing.Point(78, 50);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(46, 23);
            this.checkBox3.TabIndex = 12;
            this.checkBox3.Text = "Fri";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox4.Location = new System.Drawing.Point(13, 50);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(61, 23);
            this.checkBox4.TabIndex = 11;
            this.checkBox4.Text = "Thur";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox5.Location = new System.Drawing.Point(144, 23);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(59, 23);
            this.checkBox5.TabIndex = 10;
            this.checkBox5.Text = "Wed";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox6.Location = new System.Drawing.Point(78, 23);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(60, 23);
            this.checkBox6.TabIndex = 9;
            this.checkBox6.Text = "Tues";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox7.Location = new System.Drawing.Point(13, 23);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(59, 23);
            this.checkBox7.TabIndex = 8;
            this.checkBox7.Text = "Mon";
            this.checkBox7.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::WindowsFormsApplication8.Resources.clock;
            this.pictureBox2.Image = global::WindowsFormsApplication8.Properties.Resources.clock_small;
            this.pictureBox2.Location = new System.Drawing.Point(687, 373);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 50);
            this.pictureBox2.TabIndex = 53;
            this.pictureBox2.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.numericUpDown7);
            this.groupBox4.Controls.Add(this.pictureBox6);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(1060, 353);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(190, 88);
            this.groupBox4.TabIndex = 54;
            this.groupBox4.TabStop = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(119, 25);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(45, 37);
            this.label13.TabIndex = 3;
            this.label13.Text = "%";
            // 
            // numericUpDown7
            // 
            this.numericUpDown7.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown7.Location = new System.Drawing.Point(73, 23);
            this.numericUpDown7.Name = "numericUpDown7";
            this.numericUpDown7.Size = new System.Drawing.Size(105, 47);
            this.numericUpDown7.TabIndex = 2;
            this.numericUpDown7.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackgroundImage = global::WindowsFormsApplication8.Resources.clock;
            this.pictureBox6.Image = global::WindowsFormsApplication8.Resources.battery_small;
            this.pictureBox6.Location = new System.Drawing.Point(15, 20);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(50, 50);
            this.pictureBox6.TabIndex = 1;
            this.pictureBox6.TabStop = false;
            // 
            // grouper4
            // 
            this.grouper4.BackgroundColor = System.Drawing.Color.White;
            this.grouper4.BackgroundGradientColor = System.Drawing.Color.White;
            this.grouper4.BackgroundGradientMode = CodeVendor.Controls.Grouper.GroupBoxGradientMode.None;
            this.grouper4.BorderColor = System.Drawing.Color.Black;
            this.grouper4.BorderThickness = 3F;
            this.grouper4.Controls.Add(this.numericUpDown8);
            this.grouper4.Controls.Add(this.numericUpDown9);
            this.grouper4.Controls.Add(this.label14);
            this.grouper4.CustomGroupBoxColor = System.Drawing.Color.White;
            this.grouper4.GroupImage = null;
            this.grouper4.GroupTitle = "Duration";
            this.grouper4.Location = new System.Drawing.Point(907, 445);
            this.grouper4.Name = "grouper4";
            this.grouper4.Padding = new System.Windows.Forms.Padding(20);
            this.grouper4.PaintGroupBox = false;
            this.grouper4.RoundCorners = 10;
            this.grouper4.ShadowColor = System.Drawing.Color.DarkGray;
            this.grouper4.ShadowControl = false;
            this.grouper4.ShadowThickness = 3;
            this.grouper4.Size = new System.Drawing.Size(164, 88);
            this.grouper4.TabIndex = 64;
            // 
            // numericUpDown8
            // 
            this.numericUpDown8.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown8.Location = new System.Drawing.Point(92, 26);
            this.numericUpDown8.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numericUpDown8.Name = "numericUpDown8";
            this.numericUpDown8.Size = new System.Drawing.Size(59, 47);
            this.numericUpDown8.TabIndex = 8;
            // 
            // numericUpDown9
            // 
            this.numericUpDown9.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown9.Location = new System.Drawing.Point(15, 26);
            this.numericUpDown9.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.numericUpDown9.Name = "numericUpDown9";
            this.numericUpDown9.Size = new System.Drawing.Size(57, 47);
            this.numericUpDown9.TabIndex = 6;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(67, 28);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(26, 37);
            this.label14.TabIndex = 7;
            this.label14.Text = ":";
            // 
            // grouper5
            // 
            this.grouper5.BackgroundColor = System.Drawing.Color.White;
            this.grouper5.BackgroundGradientColor = System.Drawing.Color.White;
            this.grouper5.BackgroundGradientMode = CodeVendor.Controls.Grouper.GroupBoxGradientMode.None;
            this.grouper5.BorderColor = System.Drawing.Color.Black;
            this.grouper5.BorderThickness = 3F;
            this.grouper5.Controls.Add(this.numericUpDown10);
            this.grouper5.Controls.Add(this.numericUpDown11);
            this.grouper5.Controls.Add(this.label15);
            this.grouper5.CustomGroupBoxColor = System.Drawing.Color.White;
            this.grouper5.GroupImage = null;
            this.grouper5.GroupTitle = "Enable on Time";
            this.grouper5.Location = new System.Drawing.Point(743, 445);
            this.grouper5.Name = "grouper5";
            this.grouper5.Padding = new System.Windows.Forms.Padding(20);
            this.grouper5.PaintGroupBox = false;
            this.grouper5.RoundCorners = 10;
            this.grouper5.ShadowColor = System.Drawing.Color.DarkGray;
            this.grouper5.ShadowControl = false;
            this.grouper5.ShadowThickness = 3;
            this.grouper5.Size = new System.Drawing.Size(164, 88);
            this.grouper5.TabIndex = 62;
            // 
            // numericUpDown10
            // 
            this.numericUpDown10.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown10.Location = new System.Drawing.Point(92, 26);
            this.numericUpDown10.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numericUpDown10.Name = "numericUpDown10";
            this.numericUpDown10.Size = new System.Drawing.Size(59, 47);
            this.numericUpDown10.TabIndex = 8;
            // 
            // numericUpDown11
            // 
            this.numericUpDown11.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown11.Location = new System.Drawing.Point(15, 26);
            this.numericUpDown11.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.numericUpDown11.Name = "numericUpDown11";
            this.numericUpDown11.Size = new System.Drawing.Size(57, 47);
            this.numericUpDown11.TabIndex = 6;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(67, 28);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(26, 37);
            this.label15.TabIndex = 7;
            this.label15.Text = ":";
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackgroundImage = global::WindowsFormsApplication8.Properties.Resources.calendar;
            this.pictureBox7.Location = new System.Drawing.Point(353, 470);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(55, 50);
            this.pictureBox7.TabIndex = 63;
            this.pictureBox7.TabStop = false;
            // 
            // grouper6
            // 
            this.grouper6.BackgroundColor = System.Drawing.Color.White;
            this.grouper6.BackgroundGradientColor = System.Drawing.Color.White;
            this.grouper6.BackgroundGradientMode = CodeVendor.Controls.Grouper.GroupBoxGradientMode.None;
            this.grouper6.BorderColor = System.Drawing.Color.Black;
            this.grouper6.BorderThickness = 3F;
            this.grouper6.Controls.Add(this.checkBox8);
            this.grouper6.Controls.Add(this.checkBox9);
            this.grouper6.Controls.Add(this.checkBox10);
            this.grouper6.Controls.Add(this.checkBox11);
            this.grouper6.Controls.Add(this.checkBox12);
            this.grouper6.Controls.Add(this.checkBox13);
            this.grouper6.Controls.Add(this.checkBox14);
            this.grouper6.CustomGroupBoxColor = System.Drawing.Color.White;
            this.grouper6.GroupImage = null;
            this.grouper6.GroupTitle = "Enable on Day";
            this.grouper6.Location = new System.Drawing.Point(414, 445);
            this.grouper6.Name = "grouper6";
            this.grouper6.Padding = new System.Windows.Forms.Padding(20);
            this.grouper6.PaintGroupBox = false;
            this.grouper6.RoundCorners = 10;
            this.grouper6.ShadowColor = System.Drawing.Color.DarkGray;
            this.grouper6.ShadowControl = false;
            this.grouper6.ShadowThickness = 3;
            this.grouper6.Size = new System.Drawing.Size(256, 88);
            this.grouper6.TabIndex = 61;
            // 
            // checkBox8
            // 
            this.checkBox8.AutoSize = true;
            this.checkBox8.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox8.Location = new System.Drawing.Point(201, 50);
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.Size = new System.Drawing.Size(55, 23);
            this.checkBox8.TabIndex = 14;
            this.checkBox8.Text = "Sun";
            this.checkBox8.UseVisualStyleBackColor = true;
            // 
            // checkBox9
            // 
            this.checkBox9.AutoSize = true;
            this.checkBox9.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox9.Location = new System.Drawing.Point(144, 50);
            this.checkBox9.Name = "checkBox9";
            this.checkBox9.Size = new System.Drawing.Size(51, 23);
            this.checkBox9.TabIndex = 13;
            this.checkBox9.Text = "Sat";
            this.checkBox9.UseVisualStyleBackColor = true;
            // 
            // checkBox10
            // 
            this.checkBox10.AutoSize = true;
            this.checkBox10.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox10.Location = new System.Drawing.Point(78, 50);
            this.checkBox10.Name = "checkBox10";
            this.checkBox10.Size = new System.Drawing.Size(46, 23);
            this.checkBox10.TabIndex = 12;
            this.checkBox10.Text = "Fri";
            this.checkBox10.UseVisualStyleBackColor = true;
            // 
            // checkBox11
            // 
            this.checkBox11.AutoSize = true;
            this.checkBox11.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox11.Location = new System.Drawing.Point(13, 50);
            this.checkBox11.Name = "checkBox11";
            this.checkBox11.Size = new System.Drawing.Size(61, 23);
            this.checkBox11.TabIndex = 11;
            this.checkBox11.Text = "Thur";
            this.checkBox11.UseVisualStyleBackColor = true;
            // 
            // checkBox12
            // 
            this.checkBox12.AutoSize = true;
            this.checkBox12.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox12.Location = new System.Drawing.Point(144, 23);
            this.checkBox12.Name = "checkBox12";
            this.checkBox12.Size = new System.Drawing.Size(59, 23);
            this.checkBox12.TabIndex = 10;
            this.checkBox12.Text = "Wed";
            this.checkBox12.UseVisualStyleBackColor = true;
            // 
            // checkBox13
            // 
            this.checkBox13.AutoSize = true;
            this.checkBox13.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox13.Location = new System.Drawing.Point(78, 23);
            this.checkBox13.Name = "checkBox13";
            this.checkBox13.Size = new System.Drawing.Size(60, 23);
            this.checkBox13.TabIndex = 9;
            this.checkBox13.Text = "Tues";
            this.checkBox13.UseVisualStyleBackColor = true;
            // 
            // checkBox14
            // 
            this.checkBox14.AutoSize = true;
            this.checkBox14.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox14.Location = new System.Drawing.Point(13, 23);
            this.checkBox14.Name = "checkBox14";
            this.checkBox14.Size = new System.Drawing.Size(59, 23);
            this.checkBox14.TabIndex = 8;
            this.checkBox14.Text = "Mon";
            this.checkBox14.UseVisualStyleBackColor = true;
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackgroundImage = global::WindowsFormsApplication8.Resources.clock;
            this.pictureBox8.Image = global::WindowsFormsApplication8.Properties.Resources.clock_small;
            this.pictureBox8.Location = new System.Drawing.Point(687, 465);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(50, 50);
            this.pictureBox8.TabIndex = 59;
            this.pictureBox8.TabStop = false;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label16);
            this.groupBox5.Controls.Add(this.numericUpDown12);
            this.groupBox5.Controls.Add(this.pictureBox9);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(1060, 445);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(190, 88);
            this.groupBox5.TabIndex = 60;
            this.groupBox5.TabStop = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(119, 25);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(45, 37);
            this.label16.TabIndex = 3;
            this.label16.Text = "%";
            // 
            // numericUpDown12
            // 
            this.numericUpDown12.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown12.Location = new System.Drawing.Point(73, 23);
            this.numericUpDown12.Name = "numericUpDown12";
            this.numericUpDown12.Size = new System.Drawing.Size(105, 47);
            this.numericUpDown12.TabIndex = 2;
            this.numericUpDown12.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // pictureBox9
            // 
            this.pictureBox9.BackgroundImage = global::WindowsFormsApplication8.Resources.clock;
            this.pictureBox9.Image = global::WindowsFormsApplication8.Resources.battery_small;
            this.pictureBox9.Location = new System.Drawing.Point(15, 20);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(50, 50);
            this.pictureBox9.TabIndex = 1;
            this.pictureBox9.TabStop = false;
            // 
            // grouper7
            // 
            this.grouper7.BackgroundColor = System.Drawing.Color.White;
            this.grouper7.BackgroundGradientColor = System.Drawing.Color.White;
            this.grouper7.BackgroundGradientMode = CodeVendor.Controls.Grouper.GroupBoxGradientMode.None;
            this.grouper7.BorderColor = System.Drawing.Color.Black;
            this.grouper7.BorderThickness = 3F;
            this.grouper7.Controls.Add(this.numericUpDown13);
            this.grouper7.Controls.Add(this.numericUpDown14);
            this.grouper7.Controls.Add(this.label17);
            this.grouper7.CustomGroupBoxColor = System.Drawing.Color.White;
            this.grouper7.GroupImage = null;
            this.grouper7.GroupTitle = "Duration";
            this.grouper7.Location = new System.Drawing.Point(907, 541);
            this.grouper7.Name = "grouper7";
            this.grouper7.Padding = new System.Windows.Forms.Padding(20);
            this.grouper7.PaintGroupBox = false;
            this.grouper7.RoundCorners = 10;
            this.grouper7.ShadowColor = System.Drawing.Color.DarkGray;
            this.grouper7.ShadowControl = false;
            this.grouper7.ShadowThickness = 3;
            this.grouper7.Size = new System.Drawing.Size(164, 88);
            this.grouper7.TabIndex = 70;
            // 
            // numericUpDown13
            // 
            this.numericUpDown13.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown13.Location = new System.Drawing.Point(92, 26);
            this.numericUpDown13.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numericUpDown13.Name = "numericUpDown13";
            this.numericUpDown13.Size = new System.Drawing.Size(59, 47);
            this.numericUpDown13.TabIndex = 8;
            // 
            // numericUpDown14
            // 
            this.numericUpDown14.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown14.Location = new System.Drawing.Point(15, 26);
            this.numericUpDown14.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.numericUpDown14.Name = "numericUpDown14";
            this.numericUpDown14.Size = new System.Drawing.Size(57, 47);
            this.numericUpDown14.TabIndex = 6;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(67, 28);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(26, 37);
            this.label17.TabIndex = 7;
            this.label17.Text = ":";
            // 
            // grouper8
            // 
            this.grouper8.BackgroundColor = System.Drawing.Color.White;
            this.grouper8.BackgroundGradientColor = System.Drawing.Color.White;
            this.grouper8.BackgroundGradientMode = CodeVendor.Controls.Grouper.GroupBoxGradientMode.None;
            this.grouper8.BorderColor = System.Drawing.Color.Black;
            this.grouper8.BorderThickness = 3F;
            this.grouper8.Controls.Add(this.numericUpDown15);
            this.grouper8.Controls.Add(this.numericUpDown16);
            this.grouper8.Controls.Add(this.label18);
            this.grouper8.CustomGroupBoxColor = System.Drawing.Color.White;
            this.grouper8.GroupImage = null;
            this.grouper8.GroupTitle = "Enable on Time";
            this.grouper8.Location = new System.Drawing.Point(743, 541);
            this.grouper8.Name = "grouper8";
            this.grouper8.Padding = new System.Windows.Forms.Padding(20);
            this.grouper8.PaintGroupBox = false;
            this.grouper8.RoundCorners = 10;
            this.grouper8.ShadowColor = System.Drawing.Color.DarkGray;
            this.grouper8.ShadowControl = false;
            this.grouper8.ShadowThickness = 3;
            this.grouper8.Size = new System.Drawing.Size(164, 88);
            this.grouper8.TabIndex = 68;
            // 
            // numericUpDown15
            // 
            this.numericUpDown15.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown15.Location = new System.Drawing.Point(92, 26);
            this.numericUpDown15.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numericUpDown15.Name = "numericUpDown15";
            this.numericUpDown15.Size = new System.Drawing.Size(59, 47);
            this.numericUpDown15.TabIndex = 8;
            // 
            // numericUpDown16
            // 
            this.numericUpDown16.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown16.Location = new System.Drawing.Point(15, 26);
            this.numericUpDown16.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.numericUpDown16.Name = "numericUpDown16";
            this.numericUpDown16.Size = new System.Drawing.Size(57, 47);
            this.numericUpDown16.TabIndex = 6;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(67, 28);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(26, 37);
            this.label18.TabIndex = 7;
            this.label18.Text = ":";
            // 
            // pictureBox10
            // 
            this.pictureBox10.BackgroundImage = global::WindowsFormsApplication8.Properties.Resources.calendar;
            this.pictureBox10.Location = new System.Drawing.Point(353, 566);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(55, 50);
            this.pictureBox10.TabIndex = 69;
            this.pictureBox10.TabStop = false;
            // 
            // grouper9
            // 
            this.grouper9.BackgroundColor = System.Drawing.Color.White;
            this.grouper9.BackgroundGradientColor = System.Drawing.Color.White;
            this.grouper9.BackgroundGradientMode = CodeVendor.Controls.Grouper.GroupBoxGradientMode.None;
            this.grouper9.BorderColor = System.Drawing.Color.Black;
            this.grouper9.BorderThickness = 3F;
            this.grouper9.Controls.Add(this.checkBox15);
            this.grouper9.Controls.Add(this.checkBox16);
            this.grouper9.Controls.Add(this.checkBox17);
            this.grouper9.Controls.Add(this.checkBox18);
            this.grouper9.Controls.Add(this.checkBox19);
            this.grouper9.Controls.Add(this.checkBox20);
            this.grouper9.Controls.Add(this.checkBox21);
            this.grouper9.CustomGroupBoxColor = System.Drawing.Color.White;
            this.grouper9.GroupImage = null;
            this.grouper9.GroupTitle = "Enable on Day";
            this.grouper9.Location = new System.Drawing.Point(414, 541);
            this.grouper9.Name = "grouper9";
            this.grouper9.Padding = new System.Windows.Forms.Padding(20);
            this.grouper9.PaintGroupBox = false;
            this.grouper9.RoundCorners = 10;
            this.grouper9.ShadowColor = System.Drawing.Color.DarkGray;
            this.grouper9.ShadowControl = false;
            this.grouper9.ShadowThickness = 3;
            this.grouper9.Size = new System.Drawing.Size(256, 88);
            this.grouper9.TabIndex = 67;
            // 
            // checkBox15
            // 
            this.checkBox15.AutoSize = true;
            this.checkBox15.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox15.Location = new System.Drawing.Point(201, 50);
            this.checkBox15.Name = "checkBox15";
            this.checkBox15.Size = new System.Drawing.Size(55, 23);
            this.checkBox15.TabIndex = 14;
            this.checkBox15.Text = "Sun";
            this.checkBox15.UseVisualStyleBackColor = true;
            // 
            // checkBox16
            // 
            this.checkBox16.AutoSize = true;
            this.checkBox16.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox16.Location = new System.Drawing.Point(144, 50);
            this.checkBox16.Name = "checkBox16";
            this.checkBox16.Size = new System.Drawing.Size(51, 23);
            this.checkBox16.TabIndex = 13;
            this.checkBox16.Text = "Sat";
            this.checkBox16.UseVisualStyleBackColor = true;
            // 
            // checkBox17
            // 
            this.checkBox17.AutoSize = true;
            this.checkBox17.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox17.Location = new System.Drawing.Point(78, 50);
            this.checkBox17.Name = "checkBox17";
            this.checkBox17.Size = new System.Drawing.Size(46, 23);
            this.checkBox17.TabIndex = 12;
            this.checkBox17.Text = "Fri";
            this.checkBox17.UseVisualStyleBackColor = true;
            // 
            // checkBox18
            // 
            this.checkBox18.AutoSize = true;
            this.checkBox18.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox18.Location = new System.Drawing.Point(13, 50);
            this.checkBox18.Name = "checkBox18";
            this.checkBox18.Size = new System.Drawing.Size(61, 23);
            this.checkBox18.TabIndex = 11;
            this.checkBox18.Text = "Thur";
            this.checkBox18.UseVisualStyleBackColor = true;
            // 
            // checkBox19
            // 
            this.checkBox19.AutoSize = true;
            this.checkBox19.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox19.Location = new System.Drawing.Point(144, 23);
            this.checkBox19.Name = "checkBox19";
            this.checkBox19.Size = new System.Drawing.Size(59, 23);
            this.checkBox19.TabIndex = 10;
            this.checkBox19.Text = "Wed";
            this.checkBox19.UseVisualStyleBackColor = true;
            // 
            // checkBox20
            // 
            this.checkBox20.AutoSize = true;
            this.checkBox20.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox20.Location = new System.Drawing.Point(78, 23);
            this.checkBox20.Name = "checkBox20";
            this.checkBox20.Size = new System.Drawing.Size(60, 23);
            this.checkBox20.TabIndex = 9;
            this.checkBox20.Text = "Tues";
            this.checkBox20.UseVisualStyleBackColor = true;
            // 
            // checkBox21
            // 
            this.checkBox21.AutoSize = true;
            this.checkBox21.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox21.Location = new System.Drawing.Point(13, 23);
            this.checkBox21.Name = "checkBox21";
            this.checkBox21.Size = new System.Drawing.Size(59, 23);
            this.checkBox21.TabIndex = 8;
            this.checkBox21.Text = "Mon";
            this.checkBox21.UseVisualStyleBackColor = true;
            // 
            // pictureBox11
            // 
            this.pictureBox11.BackgroundImage = global::WindowsFormsApplication8.Resources.clock;
            this.pictureBox11.Image = global::WindowsFormsApplication8.Properties.Resources.clock_small;
            this.pictureBox11.Location = new System.Drawing.Point(687, 561);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(50, 50);
            this.pictureBox11.TabIndex = 65;
            this.pictureBox11.TabStop = false;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label19);
            this.groupBox6.Controls.Add(this.numericUpDown17);
            this.groupBox6.Controls.Add(this.pictureBox12);
            this.groupBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.Location = new System.Drawing.Point(1060, 541);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(190, 88);
            this.groupBox6.TabIndex = 66;
            this.groupBox6.TabStop = false;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(119, 25);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(45, 37);
            this.label19.TabIndex = 3;
            this.label19.Text = "%";
            // 
            // numericUpDown17
            // 
            this.numericUpDown17.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown17.Location = new System.Drawing.Point(73, 23);
            this.numericUpDown17.Name = "numericUpDown17";
            this.numericUpDown17.Size = new System.Drawing.Size(105, 47);
            this.numericUpDown17.TabIndex = 2;
            this.numericUpDown17.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // pictureBox12
            // 
            this.pictureBox12.BackgroundImage = global::WindowsFormsApplication8.Resources.clock;
            this.pictureBox12.Image = global::WindowsFormsApplication8.Resources.battery_small;
            this.pictureBox12.Location = new System.Drawing.Point(15, 20);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(50, 50);
            this.pictureBox12.TabIndex = 1;
            this.pictureBox12.TabStop = false;
            // 
            // Main
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1264, 730);
            this.Controls.Add(this.grouper7);
            this.Controls.Add(this.grouper8);
            this.Controls.Add(this.pictureBox10);
            this.Controls.Add(this.grouper9);
            this.Controls.Add(this.pictureBox11);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.grouper4);
            this.Controls.Add(this.grouper5);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.grouper6);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.grouper1);
            this.Controls.Add(this.grouper2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.grouper3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.grouperDuration2);
            this.Controls.Add(this.grouperTime2);
            this.Controls.Add(this.pictureBoxSchedule2);
            this.Controls.Add(this.grouperDay2);
            this.Controls.Add(this.pictureBoxClock2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.grouperDuration1);
            this.Controls.Add(this.grouperTime1);
            this.Controls.Add(this.pictureBoxSchedule1);
            this.Controls.Add(this.grouperDay1);
            this.Controls.Add(this.pictureBoxClock1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listBoxEvents);
            this.Controls.Add(this.comboBoxComm);
            this.Controls.Add(this.grouperDuration0);
            this.Controls.Add(this.grouperTime0);
            this.Controls.Add(this.pictureBoxSchedule0);
            this.Controls.Add(this.grouperDay0);
            this.Controls.Add(this.pictureBoxClock0);
            this.Controls.Add(this.textBoxConditionsMet5);
            this.Controls.Add(this.textBoxConditionsMet4);
            this.Controls.Add(this.textBoxConditionsMet3);
            this.Controls.Add(this.textBoxConditionsMet2);
            this.Controls.Add(this.textBoxConditionsMet1);
            this.Controls.Add(this.textBoxConditionsMet0);
            this.Controls.Add(this.textBoxOn5);
            this.Controls.Add(this.textBoxForce5);
            this.Controls.Add(this.textBoxForce4);
            this.Controls.Add(this.textBoxForce3);
            this.Controls.Add(this.textBoxForce2);
            this.Controls.Add(this.textBoxForce1);
            this.Controls.Add(this.textBoxForce0);
            this.Controls.Add(this.textBoxOn4);
            this.Controls.Add(this.textBoxOn3);
            this.Controls.Add(this.textBoxOn2);
            this.Controls.Add(this.textBoxOn1);
            this.Controls.Add(this.textBoxOn0);
            this.Controls.Add(this.switchForce5);
            this.Controls.Add(this.switchForce4);
            this.Controls.Add(this.switchForce3);
            this.Controls.Add(this.switchForce2);
            this.Controls.Add(this.switchForce1);
            this.Controls.Add(this.switchForce0);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.onOff5);
            this.Controls.Add(this.onOff4);
            this.Controls.Add(this.onOff3);
            this.Controls.Add(this.onOff2);
            this.Controls.Add(this.onOff1);
            this.Controls.Add(this.onOff0);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxConnectionStatus);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.MinimumSize = new System.Drawing.Size(1280, 726);
            this.Name = "Main";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Home Automation";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.serialConn1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClock0)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.batteryPower1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.switchForce5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.switchForce4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.switchForce3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.switchForce2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.switchForce1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.switchForce0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.onOff5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.onOff4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.onOff3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.onOff2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.onOff1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.onOff0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSchedule0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSchedule1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClock1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSchedule2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClock2)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.grouperDuration2.ResumeLayout(false);
            this.grouperDuration2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericDurationMinute2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericDurationHour2)).EndInit();
            this.grouperTime2.ResumeLayout(false);
            this.grouperTime2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericTimeMinute2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericTimeHour2)).EndInit();
            this.grouperDay2.ResumeLayout(false);
            this.grouperDay2.PerformLayout();
            this.grouperDuration1.ResumeLayout(false);
            this.grouperDuration1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericDurationMinute1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericDurationHour1)).EndInit();
            this.grouperTime1.ResumeLayout(false);
            this.grouperTime1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericTimeMinute1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericTimeHour1)).EndInit();
            this.grouperDay1.ResumeLayout(false);
            this.grouperDay1.PerformLayout();
            this.grouperDuration0.ResumeLayout(false);
            this.grouperDuration0.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericDurationMinute0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericDurationHour0)).EndInit();
            this.grouperTime0.ResumeLayout(false);
            this.grouperTime0.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericTimeMinute0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericTimeHour0)).EndInit();
            this.grouperDay0.ResumeLayout(false);
            this.grouperDay0.PerformLayout();
            this.grouper1.ResumeLayout(false);
            this.grouper1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.grouper2.ResumeLayout(false);
            this.grouper2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grouper3.ResumeLayout(false);
            this.grouper3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.grouper4.ResumeLayout(false);
            this.grouper4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown9)).EndInit();
            this.grouper5.ResumeLayout(false);
            this.grouper5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.grouper6.ResumeLayout(false);
            this.grouper6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            this.grouper7.ResumeLayout(false);
            this.grouper7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown14)).EndInit();
            this.grouper8.ResumeLayout(false);
            this.grouper8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            this.grouper9.ResumeLayout(false);
            this.grouper9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox onOff0;
        private System.Windows.Forms.PictureBox onOff1;
        private System.Windows.Forms.PictureBox onOff2;
        private System.Windows.Forms.PictureBox onOff3;
        private System.Windows.Forms.PictureBox onOff4;
        private System.Windows.Forms.PictureBox onOff5;
        private AdvancedHMIDrivers.SerialDF1forSLCMicroCom serialConn1;
        private System.Windows.Forms.Timer commTimer;
        private System.Windows.Forms.PictureBox pictureBoxClock0;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox switchForce0;
        private System.Windows.Forms.PictureBox switchForce1;
        private System.Windows.Forms.PictureBox switchForce2;
        private System.Windows.Forms.PictureBox switchForce3;
        private System.Windows.Forms.PictureBox switchForce4;
        private System.Windows.Forms.PictureBox switchForce5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown batteryPower1;
        private System.Windows.Forms.TextBox textBoxOn0;
        private System.Windows.Forms.TextBox textBoxOn1;
        private System.Windows.Forms.TextBox textBoxOn2;
        private System.Windows.Forms.TextBox textBoxOn3;
        private System.Windows.Forms.TextBox textBoxOn4;
        private System.Windows.Forms.TextBox textBoxForce4;
        private System.Windows.Forms.TextBox textBoxForce3;
        private System.Windows.Forms.TextBox textBoxForce2;
        private System.Windows.Forms.TextBox textBoxForce1;
        private System.Windows.Forms.TextBox textBoxForce0;
        private System.Windows.Forms.TextBox textBoxForce5;
        private System.Windows.Forms.TextBox textBoxOn5;
        private System.Windows.Forms.TextBox textBoxConditionsMet5;
        private System.Windows.Forms.TextBox textBoxConditionsMet4;
        private System.Windows.Forms.TextBox textBoxConditionsMet3;
        private System.Windows.Forms.TextBox textBoxConditionsMet2;
        private System.Windows.Forms.TextBox textBoxConditionsMet1;
        private System.Windows.Forms.TextBox textBoxConditionsMet0;
        private System.Windows.Forms.Timer imgTimer;
        private CodeVendor.Controls.Grouper grouperDay0;
        private System.Windows.Forms.CheckBox checkBoxSu0;
        private System.Windows.Forms.CheckBox checkBoxS0;
        private System.Windows.Forms.CheckBox checkBoxF0;
        private System.Windows.Forms.CheckBox checkBoxR0;
        private System.Windows.Forms.CheckBox checkBoxW0;
        private System.Windows.Forms.CheckBox checkBoxT0;
        private System.Windows.Forms.CheckBox checkBoxM0;
        private System.Windows.Forms.PictureBox pictureBoxSchedule0;
        private CodeVendor.Controls.Grouper grouperTime0;
        private System.Windows.Forms.NumericUpDown numericTimeMinute0;
        private System.Windows.Forms.NumericUpDown numericTimeHour0;
        private System.Windows.Forms.Label label3;
        private CodeVendor.Controls.Grouper grouperDuration0;
        private System.Windows.Forms.NumericUpDown numericDurationMinute0;
        private System.Windows.Forms.NumericUpDown numericDurationHour0;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxConnectionStatus;
        private System.Windows.Forms.ComboBox comboBoxComm;
        private System.Windows.Forms.ListBox listBoxEvents;
        private CodeVendor.Controls.Grouper grouperTime1;
        private System.Windows.Forms.NumericUpDown numericTimeMinute1;
        private System.Windows.Forms.NumericUpDown numericTimeHour1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBoxSchedule1;
        private CodeVendor.Controls.Grouper grouperDay1;
        private System.Windows.Forms.CheckBox checkBoxSu1;
        private System.Windows.Forms.CheckBox checkBoxS1;
        private System.Windows.Forms.CheckBox checkBoxF1;
        private System.Windows.Forms.CheckBox checkBoxR1;
        private System.Windows.Forms.CheckBox checkBoxW1;
        private System.Windows.Forms.CheckBox checkBoxT1;
        private System.Windows.Forms.CheckBox checkBoxM1;
        private System.Windows.Forms.PictureBox pictureBoxClock1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private CodeVendor.Controls.Grouper grouperDuration1;
        private System.Windows.Forms.NumericUpDown numericDurationMinute1;
        private System.Windows.Forms.NumericUpDown numericDurationHour1;
        private System.Windows.Forms.Label label7;
        private CodeVendor.Controls.Grouper grouperDuration2;
        private System.Windows.Forms.NumericUpDown numericDurationMinute2;
        private System.Windows.Forms.NumericUpDown numericDurationHour2;
        private System.Windows.Forms.Label label8;
        private CodeVendor.Controls.Grouper grouperTime2;
        private System.Windows.Forms.NumericUpDown numericTimeMinute2;
        private System.Windows.Forms.NumericUpDown numericTimeHour2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBoxSchedule2;
        private CodeVendor.Controls.Grouper grouperDay2;
        private System.Windows.Forms.CheckBox checkBoxSu2;
        private System.Windows.Forms.CheckBox checkBoxS2;
        private System.Windows.Forms.CheckBox checkBoxF2;
        private System.Windows.Forms.CheckBox checkBoxR2;
        private System.Windows.Forms.CheckBox checkBoxW2;
        private System.Windows.Forms.CheckBox checkBoxT2;
        private System.Windows.Forms.CheckBox checkBoxM2;
        private System.Windows.Forms.PictureBox pictureBoxClock2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown numericUpDown6;
        private System.Windows.Forms.PictureBox pictureBox5;
        private CodeVendor.Controls.Grouper grouper1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label label11;
        private CodeVendor.Controls.Grouper grouper2;
        private System.Windows.Forms.NumericUpDown numericUpDown4;
        private System.Windows.Forms.NumericUpDown numericUpDown5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.PictureBox pictureBox1;
        private CodeVendor.Controls.Grouper grouper3;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown numericUpDown7;
        private System.Windows.Forms.PictureBox pictureBox6;
        private CodeVendor.Controls.Grouper grouper4;
        private System.Windows.Forms.NumericUpDown numericUpDown8;
        private System.Windows.Forms.NumericUpDown numericUpDown9;
        private System.Windows.Forms.Label label14;
        private CodeVendor.Controls.Grouper grouper5;
        private System.Windows.Forms.NumericUpDown numericUpDown10;
        private System.Windows.Forms.NumericUpDown numericUpDown11;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.PictureBox pictureBox7;
        private CodeVendor.Controls.Grouper grouper6;
        private System.Windows.Forms.CheckBox checkBox8;
        private System.Windows.Forms.CheckBox checkBox9;
        private System.Windows.Forms.CheckBox checkBox10;
        private System.Windows.Forms.CheckBox checkBox11;
        private System.Windows.Forms.CheckBox checkBox12;
        private System.Windows.Forms.CheckBox checkBox13;
        private System.Windows.Forms.CheckBox checkBox14;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.NumericUpDown numericUpDown12;
        private System.Windows.Forms.PictureBox pictureBox9;
        private CodeVendor.Controls.Grouper grouper7;
        private System.Windows.Forms.NumericUpDown numericUpDown13;
        private System.Windows.Forms.NumericUpDown numericUpDown14;
        private System.Windows.Forms.Label label17;
        private CodeVendor.Controls.Grouper grouper8;
        private System.Windows.Forms.NumericUpDown numericUpDown15;
        private System.Windows.Forms.NumericUpDown numericUpDown16;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.PictureBox pictureBox10;
        private CodeVendor.Controls.Grouper grouper9;
        private System.Windows.Forms.CheckBox checkBox15;
        private System.Windows.Forms.CheckBox checkBox16;
        private System.Windows.Forms.CheckBox checkBox17;
        private System.Windows.Forms.CheckBox checkBox18;
        private System.Windows.Forms.CheckBox checkBox19;
        private System.Windows.Forms.CheckBox checkBox20;
        private System.Windows.Forms.CheckBox checkBox21;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.NumericUpDown numericUpDown17;
        private System.Windows.Forms.PictureBox pictureBox12;
    }
}


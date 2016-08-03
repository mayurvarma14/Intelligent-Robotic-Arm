namespace Robotic_Arm
{
    partial class Programming
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.zaxisValue = new System.Windows.Forms.TextBox();
            this.yaxisValue = new System.Windows.Forms.TextBox();
            this.xaxisValue = new System.Windows.Forms.TextBox();
            this.zaxis = new System.Windows.Forms.TrackBar();
            this.yaxis = new System.Windows.Forms.TrackBar();
            this.xaxis = new System.Windows.Forms.TrackBar();
            this.status = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.displayBox = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.servoValue1 = new System.Windows.Forms.TextBox();
            this.servoValue6 = new System.Windows.Forms.TextBox();
            this.servoValue2 = new System.Windows.Forms.TextBox();
            this.servoValue3 = new System.Windows.Forms.TextBox();
            this.servoValue4 = new System.Windows.Forms.TextBox();
            this.servoValue5 = new System.Windows.Forms.TextBox();
            this.l6 = new System.Windows.Forms.Label();
            this.servo1 = new System.Windows.Forms.TrackBar();
            this.l5 = new System.Windows.Forms.Label();
            this.servo6 = new System.Windows.Forms.TrackBar();
            this.l4 = new System.Windows.Forms.Label();
            this.servo2 = new System.Windows.Forms.TrackBar();
            this.l3 = new System.Windows.Forms.Label();
            this.servo3 = new System.Windows.Forms.TrackBar();
            this.l2 = new System.Windows.Forms.Label();
            this.servo4 = new System.Windows.Forms.TrackBar();
            this.l1 = new System.Windows.Forms.Label();
            this.servo5 = new System.Windows.Forms.TrackBar();
            this.panel3 = new System.Windows.Forms.Panel();
            this.load = new System.Windows.Forms.Button();
            this.fileName = new System.Windows.Forms.TextBox();
            this.save = new System.Windows.Forms.Button();
            this.sequence = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.delayAmount = new System.Windows.Forms.TextBox();
            this.home = new System.Windows.Forms.Button();
            this.place = new System.Windows.Forms.Button();
            this.run = new System.Windows.Forms.Button();
            this.reset = new System.Windows.Forms.Button();
            this.pick = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.copy = new System.Windows.Forms.Button();
            this.paste = new System.Windows.Forms.Button();
            this.clearAll = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.usb = new System.IO.Ports.SerialPort(this.components);
            this.comState = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zaxis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yaxis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xaxis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.displayBox)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.servo1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.servo6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.servo2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.servo3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.servo4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.servo5)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(230)))), ((int)(((byte)(44)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.zaxisValue);
            this.panel1.Controls.Add(this.yaxisValue);
            this.panel1.Controls.Add(this.xaxisValue);
            this.panel1.Controls.Add(this.zaxis);
            this.panel1.Controls.Add(this.yaxis);
            this.panel1.Controls.Add(this.xaxis);
            this.panel1.Controls.Add(this.status);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(880, 380);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 280);
            this.panel1.TabIndex = 0;
            // 
            // zaxisValue
            // 
            this.zaxisValue.Location = new System.Drawing.Point(240, 140);
            this.zaxisValue.Name = "zaxisValue";
            this.zaxisValue.Size = new System.Drawing.Size(40, 39);
            this.zaxisValue.TabIndex = 2;
            this.zaxisValue.Text = "0";
            // 
            // yaxisValue
            // 
            this.yaxisValue.Location = new System.Drawing.Point(240, 80);
            this.yaxisValue.Name = "yaxisValue";
            this.yaxisValue.Size = new System.Drawing.Size(40, 39);
            this.yaxisValue.TabIndex = 2;
            this.yaxisValue.Text = "15";
            // 
            // xaxisValue
            // 
            this.xaxisValue.Location = new System.Drawing.Point(240, 20);
            this.xaxisValue.Name = "xaxisValue";
            this.xaxisValue.Size = new System.Drawing.Size(40, 39);
            this.xaxisValue.TabIndex = 2;
            this.xaxisValue.Text = "15";
            // 
            // zaxis
            // 
            this.zaxis.LargeChange = 1;
            this.zaxis.Location = new System.Drawing.Point(60, 140);
            this.zaxis.Maximum = 26;
            this.zaxis.Minimum = -26;
            this.zaxis.Name = "zaxis";
            this.zaxis.Size = new System.Drawing.Size(180, 45);
            this.zaxis.TabIndex = 1;
            this.zaxis.Scroll += new System.EventHandler(this.zaxis_Scroll);
            // 
            // yaxis
            // 
            this.yaxis.LargeChange = 1;
            this.yaxis.Location = new System.Drawing.Point(60, 80);
            this.yaxis.Maximum = 26;
            this.yaxis.Name = "yaxis";
            this.yaxis.Size = new System.Drawing.Size(180, 45);
            this.yaxis.TabIndex = 1;
            this.yaxis.Value = 15;
            this.yaxis.Scroll += new System.EventHandler(this.yaxis_Scroll);
            // 
            // xaxis
            // 
            this.xaxis.LargeChange = 1;
            this.xaxis.Location = new System.Drawing.Point(60, 20);
            this.xaxis.Maximum = 26;
            this.xaxis.Name = "xaxis";
            this.xaxis.Size = new System.Drawing.Size(180, 45);
            this.xaxis.TabIndex = 1;
            this.xaxis.Value = 15;
            this.xaxis.Scroll += new System.EventHandler(this.xaxis_Scroll);
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.Font = new System.Drawing.Font("Adobe Gothic Std B", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status.ForeColor = System.Drawing.Color.Maroon;
            this.status.Location = new System.Drawing.Point(120, 220);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(63, 24);
            this.status.TabIndex = 2;
            this.status.Text = "Status";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkBlue;
            this.label3.Location = new System.Drawing.Point(20, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Z:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkBlue;
            this.label2.Location = new System.Drawing.Point(20, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Y:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "X:";
            // 
            // displayBox
            // 
            this.displayBox.BackColor = System.Drawing.Color.Gainsboro;
            this.displayBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.displayBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.displayBox.Location = new System.Drawing.Point(60, 20);
            this.displayBox.Name = "displayBox";
            this.displayBox.Size = new System.Drawing.Size(400, 300);
            this.displayBox.TabIndex = 1;
            this.displayBox.TabStop = false;
            this.displayBox.Click += new System.EventHandler(this.displayBox_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(230)))), ((int)(((byte)(44)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.servoValue1);
            this.panel2.Controls.Add(this.servoValue6);
            this.panel2.Controls.Add(this.servoValue2);
            this.panel2.Controls.Add(this.servoValue3);
            this.panel2.Controls.Add(this.servoValue4);
            this.panel2.Controls.Add(this.servoValue5);
            this.panel2.Controls.Add(this.l6);
            this.panel2.Controls.Add(this.servo1);
            this.panel2.Controls.Add(this.l5);
            this.panel2.Controls.Add(this.servo6);
            this.panel2.Controls.Add(this.l4);
            this.panel2.Controls.Add(this.servo2);
            this.panel2.Controls.Add(this.l3);
            this.panel2.Controls.Add(this.servo3);
            this.panel2.Controls.Add(this.l2);
            this.panel2.Controls.Add(this.servo4);
            this.panel2.Controls.Add(this.l1);
            this.panel2.Controls.Add(this.servo5);
            this.panel2.Location = new System.Drawing.Point(60, 380);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(520, 280);
            this.panel2.TabIndex = 2;
            // 
            // servoValue1
            // 
            this.servoValue1.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.servoValue1.ForeColor = System.Drawing.Color.Maroon;
            this.servoValue1.Location = new System.Drawing.Point(460, 220);
            this.servoValue1.Name = "servoValue1";
            this.servoValue1.Size = new System.Drawing.Size(40, 39);
            this.servoValue1.TabIndex = 2;
            this.servoValue1.Text = "090";
            // 
            // servoValue6
            // 
            this.servoValue6.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.servoValue6.ForeColor = System.Drawing.Color.Maroon;
            this.servoValue6.Location = new System.Drawing.Point(360, 220);
            this.servoValue6.Name = "servoValue6";
            this.servoValue6.Size = new System.Drawing.Size(40, 39);
            this.servoValue6.TabIndex = 2;
            this.servoValue6.Text = "090";
            // 
            // servoValue2
            // 
            this.servoValue2.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.servoValue2.ForeColor = System.Drawing.Color.Maroon;
            this.servoValue2.Location = new System.Drawing.Point(280, 220);
            this.servoValue2.Name = "servoValue2";
            this.servoValue2.Size = new System.Drawing.Size(40, 39);
            this.servoValue2.TabIndex = 2;
            this.servoValue2.Text = "090";
            // 
            // servoValue3
            // 
            this.servoValue3.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.servoValue3.ForeColor = System.Drawing.Color.Maroon;
            this.servoValue3.Location = new System.Drawing.Point(200, 220);
            this.servoValue3.Name = "servoValue3";
            this.servoValue3.Size = new System.Drawing.Size(40, 39);
            this.servoValue3.TabIndex = 2;
            this.servoValue3.Text = "090";
            // 
            // servoValue4
            // 
            this.servoValue4.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.servoValue4.ForeColor = System.Drawing.Color.Maroon;
            this.servoValue4.Location = new System.Drawing.Point(100, 220);
            this.servoValue4.Name = "servoValue4";
            this.servoValue4.Size = new System.Drawing.Size(40, 39);
            this.servoValue4.TabIndex = 2;
            this.servoValue4.Text = "090";
            // 
            // servoValue5
            // 
            this.servoValue5.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.servoValue5.ForeColor = System.Drawing.Color.Maroon;
            this.servoValue5.Location = new System.Drawing.Point(20, 220);
            this.servoValue5.Name = "servoValue5";
            this.servoValue5.Size = new System.Drawing.Size(40, 39);
            this.servoValue5.TabIndex = 2;
            this.servoValue5.Text = "090";
            // 
            // l6
            // 
            this.l6.AutoSize = true;
            this.l6.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l6.ForeColor = System.Drawing.Color.DarkBlue;
            this.l6.Location = new System.Drawing.Point(440, 20);
            this.l6.Name = "l6";
            this.l6.Size = new System.Drawing.Size(65, 20);
            this.l6.TabIndex = 2;
            this.l6.Text = "Gripper";
            // 
            // servo1
            // 
            this.servo1.LargeChange = 10;
            this.servo1.Location = new System.Drawing.Point(460, 40);
            this.servo1.Maximum = 130;
            this.servo1.Minimum = 90;
            this.servo1.Name = "servo1";
            this.servo1.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.servo1.Size = new System.Drawing.Size(45, 180);
            this.servo1.TabIndex = 1;
            this.servo1.Value = 90;
            this.servo1.Scroll += new System.EventHandler(this.servo1_Scroll);
            // 
            // l5
            // 
            this.l5.AutoSize = true;
            this.l5.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l5.ForeColor = System.Drawing.Color.DarkBlue;
            this.l5.Location = new System.Drawing.Point(340, 20);
            this.l5.Name = "l5";
            this.l5.Size = new System.Drawing.Size(85, 20);
            this.l5.TabIndex = 2;
            this.l5.Text = "Wrist Turn";
            // 
            // servo6
            // 
            this.servo6.LargeChange = 10;
            this.servo6.Location = new System.Drawing.Point(360, 40);
            this.servo6.Maximum = 180;
            this.servo6.Name = "servo6";
            this.servo6.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.servo6.Size = new System.Drawing.Size(45, 180);
            this.servo6.TabIndex = 1;
            this.servo6.Value = 90;
            this.servo6.Scroll += new System.EventHandler(this.servo6_Scroll);
            // 
            // l4
            // 
            this.l4.AutoSize = true;
            this.l4.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l4.ForeColor = System.Drawing.Color.DarkBlue;
            this.l4.Location = new System.Drawing.Point(260, 20);
            this.l4.Name = "l4";
            this.l4.Size = new System.Drawing.Size(47, 20);
            this.l4.TabIndex = 2;
            this.l4.Text = "Wrist";
            // 
            // servo2
            // 
            this.servo2.LargeChange = 10;
            this.servo2.Location = new System.Drawing.Point(280, 40);
            this.servo2.Maximum = 180;
            this.servo2.Name = "servo2";
            this.servo2.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.servo2.Size = new System.Drawing.Size(45, 180);
            this.servo2.TabIndex = 1;
            this.servo2.Value = 90;
            this.servo2.Scroll += new System.EventHandler(this.servo2_Scroll);
            // 
            // l3
            // 
            this.l3.AutoSize = true;
            this.l3.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l3.ForeColor = System.Drawing.Color.DarkBlue;
            this.l3.Location = new System.Drawing.Point(180, 20);
            this.l3.Name = "l3";
            this.l3.Size = new System.Drawing.Size(54, 20);
            this.l3.TabIndex = 2;
            this.l3.Text = "Elbow";
            // 
            // servo3
            // 
            this.servo3.LargeChange = 10;
            this.servo3.Location = new System.Drawing.Point(200, 40);
            this.servo3.Maximum = 180;
            this.servo3.Name = "servo3";
            this.servo3.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.servo3.Size = new System.Drawing.Size(45, 180);
            this.servo3.TabIndex = 1;
            this.servo3.Value = 90;
            this.servo3.Scroll += new System.EventHandler(this.servo3_Scroll);
            // 
            // l2
            // 
            this.l2.AutoSize = true;
            this.l2.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l2.ForeColor = System.Drawing.Color.DarkBlue;
            this.l2.Location = new System.Drawing.Point(80, 20);
            this.l2.Name = "l2";
            this.l2.Size = new System.Drawing.Size(76, 20);
            this.l2.TabIndex = 2;
            this.l2.Text = "Shoulder";
            // 
            // servo4
            // 
            this.servo4.LargeChange = 10;
            this.servo4.Location = new System.Drawing.Point(100, 40);
            this.servo4.Maximum = 180;
            this.servo4.Name = "servo4";
            this.servo4.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.servo4.Size = new System.Drawing.Size(45, 180);
            this.servo4.TabIndex = 1;
            this.servo4.Value = 90;
            this.servo4.Scroll += new System.EventHandler(this.servo4_Scroll);
            // 
            // l1
            // 
            this.l1.AutoSize = true;
            this.l1.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.l1.ForeColor = System.Drawing.Color.DarkBlue;
            this.l1.Location = new System.Drawing.Point(20, 20);
            this.l1.Name = "l1";
            this.l1.Size = new System.Drawing.Size(44, 20);
            this.l1.TabIndex = 2;
            this.l1.Text = "Base";
            // 
            // servo5
            // 
            this.servo5.LargeChange = 10;
            this.servo5.Location = new System.Drawing.Point(20, 40);
            this.servo5.Maximum = 180;
            this.servo5.Name = "servo5";
            this.servo5.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.servo5.Size = new System.Drawing.Size(45, 180);
            this.servo5.TabIndex = 1;
            this.servo5.Value = 90;
            this.servo5.Scroll += new System.EventHandler(this.servo5_Scroll);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(230)))), ((int)(((byte)(44)))));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.load);
            this.panel3.Controls.Add(this.fileName);
            this.panel3.Controls.Add(this.save);
            this.panel3.Controls.Add(this.sequence);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Location = new System.Drawing.Point(600, 20);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(580, 340);
            this.panel3.TabIndex = 3;
            // 
            // load
            // 
            this.load.BackColor = System.Drawing.SystemColors.HighlightText;
            this.load.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.load.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.load.Location = new System.Drawing.Point(380, 300);
            this.load.Margin = new System.Windows.Forms.Padding(2);
            this.load.Name = "load";
            this.load.Size = new System.Drawing.Size(70, 30);
            this.load.TabIndex = 4;
            this.load.Text = "Load";
            this.load.UseVisualStyleBackColor = false;
            this.load.Click += new System.EventHandler(this.load_Click);
            // 
            // fileName
            // 
            this.fileName.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileName.ForeColor = System.Drawing.Color.DarkBlue;
            this.fileName.Location = new System.Drawing.Point(100, 300);
            this.fileName.Name = "fileName";
            this.fileName.Size = new System.Drawing.Size(180, 31);
            this.fileName.TabIndex = 3;
            // 
            // save
            // 
            this.save.BackColor = System.Drawing.SystemColors.HighlightText;
            this.save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.save.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save.Location = new System.Drawing.Point(300, 300);
            this.save.Margin = new System.Windows.Forms.Padding(2);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(70, 30);
            this.save.TabIndex = 3;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = false;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // sequence
            // 
            this.sequence.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sequence.ForeColor = System.Drawing.Color.Maroon;
            this.sequence.FormattingEnabled = true;
            this.sequence.ItemHeight = 23;
            this.sequence.Items.AddRange(new object[] {
            ""});
            this.sequence.Location = new System.Drawing.Point(20, 20);
            this.sequence.Name = "sequence";
            this.sequence.Size = new System.Drawing.Size(440, 257);
            this.sequence.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Adobe Gothic Std B", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label5.ForeColor = System.Drawing.Color.DarkBlue;
            this.label5.Location = new System.Drawing.Point(20, 300);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 30);
            this.label5.TabIndex = 2;
            this.label5.Text = "Name:";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.delayAmount);
            this.panel4.Controls.Add(this.home);
            this.panel4.Controls.Add(this.place);
            this.panel4.Controls.Add(this.run);
            this.panel4.Controls.Add(this.reset);
            this.panel4.Controls.Add(this.pick);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.copy);
            this.panel4.Controls.Add(this.paste);
            this.panel4.Controls.Add(this.clearAll);
            this.panel4.Controls.Add(this.delete);
            this.panel4.Controls.Add(this.add);
            this.panel4.Location = new System.Drawing.Point(600, 380);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(260, 280);
            this.panel4.TabIndex = 4;
            // 
            // delayAmount
            // 
            this.delayAmount.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delayAmount.ForeColor = System.Drawing.Color.Maroon;
            this.delayAmount.Location = new System.Drawing.Point(140, 60);
            this.delayAmount.Name = "delayAmount";
            this.delayAmount.Size = new System.Drawing.Size(100, 39);
            this.delayAmount.TabIndex = 2;
            this.delayAmount.Text = "1000";
            this.delayAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // home
            // 
            this.home.BackColor = System.Drawing.Color.Gold;
            this.home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.home.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.home.Location = new System.Drawing.Point(140, 100);
            this.home.Name = "home";
            this.home.Size = new System.Drawing.Size(100, 40);
            this.home.TabIndex = 0;
            this.home.Text = "Home";
            this.home.UseVisualStyleBackColor = false;
            this.home.Click += new System.EventHandler(this.home_Click);
            // 
            // place
            // 
            this.place.BackColor = System.Drawing.Color.Brown;
            this.place.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.place.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.place.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.place.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.place.Location = new System.Drawing.Point(140, 180);
            this.place.Name = "place";
            this.place.Size = new System.Drawing.Size(100, 40);
            this.place.TabIndex = 0;
            this.place.Text = "Place";
            this.place.UseVisualStyleBackColor = false;
            this.place.Click += new System.EventHandler(this.place_Click);
            // 
            // run
            // 
            this.run.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(200)))), ((int)(((byte)(9)))));
            this.run.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.run.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.run.Location = new System.Drawing.Point(140, 220);
            this.run.Name = "run";
            this.run.Size = new System.Drawing.Size(100, 40);
            this.run.TabIndex = 0;
            this.run.Text = "Run ";
            this.run.UseVisualStyleBackColor = false;
            this.run.Click += new System.EventHandler(this.run_Click);
            // 
            // reset
            // 
            this.reset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(200)))), ((int)(((byte)(9)))));
            this.reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reset.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reset.Location = new System.Drawing.Point(20, 220);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(100, 40);
            this.reset.TabIndex = 0;
            this.reset.Text = "Reset";
            this.reset.UseVisualStyleBackColor = false;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // pick
            // 
            this.pick.BackColor = System.Drawing.Color.Brown;
            this.pick.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.pick.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pick.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pick.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.pick.Location = new System.Drawing.Point(20, 180);
            this.pick.Name = "pick";
            this.pick.Size = new System.Drawing.Size(100, 40);
            this.pick.TabIndex = 0;
            this.pick.Text = "Pick";
            this.pick.UseVisualStyleBackColor = false;
            this.pick.Click += new System.EventHandler(this.pick_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkBlue;
            this.label4.Location = new System.Drawing.Point(40, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Delay:";
            // 
            // copy
            // 
            this.copy.BackColor = System.Drawing.Color.Gold;
            this.copy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.copy.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.copy.Location = new System.Drawing.Point(20, 140);
            this.copy.Name = "copy";
            this.copy.Size = new System.Drawing.Size(100, 40);
            this.copy.TabIndex = 0;
            this.copy.Text = "Copy";
            this.copy.UseVisualStyleBackColor = false;
            this.copy.Click += new System.EventHandler(this.copy_Click);
            // 
            // paste
            // 
            this.paste.BackColor = System.Drawing.Color.Gold;
            this.paste.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.paste.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paste.Location = new System.Drawing.Point(20, 100);
            this.paste.Name = "paste";
            this.paste.Size = new System.Drawing.Size(100, 40);
            this.paste.TabIndex = 0;
            this.paste.Text = "Paste";
            this.paste.UseVisualStyleBackColor = false;
            this.paste.Click += new System.EventHandler(this.paste_Click);
            // 
            // clearAll
            // 
            this.clearAll.BackColor = System.Drawing.Color.Gold;
            this.clearAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearAll.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearAll.Location = new System.Drawing.Point(140, 140);
            this.clearAll.Name = "clearAll";
            this.clearAll.Size = new System.Drawing.Size(100, 40);
            this.clearAll.TabIndex = 0;
            this.clearAll.Text = "Clear All";
            this.clearAll.UseVisualStyleBackColor = false;
            this.clearAll.Click += new System.EventHandler(this.clearAll_Click);
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.Color.Gold;
            this.delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete.Location = new System.Drawing.Point(20, 20);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(100, 40);
            this.delete.TabIndex = 0;
            this.delete.Text = "Delete ";
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // add
            // 
            this.add.BackColor = System.Drawing.Color.Goldenrod;
            this.add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add.Location = new System.Drawing.Point(140, 20);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(100, 40);
            this.add.TabIndex = 0;
            this.add.Text = "Add Move";
            this.add.UseVisualStyleBackColor = false;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // usb
            // 
            this.usb.BaudRate = 115200;
            this.usb.PortName = "COM3";
            this.usb.WriteBufferSize = 4096;
            // 
            // comState
            // 
            this.comState.Location = new System.Drawing.Point(60, 340);
            this.comState.Name = "comState";
            this.comState.Size = new System.Drawing.Size(80, 23);
            this.comState.TabIndex = 0;
            this.comState.Text = "Start";
            this.comState.UseVisualStyleBackColor = true;
            this.comState.Click += new System.EventHandler(this.comState_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(460, 340);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Start Camera";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Programming
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comState);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.displayBox);
            this.Controls.Add(this.panel1);
            this.Name = "Programming";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Programming";
            this.Load += new System.EventHandler(this.Programming_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zaxis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yaxis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xaxis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.displayBox)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.servo1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.servo6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.servo2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.servo3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.servo4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.servo5)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox displayBox;
        private System.Windows.Forms.TrackBar zaxis;
        private System.Windows.Forms.TrackBar yaxis;
        private System.Windows.Forms.TrackBar xaxis;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label l6;
        private System.Windows.Forms.TrackBar servo1;
        private System.Windows.Forms.Label l5;
        private System.Windows.Forms.TrackBar servo6;
        private System.Windows.Forms.Label l4;
        private System.Windows.Forms.TrackBar servo2;
        private System.Windows.Forms.Label l3;
        private System.Windows.Forms.TrackBar servo3;
        private System.Windows.Forms.Label l2;
        private System.Windows.Forms.TrackBar servo4;
        private System.Windows.Forms.Label l1;
        private System.Windows.Forms.TrackBar servo5;
        private System.Windows.Forms.TextBox zaxisValue;
        private System.Windows.Forms.TextBox yaxisValue;
        private System.Windows.Forms.TextBox xaxisValue;
        private System.Windows.Forms.TextBox servoValue1;
        private System.Windows.Forms.TextBox servoValue6;
        private System.Windows.Forms.TextBox servoValue2;
        private System.Windows.Forms.TextBox servoValue3;
        private System.Windows.Forms.TextBox servoValue4;
        private System.Windows.Forms.TextBox servoValue5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox delayAmount;
        private System.Windows.Forms.Button home;
        private System.Windows.Forms.Button copy;
        private System.Windows.Forms.Button paste;
        private System.Windows.Forms.Button clearAll;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.ListBox sequence;
        private System.Windows.Forms.Button place;
        private System.Windows.Forms.Button pick;
        private System.Windows.Forms.Button run;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.Button comState;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.TextBox fileName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button load;
        public System.IO.Ports.SerialPort usb;
    }
}
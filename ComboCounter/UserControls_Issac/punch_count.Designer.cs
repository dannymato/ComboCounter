using ComboCounter.Classes;
using ComboCounter.CustomControls;

namespace ComboCounter.UserControls
{
    partial class punch_count
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.startButton = new ComboCounter.CustomControls.OutlineButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.stopButton = new ComboCounter.CustomControls.OutlineButton();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.minusIcon = new ComboCounter.CustomControls.TextButton();
            this.plusIcon = new ComboCounter.CustomControls.TextButton();
            this.resetButton = new ComboCounter.CustomControls.OutlineButton();
            this.timeSetHeader = new ComboCounter.Classes.H3();
            this.thresholdHeader = new ComboCounter.Classes.H3();
            this.invalidPunchHeader = new ComboCounter.Classes.H3();
            this.validPunchHeader = new ComboCounter.Classes.H3();
            this.currTimeHeader = new ComboCounter.Classes.H3();
            this.lastHitHeader = new ComboCounter.Classes.H3();
            this.Header = new ComboCounter.Classes.H2();
            this.setTime = new ComboCounter.Classes.BigInfo();
            this.threshold = new ComboCounter.Classes.BigInfo();
            this.numInvalidPunch = new ComboCounter.Classes.BigInfo();
            this.punchCounter = new ComboCounter.Classes.BigInfo();
            this.lastHit = new ComboCounter.Classes.BigInfo();
            this.currentTime = new ComboCounter.Classes.BigInfo();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.AutoSize = true;
            this.startButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(23)))), ((int)(((byte)(30)))));
            this.startButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.startButton.Location = new System.Drawing.Point(87, 553);
            this.startButton.Margin = new System.Windows.Forms.Padding(4);
            this.startButton.Name = "startButton";
            this.startButton.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.startButton.Size = new System.Drawing.Size(228, 75);
            this.startButton.TabIndex = 16;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // stopButton
            // 
            this.stopButton.AutoSize = true;
            this.stopButton.BackColor = System.Drawing.Color.Transparent;
            this.stopButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stopButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.stopButton.Location = new System.Drawing.Point(87, 725);
            this.stopButton.Margin = new System.Windows.Forms.Padding(4);
            this.stopButton.Name = "stopButton";
            this.stopButton.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.stopButton.Size = new System.Drawing.Size(228, 75);
            this.stopButton.TabIndex = 18;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // minusIcon
            // 
            this.minusIcon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.minusIcon.AutoSize = true;
            this.minusIcon.BackColor = System.Drawing.Color.Transparent;
            this.minusIcon.FlatAppearance.BorderSize = 0;
            this.minusIcon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minusIcon.ForeColor = System.Drawing.Color.White;
            this.minusIcon.Location = new System.Drawing.Point(4, 82);
            this.minusIcon.Margin = new System.Windows.Forms.Padding(4);
            this.minusIcon.Name = "minusIcon";
            this.minusIcon.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.minusIcon.Size = new System.Drawing.Size(75, 75);
            this.minusIcon.TabIndex = 22;
            this.minusIcon.Text = "-";
            this.minusIcon.UseVisualStyleBackColor = true;
            this.minusIcon.Click += new System.EventHandler(this.minusIcon_Click);
            // 
            // plusIcon
            // 
            this.plusIcon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.plusIcon.AutoSize = true;
            this.plusIcon.BackColor = System.Drawing.Color.Transparent;
            this.plusIcon.FlatAppearance.BorderSize = 0;
            this.plusIcon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.plusIcon.ForeColor = System.Drawing.Color.White;
            this.plusIcon.Location = new System.Drawing.Point(689, 82);
            this.plusIcon.Margin = new System.Windows.Forms.Padding(4);
            this.plusIcon.Name = "plusIcon";
            this.plusIcon.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.plusIcon.Size = new System.Drawing.Size(75, 75);
            this.plusIcon.TabIndex = 23;
            this.plusIcon.Text = "+";
            this.plusIcon.UseVisualStyleBackColor = true;
            this.plusIcon.Click += new System.EventHandler(this.plusIcon_Click);
            // 
            // resetButton
            // 
            this.resetButton.AutoSize = true;
            this.resetButton.BackColor = System.Drawing.Color.Transparent;
            this.resetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resetButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.resetButton.Location = new System.Drawing.Point(87, 885);
            this.resetButton.Margin = new System.Windows.Forms.Padding(4);
            this.resetButton.Name = "resetButton";
            this.resetButton.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.resetButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.resetButton.Size = new System.Drawing.Size(228, 75);
            this.resetButton.TabIndex = 24;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // timeSetHeader
            // 
            this.timeSetHeader.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.timeSetHeader.AutoSize = true;
            this.timeSetHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(161)))), ((int)(((byte)(242)))));
            this.timeSetHeader.Location = new System.Drawing.Point(334, 321);
            this.timeSetHeader.Name = "timeSetHeader";
            this.timeSetHeader.Size = new System.Drawing.Size(397, 81);
            this.timeSetHeader.TabIndex = 49;
            this.timeSetHeader.Text = "Time Setting";
            // 
            // thresholdHeader
            // 
            this.thresholdHeader.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.thresholdHeader.AutoSize = true;
            this.thresholdHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(161)))), ((int)(((byte)(242)))));
            this.thresholdHeader.Location = new System.Drawing.Point(285, 648);
            this.thresholdHeader.Name = "thresholdHeader";
            this.thresholdHeader.Size = new System.Drawing.Size(495, 81);
            this.thresholdHeader.TabIndex = 50;
            this.thresholdHeader.Text = "Threshold Force";
            // 
            // invalidPunchHeader
            // 
            this.invalidPunchHeader.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.invalidPunchHeader.AutoSize = true;
            this.invalidPunchHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(161)))), ((int)(((byte)(242)))));
            this.invalidPunchHeader.Location = new System.Drawing.Point(286, 0);
            this.invalidPunchHeader.Name = "invalidPunchHeader";
            this.invalidPunchHeader.Size = new System.Drawing.Size(492, 81);
            this.invalidPunchHeader.TabIndex = 51;
            this.invalidPunchHeader.Text = "Invalid Punches";
            this.invalidPunchHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.invalidPunchHeader.Click += new System.EventHandler(this.label2_Click);
            // 
            // validPunchHeader
            // 
            this.validPunchHeader.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.validPunchHeader.AutoSize = true;
            this.validPunchHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(161)))), ((int)(((byte)(242)))));
            this.validPunchHeader.Location = new System.Drawing.Point(1375, 0);
            this.validPunchHeader.Name = "validPunchHeader";
            this.validPunchHeader.Size = new System.Drawing.Size(444, 81);
            this.validPunchHeader.TabIndex = 52;
            this.validPunchHeader.Text = "Valid Punches";
            this.validPunchHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // currTimeHeader
            // 
            this.currTimeHeader.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.currTimeHeader.AutoSize = true;
            this.currTimeHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(161)))), ((int)(((byte)(242)))));
            this.currTimeHeader.Location = new System.Drawing.Point(1392, 321);
            this.currTimeHeader.Name = "currTimeHeader";
            this.currTimeHeader.Size = new System.Drawing.Size(410, 81);
            this.currTimeHeader.TabIndex = 53;
            this.currTimeHeader.Text = "Current Time";
            // 
            // lastHitHeader
            // 
            this.lastHitHeader.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lastHitHeader.AutoSize = true;
            this.lastHitHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(161)))), ((int)(((byte)(242)))));
            this.lastHitHeader.Location = new System.Drawing.Point(1469, 648);
            this.lastHitHeader.Name = "lastHitHeader";
            this.lastHitHeader.Size = new System.Drawing.Size(256, 81);
            this.lastHitHeader.TabIndex = 54;
            this.lastHitHeader.Text = "Last Hit";
            // 
            // Header
            // 
            this.Header.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Header.AutoSize = true;
            this.Header.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(161)))), ((int)(((byte)(242)))));
            this.Header.Location = new System.Drawing.Point(1024, 12);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(779, 158);
            this.Header.TabIndex = 55;
            this.Header.Text = "Punch Count";
            // 
            // setTime
            // 
            this.setTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.setTime.AutoSize = true;
            this.setTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.setTime.Location = new System.Drawing.Point(86, 0);
            this.setTime.Name = "setTime";
            this.setTime.Size = new System.Drawing.Size(596, 240);
            this.setTime.TabIndex = 57;
            this.setTime.Text = "00:30";
            this.setTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.setTime.Click += new System.EventHandler(this.setTimeMins_Click);
            // 
            // threshold
            // 
            this.threshold.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.threshold.AutoSize = true;
            this.threshold.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.threshold.Location = new System.Drawing.Point(314, 731);
            this.threshold.Name = "threshold";
            this.threshold.Size = new System.Drawing.Size(436, 240);
            this.threshold.TabIndex = 58;
            this.threshold.Text = "200";
            this.threshold.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numInvalidPunch
            // 
            this.numInvalidPunch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numInvalidPunch.AutoSize = true;
            this.numInvalidPunch.ForeColor = System.Drawing.Color.DarkRed;
            this.numInvalidPunch.Location = new System.Drawing.Point(426, 81);
            this.numInvalidPunch.Name = "numInvalidPunch";
            this.numInvalidPunch.Size = new System.Drawing.Size(212, 240);
            this.numInvalidPunch.TabIndex = 59;
            this.numInvalidPunch.Text = "0";
            this.numInvalidPunch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // punchCounter
            // 
            this.punchCounter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.punchCounter.AutoSize = true;
            this.punchCounter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.punchCounter.Location = new System.Drawing.Point(1491, 81);
            this.punchCounter.Name = "punchCounter";
            this.punchCounter.Size = new System.Drawing.Size(212, 240);
            this.punchCounter.TabIndex = 60;
            this.punchCounter.Text = "0";
            this.punchCounter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lastHit
            // 
            this.lastHit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lastHit.AutoSize = true;
            this.lastHit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.lastHit.Location = new System.Drawing.Point(1370, 731);
            this.lastHit.Name = "lastHit";
            this.lastHit.Size = new System.Drawing.Size(455, 240);
            this.lastHit.TabIndex = 61;
            this.lastHit.Text = "N/A";
            this.lastHit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lastHit.TextChanged += new System.EventHandler(this.lastHit_TextChanged_1);
            // 
            // currentTime
            // 
            this.currentTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.currentTime.AutoSize = true;
            this.currentTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.currentTime.Location = new System.Drawing.Point(1161, 405);
            this.currentTime.Name = "currentTime";
            this.currentTime.Size = new System.Drawing.Size(873, 240);
            this.currentTime.TabIndex = 62;
            this.currentTime.Text = "00:00.00";
            this.currentTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.punchCounter, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.validPunchHeader, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.currentTime, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.invalidPunchHeader, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.currTimeHeader, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lastHit, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.numInvalidPunch, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.timeSetHeader, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.threshold, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.lastHitHeader, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.thresholdHeader, 0, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(363, 188);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(2130, 973);
            this.tableLayoutPanel1.TabIndex = 63;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.minusIcon);
            this.flowLayoutPanel1.Controls.Add(this.setTime);
            this.flowLayoutPanel1.Controls.Add(this.plusIcon);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(148, 405);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(768, 240);
            this.flowLayoutPanel1.TabIndex = 60;
            // 
            // punch_count
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.Header);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "punch_count";
            this.Size = new System.Drawing.Size(2496, 1164);
            this.Load += new System.EventHandler(this.punch_count_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private OutlineButton startButton;
        private OutlineButton stopButton;
        private OutlineButton resetButton;
        private H3 timeSetHeader;
        private H3 thresholdHeader;
        private H3 invalidPunchHeader;
        private H3 validPunchHeader;
        private H3 currTimeHeader;
        private H3 lastHitHeader;
        private H2 Header;
        private BigInfo setTime;
        private BigInfo threshold;
        private BigInfo numInvalidPunch;
        private BigInfo punchCounter;
        private BigInfo lastHit;
        private BigInfo currentTime;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private TextButton minusIcon;
        private TextButton plusIcon;
    }
}

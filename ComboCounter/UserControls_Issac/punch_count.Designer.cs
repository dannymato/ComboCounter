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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(punch_count));
            this.startButton = new ComboCounter.CustomControls.OutlineButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.stopButton = new ComboCounter.CustomControls.OutlineButton();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.minusIcon = new System.Windows.Forms.Button();
            this.plusIcon = new System.Windows.Forms.Button();
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
            this.minusIcon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("minusIcon.BackgroundImage")));
            this.minusIcon.FlatAppearance.BorderSize = 0;
            this.minusIcon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minusIcon.Location = new System.Drawing.Point(422, 735);
            this.minusIcon.Margin = new System.Windows.Forms.Padding(4);
            this.minusIcon.Name = "minusIcon";
            this.minusIcon.Size = new System.Drawing.Size(81, 68);
            this.minusIcon.TabIndex = 22;
            this.minusIcon.UseVisualStyleBackColor = true;
            this.minusIcon.Click += new System.EventHandler(this.minusIcon_Click);
            // 
            // plusIcon
            // 
            this.plusIcon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("plusIcon.BackgroundImage")));
            this.plusIcon.FlatAppearance.BorderSize = 0;
            this.plusIcon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.plusIcon.Location = new System.Drawing.Point(1167, 740);
            this.plusIcon.Margin = new System.Windows.Forms.Padding(4);
            this.plusIcon.Name = "plusIcon";
            this.plusIcon.Size = new System.Drawing.Size(61, 58);
            this.plusIcon.TabIndex = 23;
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
            this.timeSetHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.timeSetHeader.AutoSize = true;
            this.timeSetHeader.ForeColor = System.Drawing.Color.SteelBlue;
            this.timeSetHeader.Location = new System.Drawing.Point(625, 579);
            this.timeSetHeader.Name = "timeSetHeader";
            this.timeSetHeader.Size = new System.Drawing.Size(367, 69);
            this.timeSetHeader.TabIndex = 49;
            this.timeSetHeader.Text = "Time Setting";
            // 
            // thresholdHeader
            // 
            this.thresholdHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.thresholdHeader.AutoSize = true;
            this.thresholdHeader.ForeColor = System.Drawing.Color.SteelBlue;
            this.thresholdHeader.Location = new System.Drawing.Point(572, 879);
            this.thresholdHeader.Name = "thresholdHeader";
            this.thresholdHeader.Size = new System.Drawing.Size(465, 69);
            this.thresholdHeader.TabIndex = 50;
            this.thresholdHeader.Text = "Threshold Force";
            // 
            // invalidPunchHeader
            // 
            this.invalidPunchHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.invalidPunchHeader.AutoSize = true;
            this.invalidPunchHeader.ForeColor = System.Drawing.Color.SteelBlue;
            this.invalidPunchHeader.Location = new System.Drawing.Point(585, 284);
            this.invalidPunchHeader.Name = "invalidPunchHeader";
            this.invalidPunchHeader.Size = new System.Drawing.Size(452, 69);
            this.invalidPunchHeader.TabIndex = 51;
            this.invalidPunchHeader.Text = "Invalid Punches";
            this.invalidPunchHeader.Click += new System.EventHandler(this.label2_Click);
            // 
            // validPunchHeader
            // 
            this.validPunchHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.validPunchHeader.AutoSize = true;
            this.validPunchHeader.ForeColor = System.Drawing.Color.SteelBlue;
            this.validPunchHeader.Location = new System.Drawing.Point(1590, 234);
            this.validPunchHeader.Name = "validPunchHeader";
            this.validPunchHeader.Size = new System.Drawing.Size(412, 69);
            this.validPunchHeader.TabIndex = 52;
            this.validPunchHeader.Text = "Valid Punches";
            // 
            // currTimeHeader
            // 
            this.currTimeHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.currTimeHeader.AutoSize = true;
            this.currTimeHeader.ForeColor = System.Drawing.Color.SteelBlue;
            this.currTimeHeader.Location = new System.Drawing.Point(1607, 537);
            this.currTimeHeader.Name = "currTimeHeader";
            this.currTimeHeader.Size = new System.Drawing.Size(379, 69);
            this.currTimeHeader.TabIndex = 53;
            this.currTimeHeader.Text = "Current Time";
            // 
            // lastHitHeader
            // 
            this.lastHitHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lastHitHeader.AutoSize = true;
            this.lastHitHeader.ForeColor = System.Drawing.Color.SteelBlue;
            this.lastHitHeader.Location = new System.Drawing.Point(1462, 985);
            this.lastHitHeader.Name = "lastHitHeader";
            this.lastHitHeader.Size = new System.Drawing.Size(233, 69);
            this.lastHitHeader.TabIndex = 54;
            this.lastHitHeader.Text = "Last Hit";
            // 
            // Header
            // 
            this.Header.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Header.AutoSize = true;
            this.Header.ForeColor = System.Drawing.Color.SteelBlue;
            this.Header.Location = new System.Drawing.Point(891, 57);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(730, 132);
            this.Header.TabIndex = 55;
            this.Header.Text = "Punch Count";
            // 
            // setTime
            // 
            this.setTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.setTime.AutoSize = true;
            this.setTime.ForeColor = System.Drawing.Color.DimGray;
            this.setTime.Location = new System.Drawing.Point(510, 653);
            this.setTime.Name = "setTime";
            this.setTime.Size = new System.Drawing.Size(595, 226);
            this.setTime.TabIndex = 57;
            this.setTime.Text = "00:30";
            this.setTime.Click += new System.EventHandler(this.setTimeMins_Click);
            // 
            // threshold
            // 
            this.threshold.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.threshold.AutoSize = true;
            this.threshold.ForeColor = System.Drawing.Color.DimGray;
            this.threshold.Location = new System.Drawing.Point(599, 942);
            this.threshold.Name = "threshold";
            this.threshold.Size = new System.Drawing.Size(428, 226);
            this.threshold.TabIndex = 58;
            this.threshold.Text = "200";
            // 
            // numInvalidPunch
            // 
            this.numInvalidPunch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numInvalidPunch.AutoSize = true;
            this.numInvalidPunch.ForeColor = System.Drawing.Color.DarkRed;
            this.numInvalidPunch.Location = new System.Drawing.Point(707, 353);
            this.numInvalidPunch.Name = "numInvalidPunch";
            this.numInvalidPunch.Size = new System.Drawing.Size(206, 226);
            this.numInvalidPunch.TabIndex = 59;
            this.numInvalidPunch.Text = "0";
            // 
            // punchCounter
            // 
            this.punchCounter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.punchCounter.AutoSize = true;
            this.punchCounter.ForeColor = System.Drawing.Color.Green;
            this.punchCounter.Location = new System.Drawing.Point(1713, 315);
            this.punchCounter.Name = "punchCounter";
            this.punchCounter.Size = new System.Drawing.Size(206, 226);
            this.punchCounter.TabIndex = 60;
            this.punchCounter.Text = "0";
            // 
            // lastHit
            // 
            this.lastHit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lastHit.AutoSize = true;
            this.lastHit.ForeColor = System.Drawing.Color.DimGray;
            this.lastHit.Location = new System.Drawing.Point(1767, 895);
            this.lastHit.Name = "lastHit";
            this.lastHit.Size = new System.Drawing.Size(411, 255);
            this.lastHit.TabIndex = 61;
            this.lastHit.Text = "N/A";
            this.lastHit.UseCompatibleTextRendering = true;
            this.lastHit.TextChanged += new System.EventHandler(this.lastHit_TextChanged_1);
            // 
            // currentTime
            // 
            this.currentTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.currentTime.AutoSize = true;
            this.currentTime.ForeColor = System.Drawing.Color.DimGray;
            this.currentTime.Location = new System.Drawing.Point(1402, 634);
            this.currentTime.Name = "currentTime";
            this.currentTime.Size = new System.Drawing.Size(873, 226);
            this.currentTime.TabIndex = 62;
            this.currentTime.Text = "00:00.00";
            // 
            // punch_count
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(23)))), ((int)(((byte)(30)))));
            this.Controls.Add(this.currentTime);
            this.Controls.Add(this.lastHit);
            this.Controls.Add(this.punchCounter);
            this.Controls.Add(this.numInvalidPunch);
            this.Controls.Add(this.threshold);
            this.Controls.Add(this.setTime);
            this.Controls.Add(this.Header);
            this.Controls.Add(this.lastHitHeader);
            this.Controls.Add(this.currTimeHeader);
            this.Controls.Add(this.validPunchHeader);
            this.Controls.Add(this.invalidPunchHeader);
            this.Controls.Add(this.thresholdHeader);
            this.Controls.Add(this.timeSetHeader);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.plusIcon);
            this.Controls.Add(this.minusIcon);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.startButton);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "punch_count";
            this.Size = new System.Drawing.Size(2496, 1164);
            this.Load += new System.EventHandler(this.punch_count_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button minusIcon;
        private System.Windows.Forms.Button plusIcon;
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
    }
}

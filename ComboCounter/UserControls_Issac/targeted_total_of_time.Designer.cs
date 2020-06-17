using ComboCounter.Classes;
using ComboCounter.CustomControls;

namespace ComboCounter.UserControls
{
    partial class targeted_total_of_time
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(targeted_total_of_time));
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new ComboCounter.CustomControls.OutlineButton();
            this.button2 = new ComboCounter.CustomControls.OutlineButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.minusIcon = new System.Windows.Forms.Button();
            this.plusIcon = new System.Windows.Forms.Button();
            this.resetButton = new ComboCounter.CustomControls.OutlineButton();
            this.headerLabel = new ComboCounter.Classes.Header1();
            this.timeSetHeader = new ComboCounter.Classes.H2();
            this.currTimeHeader = new ComboCounter.Classes.H2();
            this.forceAccruedHeader = new ComboCounter.Classes.H2();
            this.currentTime = new ComboCounter.Classes.BigInfo();
            this.totalForce = new ComboCounter.Classes.BigInfo();
            this.setTimeSec = new ComboCounter.Classes.BigInfo();
            this.setTimeMins = new ComboCounter.Classes.BigInfo();
            this.setTimeColon = new ComboCounter.Classes.BigInfo();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 28);
            this.label1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button1.Location = new System.Drawing.Point(1287, 868);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.button1.Size = new System.Drawing.Size(268, 94);
            this.button1.TabIndex = 9;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button2.Location = new System.Drawing.Point(1647, 868);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.button2.Size = new System.Drawing.Size(268, 94);
            this.button2.TabIndex = 10;
            this.button2.Text = "Stop";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // minusIcon
            // 
            this.minusIcon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("minusIcon.BackgroundImage")));
            this.minusIcon.FlatAppearance.BorderSize = 0;
            this.minusIcon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minusIcon.Location = new System.Drawing.Point(303, 555);
            this.minusIcon.Margin = new System.Windows.Forms.Padding(4);
            this.minusIcon.Name = "minusIcon";
            this.minusIcon.Size = new System.Drawing.Size(100, 79);
            this.minusIcon.TabIndex = 13;
            this.minusIcon.UseVisualStyleBackColor = true;
            this.minusIcon.Click += new System.EventHandler(this.minusIcon_Click);
            // 
            // plusIcon
            // 
            this.plusIcon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("plusIcon.BackgroundImage")));
            this.plusIcon.FlatAppearance.BorderSize = 0;
            this.plusIcon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.plusIcon.Location = new System.Drawing.Point(1081, 562);
            this.plusIcon.Margin = new System.Windows.Forms.Padding(4);
            this.plusIcon.Name = "plusIcon";
            this.plusIcon.Size = new System.Drawing.Size(69, 65);
            this.plusIcon.TabIndex = 14;
            this.plusIcon.UseVisualStyleBackColor = true;
            this.plusIcon.Click += new System.EventHandler(this.plusIcon_Click);
            // 
            // resetButton
            // 
            this.resetButton.AutoSize = true;
            this.resetButton.BackColor = System.Drawing.Color.Transparent;
            this.resetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resetButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.resetButton.Location = new System.Drawing.Point(2025, 868);
            this.resetButton.Margin = new System.Windows.Forms.Padding(4);
            this.resetButton.Name = "resetButton";
            this.resetButton.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.resetButton.Size = new System.Drawing.Size(268, 94);
            this.resetButton.TabIndex = 16;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // headerLabel
            // 
            this.headerLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.headerLabel.AutoSize = true;
            this.headerLabel.ForeColor = System.Drawing.Color.SteelBlue;
            this.headerLabel.Location = new System.Drawing.Point(545, 60);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(1504, 180);
            this.headerLabel.TabIndex = 56;
            this.headerLabel.Text = "Targeted Total of Time";
            this.headerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timeSetHeader
            // 
            this.timeSetHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.timeSetHeader.AutoSize = true;
            this.timeSetHeader.ForeColor = System.Drawing.Color.SteelBlue;
            this.timeSetHeader.Location = new System.Drawing.Point(344, 340);
            this.timeSetHeader.Name = "timeSetHeader";
            this.timeSetHeader.Size = new System.Drawing.Size(774, 158);
            this.timeSetHeader.TabIndex = 57;
            this.timeSetHeader.Text = "Time Setting";
            // 
            // currTimeHeader
            // 
            this.currTimeHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.currTimeHeader.AutoSize = true;
            this.currTimeHeader.ForeColor = System.Drawing.Color.SteelBlue;
            this.currTimeHeader.Location = new System.Drawing.Point(1368, 340);
            this.currTimeHeader.Name = "currTimeHeader";
            this.currTimeHeader.Size = new System.Drawing.Size(801, 158);
            this.currTimeHeader.TabIndex = 58;
            this.currTimeHeader.Text = "Current Time";
            // 
            // forceAccruedHeader
            // 
            this.forceAccruedHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.forceAccruedHeader.AutoSize = true;
            this.forceAccruedHeader.ForeColor = System.Drawing.Color.SteelBlue;
            this.forceAccruedHeader.Location = new System.Drawing.Point(344, 690);
            this.forceAccruedHeader.Name = "forceAccruedHeader";
            this.forceAccruedHeader.Size = new System.Drawing.Size(861, 158);
            this.forceAccruedHeader.TabIndex = 69;
            this.forceAccruedHeader.Text = "Force Accrued";
            // 
            // currentTime
            // 
            this.currentTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.currentTime.AutoSize = true;
            this.currentTime.ForeColor = System.Drawing.Color.DimGray;
            this.currentTime.Location = new System.Drawing.Point(1392, 474);
            this.currentTime.Name = "currentTime";
            this.currentTime.Size = new System.Drawing.Size(761, 240);
            this.currentTime.TabIndex = 78;
            this.currentTime.Text = "00:00.0";
            // 
            // totalForce
            // 
            this.totalForce.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.totalForce.AutoSize = true;
            this.totalForce.ForeColor = System.Drawing.Color.Maroon;
            this.totalForce.Location = new System.Drawing.Point(639, 848);
            this.totalForce.Name = "totalForce";
            this.totalForce.Size = new System.Drawing.Size(212, 240);
            this.totalForce.TabIndex = 79;
            this.totalForce.Text = "0";
            // 
            // setTimeSec
            // 
            this.setTimeSec.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.setTimeSec.AutoSize = true;
            this.setTimeSec.ForeColor = System.Drawing.Color.DimGray;
            this.setTimeSec.Location = new System.Drawing.Point(750, 474);
            this.setTimeSec.Name = "setTimeSec";
            this.setTimeSec.Size = new System.Drawing.Size(324, 240);
            this.setTimeSec.TabIndex = 80;
            this.setTimeSec.Text = "30";
            this.setTimeSec.Click += new System.EventHandler(this.setTimeSec_Click);
            // 
            // setTimeMins
            // 
            this.setTimeMins.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.setTimeMins.AutoSize = true;
            this.setTimeMins.ForeColor = System.Drawing.Color.DimGray;
            this.setTimeMins.Location = new System.Drawing.Point(364, 474);
            this.setTimeMins.Name = "setTimeMins";
            this.setTimeMins.Size = new System.Drawing.Size(324, 240);
            this.setTimeMins.TabIndex = 81;
            this.setTimeMins.Text = "00";
            // 
            // setTimeColon
            // 
            this.setTimeColon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.setTimeColon.AutoSize = true;
            this.setTimeColon.ForeColor = System.Drawing.Color.DimGray;
            this.setTimeColon.Location = new System.Drawing.Point(639, 474);
            this.setTimeColon.Name = "setTimeColon";
            this.setTimeColon.Size = new System.Drawing.Size(148, 240);
            this.setTimeColon.TabIndex = 82;
            this.setTimeColon.Text = ":";
            // 
            // targeted_total_of_time
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(23)))), ((int)(((byte)(30)))));
            this.Controls.Add(this.setTimeColon);
            this.Controls.Add(this.setTimeMins);
            this.Controls.Add(this.setTimeSec);
            this.Controls.Add(this.totalForce);
            this.Controls.Add(this.currentTime);
            this.Controls.Add(this.forceAccruedHeader);
            this.Controls.Add(this.currTimeHeader);
            this.Controls.Add(this.timeSetHeader);
            this.Controls.Add(this.headerLabel);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.plusIcon);
            this.Controls.Add(this.minusIcon);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "targeted_total_of_time";
            this.Size = new System.Drawing.Size(2481, 1087);
            this.Load += new System.EventHandler(this.home_user2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button minusIcon;
        private System.Windows.Forms.Button plusIcon;
        private OutlineButton button1;
        private OutlineButton button2;
        private OutlineButton resetButton;
        private Header1 headerLabel;
        private H2 timeSetHeader;
        private H2 currTimeHeader;
        private H2 forceAccruedHeader;
        private BigInfo currentTime;
        private BigInfo totalForce;
        private BigInfo setTimeSec;
        private BigInfo setTimeMins;
        private BigInfo setTimeColon;
    }
}

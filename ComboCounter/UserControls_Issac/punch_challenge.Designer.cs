using ComboCounter.Classes;
using ComboCounter.CustomControls;

namespace ComboCounter.UserControls
{
    partial class punch_challenge
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.startButton = new ComboCounter.CustomControls.OutlineButton();
            this.minusIcon = new ComboCounter.CustomControls.TextButton();
            this.plusIcon = new ComboCounter.CustomControls.TextButton();
            this.header = new ComboCounter.Classes.Header1();
            this.limit = new ComboCounter.Classes.BigInfo();
            this.totalForceHeader = new ComboCounter.Classes.H2();
            this.punchGoalHeader = new ComboCounter.Classes.H2();
            this.punchNum = new ComboCounter.Classes.BigInfo();
            this.totalForce = new ComboCounter.Classes.BigInfo();
            this.stopButton = new ComboCounter.CustomControls.OutlineButton();
            this.resetButton = new ComboCounter.CustomControls.OutlineButton();
            this.totalPunchHeader = new ComboCounter.Classes.H2();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // startButton
            // 
            this.startButton.AutoSize = true;
            this.startButton.BackColor = System.Drawing.Color.Transparent;
            this.startButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.startButton.Location = new System.Drawing.Point(1264, 887);
            this.startButton.Margin = new System.Windows.Forms.Padding(4);
            this.startButton.Name = "startButton";
            this.startButton.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.startButton.Size = new System.Drawing.Size(268, 94);
            this.startButton.TabIndex = 16;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // minusIcon
            // 
            this.minusIcon.AutoSize = true;
            this.minusIcon.BackColor = System.Drawing.Color.Transparent;
            this.minusIcon.FlatAppearance.BorderSize = 0;
            this.minusIcon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minusIcon.Font = new System.Drawing.Font("Roboto Medium", 20F);
            this.minusIcon.Location = new System.Drawing.Point(1390, 521);
            this.minusIcon.Margin = new System.Windows.Forms.Padding(4);
            this.minusIcon.Name = "minusIcon";
            this.minusIcon.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.minusIcon.Size = new System.Drawing.Size(100, 79);
            this.minusIcon.TabIndex = 18;
            this.minusIcon.Text = "-";
            this.minusIcon.UseVisualStyleBackColor = true;
            this.minusIcon.Click += new System.EventHandler(this.minusIcon_Click_1);
            // 
            // plusIcon
            // 
            this.plusIcon.AutoSize = true;
            this.plusIcon.BackColor = System.Drawing.Color.Transparent;
            this.plusIcon.FlatAppearance.BorderSize = 0;
            this.plusIcon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.plusIcon.Font = new System.Drawing.Font("Roboto Medium", 20F);
            this.plusIcon.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.plusIcon.Location = new System.Drawing.Point(2038, 521);
            this.plusIcon.Margin = new System.Windows.Forms.Padding(4);
            this.plusIcon.Name = "plusIcon";
            this.plusIcon.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.plusIcon.Size = new System.Drawing.Size(82, 79);
            this.plusIcon.TabIndex = 17;
            this.plusIcon.Text = "+";
            this.plusIcon.UseVisualStyleBackColor = true;
            this.plusIcon.Click += new System.EventHandler(this.plusIcon_Click_1);
            // 
            // header
            // 
            this.header.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.header.Location = new System.Drawing.Point(282, 32);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(1838, 207);
            this.header.TabIndex = 56;
            this.header.Text = "Punch Challenge";
            this.header.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // limit
            // 
            this.limit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.limit.ForeColor = System.Drawing.Color.DarkRed;
            this.limit.Location = new System.Drawing.Point(1497, 447);
            this.limit.Name = "limit";
            this.limit.Size = new System.Drawing.Size(489, 225);
            this.limit.TabIndex = 60;
            this.limit.Text = "100";
            this.limit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // totalForceHeader
            // 
            this.totalForceHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.totalForceHeader.Location = new System.Drawing.Point(156, 621);
            this.totalForceHeader.Name = "totalForceHeader";
            this.totalForceHeader.Size = new System.Drawing.Size(949, 176);
            this.totalForceHeader.TabIndex = 61;
            this.totalForceHeader.Text = "Total Force";
            this.totalForceHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.totalForceHeader.Click += new System.EventHandler(this.label2_Click);
            // 
            // punchGoalHeader
            // 
            this.punchGoalHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.punchGoalHeader.Location = new System.Drawing.Point(1274, 275);
            this.punchGoalHeader.Name = "punchGoalHeader";
            this.punchGoalHeader.Size = new System.Drawing.Size(953, 172);
            this.punchGoalHeader.TabIndex = 62;
            this.punchGoalHeader.Text = "Punch Goal";
            this.punchGoalHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.punchGoalHeader.Click += new System.EventHandler(this.label1_Click);
            // 
            // punchNum
            // 
            this.punchNum.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.punchNum.Location = new System.Drawing.Point(395, 412);
            this.punchNum.Name = "punchNum";
            this.punchNum.Size = new System.Drawing.Size(512, 244);
            this.punchNum.TabIndex = 63;
            this.punchNum.Text = "0";
            this.punchNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // totalForce
            // 
            this.totalForce.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.totalForce.Location = new System.Drawing.Point(411, 782);
            this.totalForce.Name = "totalForce";
            this.totalForce.Size = new System.Drawing.Size(477, 244);
            this.totalForce.TabIndex = 64;
            this.totalForce.Text = "0";
            this.totalForce.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // stopButton
            // 
            this.stopButton.AutoSize = true;
            this.stopButton.BackColor = System.Drawing.Color.Transparent;
            this.stopButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stopButton.ForeColor = System.Drawing.Color.Red;
            this.stopButton.Location = new System.Drawing.Point(1608, 887);
            this.stopButton.Name = "stopButton";
            this.stopButton.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.stopButton.Size = new System.Drawing.Size(268, 94);
            this.stopButton.TabIndex = 65;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.AutoSize = true;
            this.resetButton.BackColor = System.Drawing.Color.Transparent;
            this.resetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resetButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.resetButton.Location = new System.Drawing.Point(1948, 887);
            this.resetButton.Name = "resetButton";
            this.resetButton.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.resetButton.Size = new System.Drawing.Size(268, 94);
            this.resetButton.TabIndex = 78;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // totalPunchHeader
            // 
            this.totalPunchHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.totalPunchHeader.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.totalPunchHeader.Location = new System.Drawing.Point(156, 263);
            this.totalPunchHeader.Name = "totalPunchHeader";
            this.totalPunchHeader.Size = new System.Drawing.Size(949, 178);
            this.totalPunchHeader.TabIndex = 79;
            this.totalPunchHeader.Text = "Total Punches";
            this.totalPunchHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // punch_challenge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.totalPunchHeader);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.totalForce);
            this.Controls.Add(this.punchNum);
            this.Controls.Add(this.punchGoalHeader);
            this.Controls.Add(this.totalForceHeader);
            this.Controls.Add(this.limit);
            this.Controls.Add(this.header);
            this.Controls.Add(this.minusIcon);
            this.Controls.Add(this.plusIcon);
            this.Controls.Add(this.startButton);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "punch_challenge";
            this.Size = new System.Drawing.Size(2476, 1079);
            this.Load += new System.EventHandler(this.consecutive_punch_challenge_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private OutlineButton startButton;
        private TextButton plusIcon;
        private TextButton minusIcon;
        private Header1 header;
        private BigInfo limit;
        private H2 totalForceHeader;
        private H2 punchGoalHeader;
        private BigInfo punchNum;
        private BigInfo totalForce;
        private OutlineButton stopButton;
        private OutlineButton resetButton;
        private H2 totalPunchHeader;
    }
}

using ComboCounter.Classes;
using ComboCounter.CustomControls;

namespace ComboCounter.UserControls
{
    partial class targeted_total_of_force
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(targeted_total_of_force));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.startButton = new OutlineButton();
            this.resetButton = new OutlineButton();
            this.stopButton = new OutlineButton();
            this.header = new Header1();
            this.forceGoalHeader = new H2();
            this.currTimeHeader = new H2();
            this.forceAccruedHeader = new H2();
            this.forceGoal = new BigInfo();
            this.totalForce = new BigInfo();
            this.txtResult = new BigInfo();
            this.plusIcon = new System.Windows.Forms.Button();
            this.minusIcon = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // startButton
            // 
            this.startButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startButton.ForeColor = System.Drawing.Color.Lime;
            this.startButton.Location = new System.Drawing.Point(994, 676);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(201, 76);
            this.startButton.TabIndex = 17;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resetButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.resetButton.Location = new System.Drawing.Point(1578, 676);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(201, 76);
            this.resetButton.TabIndex = 18;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stopButton.ForeColor = System.Drawing.Color.Red;
            this.stopButton.Location = new System.Drawing.Point(1294, 676);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(201, 76);
            this.stopButton.TabIndex = 19;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // label7
            // 
            this.header.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.header.AutoSize = true;
            this.header.ForeColor = System.Drawing.Color.SteelBlue;
            this.header.Location = new System.Drawing.Point(361, 38);
            this.header.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.header.Name = "label7";
            this.header.Size = new System.Drawing.Size(1081, 122);
            this.header.TabIndex = 57;
            this.header.Text = "Targeted Total of  Force";
            // 
            // label6
            // 
            this.forceGoalHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.forceGoalHeader.AutoSize = true;
            this.forceGoalHeader.ForeColor = System.Drawing.Color.SteelBlue;
            this.forceGoalHeader.Location = new System.Drawing.Point(172, 233);
            this.forceGoalHeader.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.forceGoalHeader.Name = "label6";
            this.forceGoalHeader.Size = new System.Drawing.Size(476, 109);
            this.forceGoalHeader.TabIndex = 66;
            this.forceGoalHeader.Text = "Force Goal";
            // 
            // label8
            // 
            this.currTimeHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.currTimeHeader.AutoSize = true;
            this.currTimeHeader.ForeColor = System.Drawing.Color.SteelBlue;
            this.currTimeHeader.Location = new System.Drawing.Point(1106, 233);
            this.currTimeHeader.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.currTimeHeader.Name = "label8";
            this.currTimeHeader.Size = new System.Drawing.Size(564, 109);
            this.currTimeHeader.TabIndex = 67;
            this.currTimeHeader.Text = "Current Time";
            this.currTimeHeader.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.forceAccruedHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.forceAccruedHeader.AutoSize = true;
            this.forceAccruedHeader.ForeColor = System.Drawing.Color.SteelBlue;
            this.forceAccruedHeader.Location = new System.Drawing.Point(113, 543);
            this.forceAccruedHeader.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.forceAccruedHeader.Name = "label9";
            this.forceAccruedHeader.Size = new System.Drawing.Size(610, 109);
            this.forceAccruedHeader.TabIndex = 68;
            this.forceAccruedHeader.Text = "Force Accrued";
            // 
            // forceGoal
            // 
            this.forceGoal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.forceGoal.AutoSize = true;
            this.forceGoal.ForeColor = System.Drawing.Color.DimGray;
            this.forceGoal.Location = new System.Drawing.Point(149, 342);
            this.forceGoal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.forceGoal.Name = "forceGoal";
            this.forceGoal.Size = new System.Drawing.Size(515, 179);
            this.forceGoal.TabIndex = 75;
            this.forceGoal.Text = "15,000";
            // 
            // totalForce
            // 
            this.totalForce.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.totalForce.AutoSize = true;
            this.totalForce.ForeColor = System.Drawing.Color.DimGray;
            this.totalForce.Location = new System.Drawing.Point(158, 643);
            this.totalForce.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.totalForce.Name = "totalForce";
            this.totalForce.Size = new System.Drawing.Size(169, 194);
            this.totalForce.TabIndex = 76;
            this.totalForce.Text = "0";
            // 
            // txtResult
            // 
            this.txtResult.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtResult.AutoSize = true;
            this.txtResult.ForeColor = System.Drawing.Color.DimGray;
            this.txtResult.Location = new System.Drawing.Point(1078, 342);
            this.txtResult.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(608, 194);
            this.txtResult.TabIndex = 77;
            this.txtResult.Text = "00:00.0";
            // 
            // plusIcon
            // 
            this.plusIcon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("plusIcon.BackgroundImage")));
            this.plusIcon.FlatAppearance.BorderSize = 0;
            this.plusIcon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.plusIcon.Location = new System.Drawing.Point(651, 409);
            this.plusIcon.Name = "plusIcon";
            this.plusIcon.Size = new System.Drawing.Size(51, 47);
            this.plusIcon.TabIndex = 78;
            this.plusIcon.UseVisualStyleBackColor = true;
            this.plusIcon.Click += new System.EventHandler(this.plusIcon_Click);
            // 
            // minusIcon
            // 
            this.minusIcon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("minusIcon.BackgroundImage")));
            this.minusIcon.FlatAppearance.BorderSize = 0;
            this.minusIcon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minusIcon.Location = new System.Drawing.Point(94, 397);
            this.minusIcon.Name = "minusIcon";
            this.minusIcon.Size = new System.Drawing.Size(50, 59);
            this.minusIcon.TabIndex = 79;
            this.minusIcon.UseVisualStyleBackColor = true;
            this.minusIcon.Click += new System.EventHandler(this.minusIcon_Click);
            // 
            // targeted_total_of_force
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(23)))), ((int)(((byte)(30)))));
            this.Controls.Add(this.minusIcon);
            this.Controls.Add(this.plusIcon);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.totalForce);
            this.Controls.Add(this.forceGoal);
            this.Controls.Add(this.forceAccruedHeader);
            this.Controls.Add(this.currTimeHeader);
            this.Controls.Add(this.forceGoalHeader);
            this.Controls.Add(this.header);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.startButton);
            this.Name = "targeted_total_of_force";
            this.Size = new System.Drawing.Size(1866, 884);
            this.Load += new System.EventHandler(this.targeted_total_of_force_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Label header;
        private System.Windows.Forms.Label forceGoalHeader;
        private System.Windows.Forms.Label currTimeHeader;
        private System.Windows.Forms.Label forceAccruedHeader;
        private System.Windows.Forms.Label forceGoal;
        private System.Windows.Forms.Label totalForce;
        private System.Windows.Forms.Label txtResult;
        private System.Windows.Forms.Button plusIcon;
        private System.Windows.Forms.Button minusIcon;
    }
}

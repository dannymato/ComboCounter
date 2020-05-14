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
            this.startButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.forceGoal = new System.Windows.Forms.Label();
            this.totalForce = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.Label();
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
            this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.resetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.stopButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 80.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.SteelBlue;
            this.label7.Location = new System.Drawing.Point(361, 38);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(1081, 122);
            this.label7.TabIndex = 57;
            this.label7.Text = "Targeted Total of  Force";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.SteelBlue;
            this.label6.Location = new System.Drawing.Point(172, 233);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(476, 109);
            this.label6.TabIndex = 66;
            this.label6.Text = "Force Goal";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.SteelBlue;
            this.label8.Location = new System.Drawing.Point(1106, 233);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(564, 109);
            this.label8.TabIndex = 67;
            this.label8.Text = "Current Time";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.SteelBlue;
            this.label9.Location = new System.Drawing.Point(113, 543);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(610, 109);
            this.label9.TabIndex = 68;
            this.label9.Text = "Force Accrued";
            // 
            // forceGoal
            // 
            this.forceGoal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.forceGoal.AutoSize = true;
            this.forceGoal.Font = new System.Drawing.Font("Times New Roman", 120F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.totalForce.Font = new System.Drawing.Font("Times New Roman", 129.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.txtResult.Font = new System.Drawing.Font("Times New Roman", 129.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
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
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label forceGoal;
        private System.Windows.Forms.Label totalForce;
        private System.Windows.Forms.Label txtResult;
        private System.Windows.Forms.Button plusIcon;
        private System.Windows.Forms.Button minusIcon;
    }
}

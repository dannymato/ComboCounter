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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(punch_challenge));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.startButton = new System.Windows.Forms.Button();
            this.minusIcon = new System.Windows.Forms.Button();
            this.plusIcon = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.limit = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.punchNum = new System.Windows.Forms.Label();
            this.totalForce = new System.Windows.Forms.Label();
            this.stopButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // startButton
            // 
            this.startButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.startButton.Location = new System.Drawing.Point(948, 677);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(201, 76);
            this.startButton.TabIndex = 16;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // minusIcon
            // 
            this.minusIcon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("minusIcon.BackgroundImage")));
            this.minusIcon.FlatAppearance.BorderSize = 0;
            this.minusIcon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minusIcon.Location = new System.Drawing.Point(1086, 394);
            this.minusIcon.Name = "minusIcon";
            this.minusIcon.Size = new System.Drawing.Size(75, 64);
            this.minusIcon.TabIndex = 18;
            this.minusIcon.UseVisualStyleBackColor = true;
            this.minusIcon.Click += new System.EventHandler(this.minusIcon_Click_1);
            // 
            // plusIcon
            // 
            this.plusIcon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("plusIcon.BackgroundImage")));
            this.plusIcon.FlatAppearance.BorderSize = 0;
            this.plusIcon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.plusIcon.Location = new System.Drawing.Point(1443, 399);
            this.plusIcon.Name = "plusIcon";
            this.plusIcon.Size = new System.Drawing.Size(52, 55);
            this.plusIcon.TabIndex = 17;
            this.plusIcon.UseVisualStyleBackColor = true;
            this.plusIcon.Click += new System.EventHandler(this.plusIcon_Click_1);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 80.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.SteelBlue;
            this.label7.Location = new System.Drawing.Point(535, 51);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(782, 122);
            this.label7.TabIndex = 56;
            this.label7.Text = "Punch Challenge";
            // 
            // limit
            // 
            this.limit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.limit.AutoSize = true;
            this.limit.Font = new System.Drawing.Font("Times New Roman", 120F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.limit.ForeColor = System.Drawing.Color.DarkRed;
            this.limit.Location = new System.Drawing.Point(1138, 345);
            this.limit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.limit.Name = "limit";
            this.limit.Size = new System.Drawing.Size(315, 179);
            this.limit.TabIndex = 60;
            this.limit.Text = "100";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SteelBlue;
            this.label2.Location = new System.Drawing.Point(233, 509);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(486, 109);
            this.label2.TabIndex = 61;
            this.label2.Text = "Total Force";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(1036, 236);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(498, 109);
            this.label1.TabIndex = 62;
            this.label1.Text = "Punch Goal";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // punchNum
            // 
            this.punchNum.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.punchNum.AutoSize = true;
            this.punchNum.Font = new System.Drawing.Font("Times New Roman", 129.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.punchNum.ForeColor = System.Drawing.Color.Gray;
            this.punchNum.Location = new System.Drawing.Point(390, 332);
            this.punchNum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.punchNum.Name = "punchNum";
            this.punchNum.Size = new System.Drawing.Size(169, 194);
            this.punchNum.TabIndex = 63;
            this.punchNum.Text = "0";
            // 
            // totalForce
            // 
            this.totalForce.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.totalForce.AutoSize = true;
            this.totalForce.Font = new System.Drawing.Font("Times New Roman", 129.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalForce.ForeColor = System.Drawing.Color.DimGray;
            this.totalForce.Location = new System.Drawing.Point(317, 601);
            this.totalForce.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.totalForce.Name = "totalForce";
            this.totalForce.Size = new System.Drawing.Size(169, 194);
            this.totalForce.TabIndex = 64;
            this.totalForce.Text = "0";
            // 
            // stopButton
            // 
            this.stopButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stopButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stopButton.ForeColor = System.Drawing.Color.Red;
            this.stopButton.Location = new System.Drawing.Point(1206, 677);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(201, 76);
            this.stopButton.TabIndex = 65;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.resetButton.Location = new System.Drawing.Point(1461, 677);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(201, 76);
            this.resetButton.TabIndex = 78;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.SteelBlue;
            this.label3.Location = new System.Drawing.Point(188, 236);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(588, 109);
            this.label3.TabIndex = 79;
            this.label3.Text = "Total Punches";
            // 
            // punch_challenge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(23)))), ((int)(((byte)(30)))));
            this.Controls.Add(this.label3);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.totalForce);
            this.Controls.Add(this.punchNum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.limit);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.minusIcon);
            this.Controls.Add(this.plusIcon);
            this.Controls.Add(this.startButton);
            this.Name = "punch_challenge";
            this.Size = new System.Drawing.Size(1857, 877);
            this.Load += new System.EventHandler(this.consecutive_punch_challenge_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button plusIcon;
        private System.Windows.Forms.Button minusIcon;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label limit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label punchNum;
        private System.Windows.Forms.Label totalForce;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Label label3;
    }
}

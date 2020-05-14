namespace ComboCounter.UserControls
{
    partial class home_user2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(home_user2));
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.minusIcon = new System.Windows.Forms.Button();
            this.plusIcon = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.currentTime = new System.Windows.Forms.Label();
            this.totalForce = new System.Windows.Forms.Label();
            this.setTimeSec = new System.Windows.Forms.Label();
            this.setTimeMins = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button1.Location = new System.Drawing.Point(965, 705);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(201, 76);
            this.button1.TabIndex = 9;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button2.Location = new System.Drawing.Point(1235, 705);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(201, 76);
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
            this.minusIcon.Location = new System.Drawing.Point(227, 451);
            this.minusIcon.Name = "minusIcon";
            this.minusIcon.Size = new System.Drawing.Size(75, 64);
            this.minusIcon.TabIndex = 13;
            this.minusIcon.UseVisualStyleBackColor = true;
            this.minusIcon.Click += new System.EventHandler(this.minusIcon_Click);
            // 
            // plusIcon
            // 
            this.plusIcon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("plusIcon.BackgroundImage")));
            this.plusIcon.FlatAppearance.BorderSize = 0;
            this.plusIcon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.plusIcon.Location = new System.Drawing.Point(768, 457);
            this.plusIcon.Name = "plusIcon";
            this.plusIcon.Size = new System.Drawing.Size(52, 53);
            this.plusIcon.TabIndex = 14;
            this.plusIcon.UseVisualStyleBackColor = true;
            this.plusIcon.Click += new System.EventHandler(this.plusIcon_Click);
            // 
            // resetButton
            // 
            this.resetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.resetButton.Location = new System.Drawing.Point(1519, 705);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(201, 76);
            this.resetButton.TabIndex = 16;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 80.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.SteelBlue;
            this.label7.Location = new System.Drawing.Point(409, 49);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(1027, 122);
            this.label7.TabIndex = 56;
            this.label7.Text = "Targeted Total of Time";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.SteelBlue;
            this.label3.Location = new System.Drawing.Point(258, 276);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(544, 109);
            this.label3.TabIndex = 57;
            this.label3.Text = "Time Setting";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.SteelBlue;
            this.label5.Location = new System.Drawing.Point(1058, 276);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(564, 109);
            this.label5.TabIndex = 58;
            this.label5.Text = "Current Time";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.SteelBlue;
            this.label9.Location = new System.Drawing.Point(258, 561);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(610, 109);
            this.label9.TabIndex = 69;
            this.label9.Text = "Force Accrued";
            // 
            // currentTime
            // 
            this.currentTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.currentTime.AutoSize = true;
            this.currentTime.Font = new System.Drawing.Font("Times New Roman", 129.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentTime.ForeColor = System.Drawing.Color.DimGray;
            this.currentTime.Location = new System.Drawing.Point(1044, 385);
            this.currentTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.currentTime.Name = "currentTime";
            this.currentTime.Size = new System.Drawing.Size(608, 194);
            this.currentTime.TabIndex = 78;
            this.currentTime.Text = "00:00.0";
            // 
            // totalForce
            // 
            this.totalForce.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.totalForce.AutoSize = true;
            this.totalForce.Font = new System.Drawing.Font("Times New Roman", 129.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalForce.ForeColor = System.Drawing.Color.Maroon;
            this.totalForce.Location = new System.Drawing.Point(374, 653);
            this.totalForce.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.totalForce.Name = "totalForce";
            this.totalForce.Size = new System.Drawing.Size(169, 194);
            this.totalForce.TabIndex = 79;
            this.totalForce.Text = "0";
            // 
            // setTimeSec
            // 
            this.setTimeSec.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.setTimeSec.AutoSize = true;
            this.setTimeSec.Font = new System.Drawing.Font("Times New Roman", 129.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setTimeSec.ForeColor = System.Drawing.Color.DimGray;
            this.setTimeSec.Location = new System.Drawing.Point(525, 385);
            this.setTimeSec.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.setTimeSec.Name = "setTimeSec";
            this.setTimeSec.Size = new System.Drawing.Size(256, 194);
            this.setTimeSec.TabIndex = 80;
            this.setTimeSec.Text = "30";
            this.setTimeSec.Click += new System.EventHandler(this.setTimeSec_Click);
            // 
            // setTimeMins
            // 
            this.setTimeMins.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.setTimeMins.AutoSize = true;
            this.setTimeMins.Font = new System.Drawing.Font("Times New Roman", 129.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setTimeMins.ForeColor = System.Drawing.Color.DimGray;
            this.setTimeMins.Location = new System.Drawing.Point(273, 385);
            this.setTimeMins.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.setTimeMins.Name = "setTimeMins";
            this.setTimeMins.Size = new System.Drawing.Size(256, 194);
            this.setTimeMins.TabIndex = 81;
            this.setTimeMins.Text = "00";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 90F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DimGray;
            this.label8.Location = new System.Drawing.Point(474, 410);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 136);
            this.label8.TabIndex = 82;
            this.label8.Text = ":";
            // 
            // home_user2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(23)))), ((int)(((byte)(30)))));
            this.Controls.Add(this.label8);
            this.Controls.Add(this.setTimeMins);
            this.Controls.Add(this.setTimeSec);
            this.Controls.Add(this.totalForce);
            this.Controls.Add(this.currentTime);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.plusIcon);
            this.Controls.Add(this.minusIcon);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "home_user2";
            this.Size = new System.Drawing.Size(1861, 883);
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button minusIcon;
        private System.Windows.Forms.Button plusIcon;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label currentTime;
        private System.Windows.Forms.Label totalForce;
        private System.Windows.Forms.Label setTimeSec;
        private System.Windows.Forms.Label setTimeMins;
        private System.Windows.Forms.Label label8;
    }
}

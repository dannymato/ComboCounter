namespace ComboCounter.UserControls
{
    partial class punch_challenge_comp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(punch_challenge_comp));
            this.plusIcon = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.minusIcon = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.startButton1 = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.stopButton1 = new System.Windows.Forms.Button();
            this.resetButton1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.limit = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.punchNum = new System.Windows.Forms.Label();
            this.punchNum1 = new System.Windows.Forms.Label();
            this.totalForce = new System.Windows.Forms.Label();
            this.totalForce1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // plusIcon
            // 
            this.plusIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(23)))), ((int)(((byte)(30)))));
            this.plusIcon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("plusIcon.BackgroundImage")));
            this.plusIcon.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(23)))), ((int)(((byte)(30)))));
            this.plusIcon.FlatAppearance.BorderSize = 0;
            this.plusIcon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.plusIcon.ForeColor = System.Drawing.Color.Transparent;
            this.plusIcon.Location = new System.Drawing.Point(978, 198);
            this.plusIcon.Name = "plusIcon";
            this.plusIcon.Size = new System.Drawing.Size(50, 54);
            this.plusIcon.TabIndex = 44;
            this.plusIcon.UseVisualStyleBackColor = false;
            this.plusIcon.Click += new System.EventHandler(this.plusIcon_Click);
            // 
            // startButton
            // 
            this.startButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.startButton.Location = new System.Drawing.Point(52, 445);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(156, 61);
            this.startButton.TabIndex = 51;
            this.startButton.Text = "Start";
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // minusIcon
            // 
            this.minusIcon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("minusIcon.BackgroundImage")));
            this.minusIcon.FlatAppearance.BorderSize = 0;
            this.minusIcon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minusIcon.ForeColor = System.Drawing.Color.Transparent;
            this.minusIcon.Location = new System.Drawing.Point(739, 195);
            this.minusIcon.Name = "minusIcon";
            this.minusIcon.Size = new System.Drawing.Size(72, 61);
            this.minusIcon.TabIndex = 50;
            this.minusIcon.UseVisualStyleBackColor = false;
            this.minusIcon.Click += new System.EventHandler(this.minusIcon_Click);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // startButton1
            // 
            this.startButton1.Cursor = System.Windows.Forms.Cursors.Default;
            this.startButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.startButton1.Location = new System.Drawing.Point(1605, 445);
            this.startButton1.Name = "startButton1";
            this.startButton1.Size = new System.Drawing.Size(163, 61);
            this.startButton1.TabIndex = 52;
            this.startButton1.Text = "Start";
            this.startButton1.UseVisualStyleBackColor = true;
            this.startButton1.Click += new System.EventHandler(this.startButton1_Click);
            // 
            // stopButton
            // 
            this.stopButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stopButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stopButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.stopButton.Location = new System.Drawing.Point(52, 591);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(156, 61);
            this.stopButton.TabIndex = 53;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // resetButton
            // 
            this.resetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.resetButton.Location = new System.Drawing.Point(52, 735);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(156, 61);
            this.resetButton.TabIndex = 54;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // stopButton1
            // 
            this.stopButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stopButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stopButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.stopButton1.Location = new System.Drawing.Point(1605, 591);
            this.stopButton1.Name = "stopButton1";
            this.stopButton1.Size = new System.Drawing.Size(163, 61);
            this.stopButton1.TabIndex = 55;
            this.stopButton1.Text = "Stop";
            this.stopButton1.UseVisualStyleBackColor = true;
            this.stopButton1.Click += new System.EventHandler(this.stopButton1_Click);
            // 
            // resetButton1
            // 
            this.resetButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resetButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.resetButton1.Location = new System.Drawing.Point(1605, 735);
            this.resetButton1.Name = "resetButton1";
            this.resetButton1.Size = new System.Drawing.Size(163, 61);
            this.resetButton1.TabIndex = 56;
            this.resetButton1.Text = "Reset";
            this.resetButton1.UseVisualStyleBackColor = true;
            this.resetButton1.Click += new System.EventHandler(this.resetButton1_Click);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.SteelBlue;
            this.label7.Location = new System.Drawing.Point(333, 31);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(1207, 109);
            this.label7.TabIndex = 57;
            this.label7.Text = "Punch Challenge Competition";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Gray;
            this.label10.Location = new System.Drawing.Point(453, 309);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(229, 73);
            this.label10.TabIndex = 71;
            this.label10.Text = "Guest 1";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Silver;
            this.label11.Location = new System.Drawing.Point(1081, 309);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(229, 73);
            this.label11.TabIndex = 72;
            this.label11.Text = "Guest 2";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.SteelBlue;
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ForeColor = System.Drawing.Color.SteelBlue;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(876, 325);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(11, 559);
            this.tableLayoutPanel2.TabIndex = 73;
            // 
            // limit
            // 
            this.limit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.limit.AutoSize = true;
            this.limit.Font = new System.Drawing.Font("Times New Roman", 99.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.limit.ForeColor = System.Drawing.Color.DarkRed;
            this.limit.Location = new System.Drawing.Point(789, 159);
            this.limit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.limit.Name = "limit";
            this.limit.Size = new System.Drawing.Size(198, 151);
            this.limit.TabIndex = 74;
            this.limit.Text = "20";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SteelBlue;
            this.label2.Location = new System.Drawing.Point(1016, 408);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(392, 73);
            this.label2.TabIndex = 76;
            this.label2.Text = "Total Punches";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.SteelBlue;
            this.label3.Location = new System.Drawing.Point(398, 631);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(323, 73);
            this.label3.TabIndex = 77;
            this.label3.Text = "Total Force";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.SteelBlue;
            this.label4.Location = new System.Drawing.Point(1054, 620);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(323, 73);
            this.label4.TabIndex = 78;
            this.label4.Text = "Total Force";
            // 
            // punchNum
            // 
            this.punchNum.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.punchNum.AutoSize = true;
            this.punchNum.Font = new System.Drawing.Font("Times New Roman", 99.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.punchNum.ForeColor = System.Drawing.Color.DimGray;
            this.punchNum.Location = new System.Drawing.Point(490, 480);
            this.punchNum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.punchNum.Name = "punchNum";
            this.punchNum.Size = new System.Drawing.Size(131, 151);
            this.punchNum.TabIndex = 79;
            this.punchNum.Text = "0";
            // 
            // punchNum1
            // 
            this.punchNum1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.punchNum1.AutoSize = true;
            this.punchNum1.Font = new System.Drawing.Font("Times New Roman", 99.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.punchNum1.ForeColor = System.Drawing.Color.DimGray;
            this.punchNum1.Location = new System.Drawing.Point(1129, 469);
            this.punchNum1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.punchNum1.Name = "punchNum1";
            this.punchNum1.Size = new System.Drawing.Size(131, 151);
            this.punchNum1.TabIndex = 80;
            this.punchNum1.Text = "0";
            // 
            // totalForce
            // 
            this.totalForce.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.totalForce.AutoSize = true;
            this.totalForce.Font = new System.Drawing.Font("Times New Roman", 99.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalForce.ForeColor = System.Drawing.Color.DimGray;
            this.totalForce.Location = new System.Drawing.Point(440, 693);
            this.totalForce.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.totalForce.Name = "totalForce";
            this.totalForce.Size = new System.Drawing.Size(131, 151);
            this.totalForce.TabIndex = 81;
            this.totalForce.Text = "0";
            // 
            // totalForce1
            // 
            this.totalForce1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.totalForce1.AutoSize = true;
            this.totalForce1.Font = new System.Drawing.Font("Times New Roman", 99.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalForce1.ForeColor = System.Drawing.Color.DimGray;
            this.totalForce1.Location = new System.Drawing.Point(1099, 693);
            this.totalForce1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.totalForce1.Name = "totalForce1";
            this.totalForce1.Size = new System.Drawing.Size(131, 151);
            this.totalForce1.TabIndex = 82;
            this.totalForce1.Text = "0";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.SteelBlue;
            this.label5.Location = new System.Drawing.Point(359, 408);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(392, 73);
            this.label5.TabIndex = 83;
            this.label5.Text = "Total Punches";
            // 
            // punch_challenge_comp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(23)))), ((int)(((byte)(30)))));
            this.Controls.Add(this.label5);
            this.Controls.Add(this.totalForce1);
            this.Controls.Add(this.totalForce);
            this.Controls.Add(this.punchNum1);
            this.Controls.Add(this.punchNum);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.limit);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.resetButton1);
            this.Controls.Add(this.stopButton1);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.startButton1);
            this.Controls.Add(this.minusIcon);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.plusIcon);
            this.Name = "punch_challenge_comp";
            this.Size = new System.Drawing.Size(1856, 904);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button plusIcon;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button minusIcon;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button startButton1;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button stopButton1;
        private System.Windows.Forms.Button resetButton1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label limit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label punchNum;
        private System.Windows.Forms.Label punchNum1;
        private System.Windows.Forms.Label totalForce;
        private System.Windows.Forms.Label totalForce1;
        private System.Windows.Forms.Label label5;
    }
}

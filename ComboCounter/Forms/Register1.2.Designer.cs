namespace ComboCounter.Forms
{
    partial class Register1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register1));
            this.username_tb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.fNameBox = new System.Windows.Forms.TextBox();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.emailBox = new System.Windows.Forms.TextBox();
            this.sexBox = new System.Windows.Forms.TextBox();
            this.classBox = new System.Windows.Forms.TextBox();
            this.lNameBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.heightBox = new System.Windows.Forms.TextBox();
            this.weightBox = new System.Windows.Forms.TextBox();
            this.monthBox = new System.Windows.Forms.TextBox();
            this.yearBox = new System.Windows.Forms.TextBox();
            this.dayBox = new System.Windows.Forms.TextBox();
            this.submit_b = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // username_tb
            // 
            this.username_tb.BackColor = System.Drawing.SystemColors.WindowText;
            this.username_tb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.username_tb.Font = new System.Drawing.Font("Microsoft Yi Baiti", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_tb.ForeColor = System.Drawing.Color.Gainsboro;
            this.username_tb.Location = new System.Drawing.Point(64, 171);
            this.username_tb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.username_tb.Name = "username_tb";
            this.username_tb.Size = new System.Drawing.Size(547, 38);
            this.username_tb.TabIndex = 0;
            this.username_tb.Text = "Username";
            this.username_tb.TextChanged += new System.EventHandler(this.username_tb_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.CadetBlue;
            this.label1.Location = new System.Drawing.Point(152, 100);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(338, 54);
            this.label1.TabIndex = 12;
            this.label1.Text = "Create an account";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // fNameBox
            // 
            this.fNameBox.BackColor = System.Drawing.SystemColors.WindowText;
            this.fNameBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fNameBox.Font = new System.Drawing.Font("Microsoft Yi Baiti", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fNameBox.ForeColor = System.Drawing.Color.Gainsboro;
            this.fNameBox.Location = new System.Drawing.Point(63, 288);
            this.fNameBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fNameBox.Name = "fNameBox";
            this.fNameBox.Size = new System.Drawing.Size(253, 38);
            this.fNameBox.TabIndex = 2;
            this.fNameBox.Text = "First Name";
            this.fNameBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // passwordBox
            // 
            this.passwordBox.BackColor = System.Drawing.SystemColors.WindowText;
            this.passwordBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passwordBox.Font = new System.Drawing.Font("Microsoft Yi Baiti", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordBox.ForeColor = System.Drawing.Color.Gainsboro;
            this.passwordBox.Location = new System.Drawing.Point(64, 231);
            this.passwordBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(547, 38);
            this.passwordBox.TabIndex = 1;
            this.passwordBox.Text = "Password";
            this.passwordBox.UseSystemPasswordChar = true;
            this.passwordBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // emailBox
            // 
            this.emailBox.BackColor = System.Drawing.SystemColors.WindowText;
            this.emailBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.emailBox.Font = new System.Drawing.Font("Microsoft Yi Baiti", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailBox.ForeColor = System.Drawing.Color.Gainsboro;
            this.emailBox.Location = new System.Drawing.Point(64, 345);
            this.emailBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(547, 38);
            this.emailBox.TabIndex = 4;
            this.emailBox.Text = "Email";
            // 
            // sexBox
            // 
            this.sexBox.BackColor = System.Drawing.SystemColors.WindowText;
            this.sexBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sexBox.Font = new System.Drawing.Font("Microsoft Yi Baiti", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sexBox.ForeColor = System.Drawing.Color.Gainsboro;
            this.sexBox.Location = new System.Drawing.Point(63, 455);
            this.sexBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sexBox.Name = "sexBox";
            this.sexBox.Size = new System.Drawing.Size(547, 38);
            this.sexBox.TabIndex = 8;
            this.sexBox.Text = "Sex";
            this.sexBox.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // classBox
            // 
            this.classBox.BackColor = System.Drawing.SystemColors.WindowText;
            this.classBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.classBox.Font = new System.Drawing.Font("Microsoft Yi Baiti", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classBox.ForeColor = System.Drawing.Color.Gainsboro;
            this.classBox.Location = new System.Drawing.Point(63, 512);
            this.classBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.classBox.Name = "classBox";
            this.classBox.Size = new System.Drawing.Size(547, 38);
            this.classBox.TabIndex = 9;
            this.classBox.Text = "Class";
            this.classBox.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // lNameBox
            // 
            this.lNameBox.BackColor = System.Drawing.SystemColors.WindowText;
            this.lNameBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lNameBox.Font = new System.Drawing.Font("Microsoft Yi Baiti", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNameBox.ForeColor = System.Drawing.Color.Gainsboro;
            this.lNameBox.Location = new System.Drawing.Point(357, 288);
            this.lNameBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lNameBox.Name = "lNameBox";
            this.lNameBox.Size = new System.Drawing.Size(254, 38);
            this.lNameBox.TabIndex = 3;
            this.lNameBox.Text = "Last Name";
            this.lNameBox.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(274, 11);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Padding = new System.Windows.Forms.Padding(25);
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // heightBox
            // 
            this.heightBox.BackColor = System.Drawing.SystemColors.WindowText;
            this.heightBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.heightBox.Font = new System.Drawing.Font("Microsoft Yi Baiti", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.heightBox.ForeColor = System.Drawing.Color.Gainsboro;
            this.heightBox.Location = new System.Drawing.Point(63, 570);
            this.heightBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.heightBox.Name = "heightBox";
            this.heightBox.Size = new System.Drawing.Size(253, 38);
            this.heightBox.TabIndex = 10;
            this.heightBox.Text = "Height";
            this.heightBox.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // weightBox
            // 
            this.weightBox.BackColor = System.Drawing.Color.Black;
            this.weightBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.weightBox.Font = new System.Drawing.Font("Microsoft Yi Baiti", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weightBox.ForeColor = System.Drawing.Color.Gainsboro;
            this.weightBox.Location = new System.Drawing.Point(359, 570);
            this.weightBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.weightBox.Name = "weightBox";
            this.weightBox.Size = new System.Drawing.Size(253, 38);
            this.weightBox.TabIndex = 11;
            this.weightBox.Text = "Weight";
            this.weightBox.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // monthBox
            // 
            this.monthBox.BackColor = System.Drawing.SystemColors.WindowText;
            this.monthBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.monthBox.Font = new System.Drawing.Font("Microsoft Yi Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthBox.ForeColor = System.Drawing.Color.LightGray;
            this.monthBox.Location = new System.Drawing.Point(64, 404);
            this.monthBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.monthBox.Name = "monthBox";
            this.monthBox.Size = new System.Drawing.Size(155, 34);
            this.monthBox.TabIndex = 5;
            this.monthBox.Text = "Birth Month";
            this.monthBox.TextChanged += new System.EventHandler(this.monthBox_TextChanged);
            // 
            // yearBox
            // 
            this.yearBox.BackColor = System.Drawing.SystemColors.WindowText;
            this.yearBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.yearBox.Font = new System.Drawing.Font("Microsoft Yi Baiti", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearBox.ForeColor = System.Drawing.Color.Gainsboro;
            this.yearBox.Location = new System.Drawing.Point(455, 400);
            this.yearBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.yearBox.Name = "yearBox";
            this.yearBox.Size = new System.Drawing.Size(155, 38);
            this.yearBox.TabIndex = 7;
            this.yearBox.Text = "Year";
            // 
            // dayBox
            // 
            this.dayBox.BackColor = System.Drawing.Color.Black;
            this.dayBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dayBox.Font = new System.Drawing.Font("Microsoft Yi Baiti", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dayBox.ForeColor = System.Drawing.Color.Gainsboro;
            this.dayBox.Location = new System.Drawing.Point(257, 400);
            this.dayBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dayBox.Name = "dayBox";
            this.dayBox.Size = new System.Drawing.Size(155, 38);
            this.dayBox.TabIndex = 6;
            this.dayBox.Text = "Day";
            this.dayBox.TextChanged += new System.EventHandler(this.dayBox_TextChanged);
            // 
            // submit_b
            // 
            this.submit_b.Cursor = System.Windows.Forms.Cursors.Default;
            this.submit_b.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.submit_b.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submit_b.ForeColor = System.Drawing.Color.CadetBlue;
            this.submit_b.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.submit_b.Location = new System.Drawing.Point(217, 657);
            this.submit_b.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.submit_b.Name = "submit_b";
            this.submit_b.Size = new System.Drawing.Size(228, 63);
            this.submit_b.TabIndex = 24;
            this.submit_b.Text = "Sign Up";
            this.submit_b.UseVisualStyleBackColor = true;
            this.submit_b.Click += new System.EventHandler(this.submit_b_Click);
            // 
            // backButton
            // 
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton.ForeColor = System.Drawing.Color.Turquoise;
            this.backButton.Location = new System.Drawing.Point(48, 27);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(103, 34);
            this.backButton.TabIndex = 25;
            this.backButton.Text = "Go Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // Register1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(23)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(675, 807);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.submit_b);
            this.Controls.Add(this.dayBox);
            this.Controls.Add(this.yearBox);
            this.Controls.Add(this.monthBox);
            this.Controls.Add(this.weightBox);
            this.Controls.Add(this.heightBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lNameBox);
            this.Controls.Add(this.classBox);
            this.Controls.Add(this.sexBox);
            this.Controls.Add(this.emailBox);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.fNameBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.username_tb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Register1";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Register1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox username_tb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox fNameBox;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.TextBox emailBox;
        private System.Windows.Forms.TextBox sexBox;
        private System.Windows.Forms.TextBox classBox;
        private System.Windows.Forms.TextBox lNameBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox heightBox;
        private System.Windows.Forms.TextBox weightBox;
        private System.Windows.Forms.TextBox monthBox;
        private System.Windows.Forms.TextBox dayBox;
        private System.Windows.Forms.Button submit_b;
        private System.Windows.Forms.TextBox yearBox;
        private System.Windows.Forms.Button backButton;
    }
}
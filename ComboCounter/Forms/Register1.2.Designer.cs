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
            this.fNameBox = new System.Windows.Forms.TextBox();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.emailBox = new System.Windows.Forms.TextBox();
            this.sexBox = new System.Windows.Forms.TextBox();
            this.lNameBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.heightBox = new System.Windows.Forms.TextBox();
            this.weightBox = new System.Windows.Forms.TextBox();
            this.yearBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new ComboCounter.Classes.H4();
            this.backButton = new ComboCounter.CustomControls.OutlineButton();
            this.submit_b = new ComboCounter.CustomControls.OutlineButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // username_tb
            // 
            this.username_tb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.username_tb.BackColor = System.Drawing.SystemColors.WindowText;
            this.username_tb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.username_tb.Font = new System.Drawing.Font("Microsoft Yi Baiti", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_tb.ForeColor = System.Drawing.Color.Gainsboro;
            this.username_tb.Location = new System.Drawing.Point(14, 81);
            this.username_tb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.username_tb.Name = "username_tb";
            this.username_tb.Size = new System.Drawing.Size(524, 38);
            this.username_tb.TabIndex = 0;
            this.username_tb.Text = "Username";
            this.username_tb.TextChanged += new System.EventHandler(this.username_tb_TextChanged);
            // 
            // fNameBox
            // 
            this.fNameBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.fNameBox.BackColor = System.Drawing.SystemColors.WindowText;
            this.fNameBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fNameBox.Font = new System.Drawing.Font("Microsoft Yi Baiti", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fNameBox.ForeColor = System.Drawing.Color.Gainsboro;
            this.fNameBox.Location = new System.Drawing.Point(5, 11);
            this.fNameBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fNameBox.Name = "fNameBox";
            this.fNameBox.Size = new System.Drawing.Size(263, 38);
            this.fNameBox.TabIndex = 2;
            this.fNameBox.Text = "First Name";
            this.fNameBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // passwordBox
            // 
            this.passwordBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passwordBox.BackColor = System.Drawing.SystemColors.WindowText;
            this.passwordBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passwordBox.Font = new System.Drawing.Font("Microsoft Yi Baiti", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordBox.ForeColor = System.Drawing.Color.Gainsboro;
            this.passwordBox.Location = new System.Drawing.Point(9, 148);
            this.passwordBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(533, 38);
            this.passwordBox.TabIndex = 1;
            this.passwordBox.Text = "Password";
            this.passwordBox.UseSystemPasswordChar = true;
            this.passwordBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // emailBox
            // 
            this.emailBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.emailBox.BackColor = System.Drawing.SystemColors.WindowText;
            this.emailBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.emailBox.Font = new System.Drawing.Font("Microsoft Yi Baiti", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailBox.ForeColor = System.Drawing.Color.Gainsboro;
            this.emailBox.Location = new System.Drawing.Point(7, 282);
            this.emailBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(537, 38);
            this.emailBox.TabIndex = 4;
            this.emailBox.Text = "Email";
            // 
            // sexBox
            // 
            this.sexBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sexBox.BackColor = System.Drawing.SystemColors.WindowText;
            this.sexBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sexBox.Font = new System.Drawing.Font("Microsoft Yi Baiti", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sexBox.ForeColor = System.Drawing.Color.Gainsboro;
            this.sexBox.Location = new System.Drawing.Point(8, 416);
            this.sexBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sexBox.Name = "sexBox";
            this.sexBox.Size = new System.Drawing.Size(536, 38);
            this.sexBox.TabIndex = 6;
            this.sexBox.Text = "Sex";
            this.sexBox.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // lNameBox
            // 
            this.lNameBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lNameBox.BackColor = System.Drawing.SystemColors.WindowText;
            this.lNameBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lNameBox.Font = new System.Drawing.Font("Microsoft Yi Baiti", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNameBox.ForeColor = System.Drawing.Color.Gainsboro;
            this.lNameBox.Location = new System.Drawing.Point(280, 11);
            this.lNameBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lNameBox.Name = "lNameBox";
            this.lNameBox.Size = new System.Drawing.Size(259, 38);
            this.lNameBox.TabIndex = 3;
            this.lNameBox.Text = "Last Name";
            this.lNameBox.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(289, 11);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Padding = new System.Windows.Forms.Padding(25);
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // heightBox
            // 
            this.heightBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.heightBox.BackColor = System.Drawing.SystemColors.WindowText;
            this.heightBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.heightBox.Font = new System.Drawing.Font("Microsoft Yi Baiti", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.heightBox.ForeColor = System.Drawing.Color.Gainsboro;
            this.heightBox.Location = new System.Drawing.Point(10, 483);
            this.heightBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.heightBox.Name = "heightBox";
            this.heightBox.Size = new System.Drawing.Size(531, 38);
            this.heightBox.TabIndex = 7;
            this.heightBox.Text = "Height";
            this.heightBox.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // weightBox
            // 
            this.weightBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.weightBox.BackColor = System.Drawing.Color.Black;
            this.weightBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.weightBox.Font = new System.Drawing.Font("Microsoft Yi Baiti", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weightBox.ForeColor = System.Drawing.Color.Gainsboro;
            this.weightBox.Location = new System.Drawing.Point(11, 550);
            this.weightBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.weightBox.Name = "weightBox";
            this.weightBox.Size = new System.Drawing.Size(529, 38);
            this.weightBox.TabIndex = 8;
            this.weightBox.Text = "Weight";
            this.weightBox.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // yearBox
            // 
            this.yearBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.yearBox.BackColor = System.Drawing.SystemColors.WindowText;
            this.yearBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.yearBox.Font = new System.Drawing.Font("Microsoft Yi Baiti", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearBox.ForeColor = System.Drawing.Color.Gainsboro;
            this.yearBox.Location = new System.Drawing.Point(9, 349);
            this.yearBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.yearBox.Name = "yearBox";
            this.yearBox.Size = new System.Drawing.Size(534, 38);
            this.yearBox.TabIndex = 5;
            this.yearBox.Text = "Year";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.username_tb, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.passwordBox, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.weightBox, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.yearBox, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.heightBox, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.emailBox, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.sexBox, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 9);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(66, 116);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 10;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(552, 679);
            this.tableLayoutPanel1.TabIndex = 26;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.fNameBox, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.lNameBox, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 204);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 61F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(546, 61);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.backButton, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.submit_b, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 606);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(546, 70);
            this.tableLayoutPanel3.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(161)))), ((int)(((byte)(242)))));
            this.label1.Location = new System.Drawing.Point(95, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(361, 54);
            this.label1.TabIndex = 12;
            this.label1.Text = "Create an account";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // backButton
            // 
            this.backButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.backButton.AutoSize = true;
            this.backButton.BackColor = System.Drawing.Color.Transparent;
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton.ForeColor = System.Drawing.Color.White;
            this.backButton.Location = new System.Drawing.Point(37, 3);
            this.backButton.Name = "backButton";
            this.backButton.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.backButton.Size = new System.Drawing.Size(199, 63);
            this.backButton.TabIndex = 0;
            this.backButton.Text = "Go Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // submit_b
            // 
            this.submit_b.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.submit_b.AutoSize = true;
            this.submit_b.BackColor = System.Drawing.Color.Transparent;
            this.submit_b.Cursor = System.Windows.Forms.Cursors.Default;
            this.submit_b.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.submit_b.ForeColor = System.Drawing.Color.White;
            this.submit_b.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.submit_b.Location = new System.Drawing.Point(302, 3);
            this.submit_b.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.submit_b.Name = "submit_b";
            this.submit_b.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.submit_b.Size = new System.Drawing.Size(214, 63);
            this.submit_b.TabIndex = 1;
            this.submit_b.Text = "Sign Up";
            this.submit_b.UseVisualStyleBackColor = true;
            this.submit_b.Click += new System.EventHandler(this.submit_b_Click);
            // 
            // Register1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(23)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(675, 842);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Register1";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Register1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox username_tb;
        private System.Windows.Forms.TextBox fNameBox;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.TextBox emailBox;
        private System.Windows.Forms.TextBox sexBox;
        private System.Windows.Forms.TextBox lNameBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox heightBox;
        private System.Windows.Forms.TextBox weightBox;
        private System.Windows.Forms.TextBox yearBox;
        private Classes.H4 label1;
        private CustomControls.OutlineButton submit_b;
        private CustomControls.OutlineButton backButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
    }
}
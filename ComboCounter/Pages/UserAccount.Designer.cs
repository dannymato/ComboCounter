namespace ComboCounter.UserControls_Gabriel
{
    partial class UserAccount
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
            this.username_tb = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.p2Fn = new System.Windows.Forms.TextBox();
            this.p2Ln = new System.Windows.Forms.TextBox();
            this.p2Sex = new System.Windows.Forms.TextBox();
            this.p2Height = new System.Windows.Forms.TextBox();
            this.p2Weight = new System.Windows.Forms.TextBox();
            this.submit_b = new System.Windows.Forms.Button();
            this.P1User = new System.Windows.Forms.TextBox();
            this.textBox18 = new System.Windows.Forms.TextBox();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.P1Name = new System.Windows.Forms.TextBox();
            this.textBox20 = new System.Windows.Forms.TextBox();
            this.P1Class = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ClassAccount = new ComboCounter.Classes.SmallInfo();
            this.SexAccount = new ComboCounter.Classes.SmallInfo();
            this.EmailAccount = new ComboCounter.Classes.SmallInfo();
            this.NameAccount = new ComboCounter.Classes.SmallInfo();
            this.UsernameAccount = new ComboCounter.Classes.SmallInfo();
            this.PasswordAccount = new ComboCounter.Classes.SmallInfo();
            this.panel2 = new System.Windows.Forms.Panel();
            this.header11 = new ComboCounter.Classes.Header1();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // username_tb
            // 
            this.username_tb.BackColor = System.Drawing.SystemColors.WindowText;
            this.username_tb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.username_tb.Font = new System.Drawing.Font("Microsoft Yi Baiti", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_tb.ForeColor = System.Drawing.Color.DimGray;
            this.username_tb.Location = new System.Drawing.Point(17, 67);
            this.username_tb.Margin = new System.Windows.Forms.Padding(2);
            this.username_tb.Name = "username_tb";
            this.username_tb.ReadOnly = true;
            this.username_tb.Size = new System.Drawing.Size(424, 32);
            this.username_tb.TabIndex = 65;
            this.username_tb.Text = "UserName";
            this.username_tb.Visible = false;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.WindowText;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Yi Baiti", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.DimGray;
            this.textBox2.Location = new System.Drawing.Point(17, 126);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(424, 32);
            this.textBox2.TabIndex = 66;
            this.textBox2.Text = "PassWord";
            this.textBox2.Visible = false;
            // 
            // p2Fn
            // 
            this.p2Fn.BackColor = System.Drawing.SystemColors.WindowText;
            this.p2Fn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.p2Fn.Font = new System.Drawing.Font("Microsoft Yi Baiti", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p2Fn.ForeColor = System.Drawing.Color.DimGray;
            this.p2Fn.Location = new System.Drawing.Point(17, 179);
            this.p2Fn.Margin = new System.Windows.Forms.Padding(2);
            this.p2Fn.Name = "p2Fn";
            this.p2Fn.Size = new System.Drawing.Size(218, 32);
            this.p2Fn.TabIndex = 67;
            this.p2Fn.Text = "First Name";
            this.p2Fn.Visible = false;
            this.p2Fn.TextChanged += new System.EventHandler(this.p2Fn_TextChanged);
            // 
            // p2Ln
            // 
            this.p2Ln.BackColor = System.Drawing.SystemColors.WindowText;
            this.p2Ln.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.p2Ln.Font = new System.Drawing.Font("Microsoft Yi Baiti", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p2Ln.ForeColor = System.Drawing.Color.DimGray;
            this.p2Ln.Location = new System.Drawing.Point(239, 179);
            this.p2Ln.Margin = new System.Windows.Forms.Padding(2);
            this.p2Ln.Name = "p2Ln";
            this.p2Ln.Size = new System.Drawing.Size(202, 32);
            this.p2Ln.TabIndex = 68;
            this.p2Ln.Text = "Last Name";
            this.p2Ln.Visible = false;
            this.p2Ln.TextChanged += new System.EventHandler(this.p2Ln_TextChanged);
            // 
            // p2Sex
            // 
            this.p2Sex.BackColor = System.Drawing.SystemColors.WindowText;
            this.p2Sex.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.p2Sex.Font = new System.Drawing.Font("Microsoft Yi Baiti", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p2Sex.ForeColor = System.Drawing.Color.DimGray;
            this.p2Sex.Location = new System.Drawing.Point(17, 231);
            this.p2Sex.Margin = new System.Windows.Forms.Padding(2);
            this.p2Sex.MaxLength = 1;
            this.p2Sex.Name = "p2Sex";
            this.p2Sex.Size = new System.Drawing.Size(424, 32);
            this.p2Sex.TabIndex = 70;
            this.p2Sex.Text = "Sex";
            this.p2Sex.Visible = false;
            this.p2Sex.TextChanged += new System.EventHandler(this.p2Sex_TextChanged);
            // 
            // p2Height
            // 
            this.p2Height.BackColor = System.Drawing.SystemColors.WindowText;
            this.p2Height.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.p2Height.Font = new System.Drawing.Font("Microsoft Yi Baiti", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p2Height.ForeColor = System.Drawing.Color.DimGray;
            this.p2Height.Location = new System.Drawing.Point(17, 287);
            this.p2Height.Margin = new System.Windows.Forms.Padding(2);
            this.p2Height.Name = "p2Height";
            this.p2Height.Size = new System.Drawing.Size(242, 32);
            this.p2Height.TabIndex = 72;
            this.p2Height.Text = "Height";
            this.p2Height.Visible = false;
            this.p2Height.TextChanged += new System.EventHandler(this.p2Height_TextChanged);
            // 
            // p2Weight
            // 
            this.p2Weight.BackColor = System.Drawing.Color.Black;
            this.p2Weight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.p2Weight.Font = new System.Drawing.Font("Microsoft Yi Baiti", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p2Weight.ForeColor = System.Drawing.Color.DimGray;
            this.p2Weight.Location = new System.Drawing.Point(263, 287);
            this.p2Weight.Margin = new System.Windows.Forms.Padding(2);
            this.p2Weight.Name = "p2Weight";
            this.p2Weight.Size = new System.Drawing.Size(178, 32);
            this.p2Weight.TabIndex = 73;
            this.p2Weight.Text = "Weight";
            this.p2Weight.Visible = false;
            this.p2Weight.TextChanged += new System.EventHandler(this.p2Weight_TextChanged);
            // 
            // submit_b
            // 
            this.submit_b.Cursor = System.Windows.Forms.Cursors.Default;
            this.submit_b.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.submit_b.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submit_b.ForeColor = System.Drawing.Color.DarkGray;
            this.submit_b.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.submit_b.Location = new System.Drawing.Point(133, 464);
            this.submit_b.Margin = new System.Windows.Forms.Padding(2);
            this.submit_b.Name = "submit_b";
            this.submit_b.Size = new System.Drawing.Size(171, 51);
            this.submit_b.TabIndex = 74;
            this.submit_b.Text = "Save";
            this.submit_b.UseVisualStyleBackColor = true;
            this.submit_b.Visible = false;
            this.submit_b.Click += new System.EventHandler(this.submit_b_Click);
            // 
            // P1User
            // 
            this.P1User.BackColor = System.Drawing.SystemColors.WindowText;
            this.P1User.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.P1User.Font = new System.Drawing.Font("Microsoft Yi Baiti", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.P1User.ForeColor = System.Drawing.Color.DimGray;
            this.P1User.Location = new System.Drawing.Point(28, 59);
            this.P1User.Margin = new System.Windows.Forms.Padding(2);
            this.P1User.Name = "P1User";
            this.P1User.Size = new System.Drawing.Size(438, 32);
            this.P1User.TabIndex = 90;
            this.P1User.Text = "UserName";
            // 
            // textBox18
            // 
            this.textBox18.BackColor = System.Drawing.SystemColors.WindowText;
            this.textBox18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox18.Font = new System.Drawing.Font("Microsoft Yi Baiti", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox18.ForeColor = System.Drawing.Color.DimGray;
            this.textBox18.Location = new System.Drawing.Point(28, 153);
            this.textBox18.Margin = new System.Windows.Forms.Padding(2);
            this.textBox18.Name = "textBox18";
            this.textBox18.Size = new System.Drawing.Size(438, 32);
            this.textBox18.TabIndex = 91;
            this.textBox18.Text = "PassWord";
            // 
            // textBox16
            // 
            this.textBox16.BackColor = System.Drawing.SystemColors.WindowText;
            this.textBox16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox16.Font = new System.Drawing.Font("Microsoft Yi Baiti", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox16.ForeColor = System.Drawing.Color.DimGray;
            this.textBox16.Location = new System.Drawing.Point(28, 344);
            this.textBox16.Margin = new System.Windows.Forms.Padding(2);
            this.textBox16.Name = "textBox16";
            this.textBox16.Size = new System.Drawing.Size(438, 32);
            this.textBox16.TabIndex = 92;
            this.textBox16.Text = "Email";
            // 
            // P1Name
            // 
            this.P1Name.BackColor = System.Drawing.SystemColors.WindowText;
            this.P1Name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.P1Name.Font = new System.Drawing.Font("Microsoft Yi Baiti", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.P1Name.ForeColor = System.Drawing.Color.DimGray;
            this.P1Name.Location = new System.Drawing.Point(28, 246);
            this.P1Name.Margin = new System.Windows.Forms.Padding(2);
            this.P1Name.Name = "P1Name";
            this.P1Name.Size = new System.Drawing.Size(438, 32);
            this.P1Name.TabIndex = 93;
            this.P1Name.Text = "Name";
            // 
            // textBox20
            // 
            this.textBox20.BackColor = System.Drawing.SystemColors.WindowText;
            this.textBox20.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox20.Font = new System.Drawing.Font("Microsoft Yi Baiti", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox20.ForeColor = System.Drawing.Color.DimGray;
            this.textBox20.Location = new System.Drawing.Point(28, 451);
            this.textBox20.Margin = new System.Windows.Forms.Padding(2);
            this.textBox20.Name = "textBox20";
            this.textBox20.Size = new System.Drawing.Size(438, 32);
            this.textBox20.TabIndex = 94;
            this.textBox20.Text = "Sex";
            // 
            // P1Class
            // 
            this.P1Class.BackColor = System.Drawing.SystemColors.WindowText;
            this.P1Class.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.P1Class.Font = new System.Drawing.Font("Microsoft Yi Baiti", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.P1Class.ForeColor = System.Drawing.Color.DimGray;
            this.P1Class.Location = new System.Drawing.Point(28, 545);
            this.P1Class.Margin = new System.Windows.Forms.Padding(2);
            this.P1Class.Name = "P1Class";
            this.P1Class.Size = new System.Drawing.Size(438, 32);
            this.P1Class.TabIndex = 95;
            this.P1Class.Text = "Class";
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Default;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.DarkGray;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.Location = new System.Drawing.Point(174, 613);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 33);
            this.button1.TabIndex = 96;
            this.button1.Text = "Edit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.ClassAccount);
            this.panel1.Controls.Add(this.SexAccount);
            this.panel1.Controls.Add(this.EmailAccount);
            this.panel1.Controls.Add(this.NameAccount);
            this.panel1.Controls.Add(this.UsernameAccount);
            this.panel1.Controls.Add(this.PasswordAccount);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.P1Class);
            this.panel1.Controls.Add(this.textBox20);
            this.panel1.Controls.Add(this.P1Name);
            this.panel1.Controls.Add(this.textBox16);
            this.panel1.Controls.Add(this.textBox18);
            this.panel1.Controls.Add(this.P1User);
            this.panel1.Location = new System.Drawing.Point(181, 123);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(490, 666);
            this.panel1.TabIndex = 97;
            // 
            // ClassAccount
            // 
            this.ClassAccount.AutoSize = true;
            this.ClassAccount.Location = new System.Drawing.Point(189, 494);
            this.ClassAccount.Name = "ClassAccount";
            this.ClassAccount.Size = new System.Drawing.Size(117, 45);
            this.ClassAccount.TabIndex = 106;
            this.ClassAccount.Text = "Class";
            // 
            // SexAccount
            // 
            this.SexAccount.AutoSize = true;
            this.SexAccount.Location = new System.Drawing.Point(198, 393);
            this.SexAccount.Name = "SexAccount";
            this.SexAccount.Size = new System.Drawing.Size(87, 45);
            this.SexAccount.TabIndex = 105;
            this.SexAccount.Text = "Sex";
            this.SexAccount.Click += new System.EventHandler(this.smallInfo1_Click_1);
            // 
            // EmailAccount
            // 
            this.EmailAccount.AutoSize = true;
            this.EmailAccount.Location = new System.Drawing.Point(187, 289);
            this.EmailAccount.Name = "EmailAccount";
            this.EmailAccount.Size = new System.Drawing.Size(119, 45);
            this.EmailAccount.TabIndex = 104;
            this.EmailAccount.Text = "Email";
            // 
            // NameAccount
            // 
            this.NameAccount.AutoSize = true;
            this.NameAccount.Location = new System.Drawing.Point(187, 195);
            this.NameAccount.Name = "NameAccount";
            this.NameAccount.Size = new System.Drawing.Size(127, 45);
            this.NameAccount.TabIndex = 103;
            this.NameAccount.Text = "Name";
            this.NameAccount.Click += new System.EventHandler(this.smallInfo1_Click);
            // 
            // UsernameAccount
            // 
            this.UsernameAccount.AutoSize = true;
            this.UsernameAccount.Location = new System.Drawing.Point(149, 6);
            this.UsernameAccount.Name = "UsernameAccount";
            this.UsernameAccount.Size = new System.Drawing.Size(210, 45);
            this.UsernameAccount.TabIndex = 102;
            this.UsernameAccount.Text = "UserName";
            // 
            // PasswordAccount
            // 
            this.PasswordAccount.AutoSize = true;
            this.PasswordAccount.Location = new System.Drawing.Point(153, 100);
            this.PasswordAccount.Name = "PasswordAccount";
            this.PasswordAccount.Size = new System.Drawing.Size(193, 45);
            this.PasswordAccount.TabIndex = 101;
            this.PasswordAccount.Text = "Password";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.submit_b);
            this.panel2.Controls.Add(this.p2Weight);
            this.panel2.Controls.Add(this.p2Height);
            this.panel2.Controls.Add(this.p2Sex);
            this.panel2.Controls.Add(this.p2Ln);
            this.panel2.Controls.Add(this.p2Fn);
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Controls.Add(this.username_tb);
            this.panel2.Location = new System.Drawing.Point(1145, 126);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(452, 528);
            this.panel2.TabIndex = 98;
            this.panel2.Visible = false;
            // 
            // header11
            // 
            this.header11.AutoSize = true;
            this.header11.Location = new System.Drawing.Point(110, 0);
            this.header11.Name = "header11";
            this.header11.Size = new System.Drawing.Size(690, 119);
            this.header11.TabIndex = 99;
            this.header11.Text = "User Account";
            this.header11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.header11.Click += new System.EventHandler(this.header11_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.header11);
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Location = new System.Drawing.Point(229, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(807, 789);
            this.panel3.TabIndex = 100;
            // 
            // UserAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Name = "UserAccount";
            this.Size = new System.Drawing.Size(1600, 829);
            this.Load += new System.EventHandler(this.UserAccount_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox username_tb;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox p2Fn;
        private System.Windows.Forms.TextBox p2Ln;
        private System.Windows.Forms.TextBox p2Sex;
        private System.Windows.Forms.TextBox p2Height;
        private System.Windows.Forms.TextBox p2Weight;
        private System.Windows.Forms.Button submit_b;
        private System.Windows.Forms.TextBox P1User;
        private System.Windows.Forms.TextBox textBox18;
        private System.Windows.Forms.TextBox textBox16;
        private System.Windows.Forms.TextBox P1Name;
        private System.Windows.Forms.TextBox textBox20;
        private System.Windows.Forms.TextBox P1Class;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Classes.Header1 header11;
        private System.Windows.Forms.Panel panel3;
        private Classes.SmallInfo UsernameAccount;
        private Classes.SmallInfo PasswordAccount;
        private Classes.SmallInfo NameAccount;
        private Classes.SmallInfo SexAccount;
        private Classes.SmallInfo EmailAccount;
        private Classes.SmallInfo ClassAccount;
    }
}

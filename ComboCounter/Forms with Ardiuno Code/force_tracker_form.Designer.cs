namespace ComboCounter
{
    partial class force_tracker_form
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
            this.force_textbox = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.time_textbox = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // force_textbox
            // 
            this.force_textbox.BackColor = System.Drawing.Color.White;
            this.force_textbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.force_textbox.Font = new System.Drawing.Font("Permanent Marker", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.force_textbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(177)))), ((int)(((byte)(149)))));
            this.force_textbox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.force_textbox.Location = new System.Drawing.Point(74, 191);
            this.force_textbox.Name = "force_textbox";
            this.force_textbox.ReadOnly = true;
            this.force_textbox.Size = new System.Drawing.Size(489, 140);
            this.force_textbox.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Permanent Marker", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(177)))), ((int)(((byte)(149)))));
            this.textBox1.Location = new System.Drawing.Point(597, 218);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(183, 105);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "lbs";
            // 
            // time_textbox
            // 
            this.time_textbox.BackColor = System.Drawing.Color.White;
            this.time_textbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.time_textbox.Font = new System.Drawing.Font("Permanent Marker", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time_textbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(177)))), ((int)(((byte)(149)))));
            this.time_textbox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.time_textbox.Location = new System.Drawing.Point(74, 382);
            this.time_textbox.Name = "time_textbox";
            this.time_textbox.ReadOnly = true;
            this.time_textbox.Size = new System.Drawing.Size(489, 140);
            this.time_textbox.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.White;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Permanent Marker", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(177)))), ((int)(((byte)(149)))));
            this.textBox2.Location = new System.Drawing.Point(597, 409);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(556, 105);
            this.textBox2.TabIndex = 3;
            this.textBox2.Text = "Milli-seconds";
            // 
            // force_tracker_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1318, 923);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.time_textbox);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.force_textbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "force_tracker_form";
            this.Text = "force_tracker_form";
            this.Load += new System.EventHandler(this.force_tracker_form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox force_textbox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox time_textbox;
        private System.Windows.Forms.TextBox textBox2;
    }
}
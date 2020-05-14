namespace ComboCounter.Forms
{
    partial class PunchChallange
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
            this.punch_challenge1 = new ComboCounter.UserControls.punch_challenge();
            this.SuspendLayout();
            // 
            // punch_challenge1
            // 
            this.punch_challenge1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(23)))), ((int)(((byte)(30)))));
            this.punch_challenge1.Location = new System.Drawing.Point(-2, 17);
            this.punch_challenge1.Name = "punch_challenge1";
            this.punch_challenge1.Size = new System.Drawing.Size(1857, 877);
            this.punch_challenge1.TabIndex = 0;
            this.punch_challenge1.Load += new System.EventHandler(this.punch_challenge1_Load);
            // 
            // PunchChallange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(23)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(1867, 926);
            this.ControlBox = false;
            this.Controls.Add(this.punch_challenge1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(0, 73);
            this.Name = "PunchChallange";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PunchChallange";
            this.ResumeLayout(false);

        }

        #endregion

        private UserControls.punch_challenge punch_challenge1;
    }
}
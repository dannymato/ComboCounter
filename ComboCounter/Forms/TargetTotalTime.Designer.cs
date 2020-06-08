namespace ComboCounter.Forms
{
    partial class TargetTotalTime
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
            this.home_user21 = new ComboCounter.UserControls.home_user2();
            this.SuspendLayout();
            // 
            // home_user21
            // 
            this.home_user21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(23)))), ((int)(((byte)(30)))));
            this.home_user21.Location = new System.Drawing.Point(-3, 18);
            this.home_user21.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.home_user21.Name = "home_user21";
            this.home_user21.Size = new System.Drawing.Size(2481, 1062);
            this.home_user21.TabIndex = 0;
            this.home_user21.Load += new System.EventHandler(this.home_user21_Load);
            // 
            // TargetTotalTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(23)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(2487, 1020);
            this.ControlBox = false;
            this.Controls.Add(this.home_user21);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(0, 73);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "TargetTotalTime";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TargetTotalTime";
            this.ResumeLayout(false);

        }

        private UserControls.home_user2 home_user21;

        #endregion

        //  private UserControls.home_user2 home_user2;
    }
}
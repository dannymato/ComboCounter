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
            this.home_user21.Location = new System.Drawing.Point(-2, 15);
            this.home_user21.Margin = new System.Windows.Forms.Padding(2);
            this.home_user21.Name = "home_user21";
            this.home_user21.Size = new System.Drawing.Size(1861, 863);
            this.home_user21.TabIndex = 0;
            // 
            // TargetTotalTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(23)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(1865, 829);
            this.ControlBox = false;
            this.Controls.Add(this.home_user21);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(0, 73);
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
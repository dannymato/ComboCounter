namespace ComboCounter.Forms
{
    partial class ComboScore
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
            this.comboScoreControl1 = new ComboCounter.UserControls_Gabriel.ComboScoreControl();
            this.SuspendLayout();
            // 
            // comboScoreControl1
            // 
            this.comboScoreControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(23)))), ((int)(((byte)(30)))));
            this.comboScoreControl1.Location = new System.Drawing.Point(16, 23);
            this.comboScoreControl1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.comboScoreControl1.Name = "comboScoreControl1";
            this.comboScoreControl1.Size = new System.Drawing.Size(2161, 924);
            this.comboScoreControl1.TabIndex = 0;
            this.comboScoreControl1.Load += new System.EventHandler(this.comboScoreControl1_Load);
            // 
            // ComboScore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(23)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(2193, 1061);
            this.ControlBox = false;
            this.Controls.Add(this.comboScoreControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(0, 73);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ComboScore";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ComboScore";
            this.ResumeLayout(false);

        }

        #endregion

        private UserControls_Gabriel.ComboScoreControl comboScoreControl1;
    }
}
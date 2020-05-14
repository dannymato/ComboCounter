namespace ComboCounter.Forms
{
    partial class ComboScoreComp
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
            this.comboScoreCompControl1 = new ComboCounter.UserControls_Gabriel.ComboScoreCompControl();
            this.SuspendLayout();
            // 
            // comboScoreCompControl1
            // 
            this.comboScoreCompControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(23)))), ((int)(((byte)(30)))));
            this.comboScoreCompControl1.Location = new System.Drawing.Point(12, 12);
            this.comboScoreCompControl1.Name = "comboScoreCompControl1";
            this.comboScoreCompControl1.Size = new System.Drawing.Size(1632, 840);
            this.comboScoreCompControl1.TabIndex = 0;
            // 
            // ComboScoreComp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(23)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(1658, 910);
            this.ControlBox = false;
            this.Controls.Add(this.comboScoreCompControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(0, 73);
            this.Name = "ComboScoreComp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ComboScoreComp";
            this.ResumeLayout(false);

        }

        #endregion

        private UserControls_Gabriel.ComboScoreCompControl comboScoreCompControl1;
    }
}
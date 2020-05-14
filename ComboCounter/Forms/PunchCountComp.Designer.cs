namespace ComboCounter.Forms
{
    partial class PunchCountComp
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
            this.punch_count_comp1 = new ComboCounter.UserControls.punch_count_comp();
            this.SuspendLayout();
            // 
            // punch_count_comp1
            // 
            this.punch_count_comp1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(23)))), ((int)(((byte)(30)))));
            this.punch_count_comp1.Location = new System.Drawing.Point(81, -9);
            this.punch_count_comp1.Name = "punch_count_comp1";
            this.punch_count_comp1.Size = new System.Drawing.Size(1714, 946);
            this.punch_count_comp1.TabIndex = 0;
            // 
            // PunchCountComp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(23)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(1807, 936);
            this.ControlBox = false;
            this.Controls.Add(this.punch_count_comp1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(0, 85);
            this.Name = "PunchCountComp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PunchCountComp";
            this.ResumeLayout(false);

        }

        #endregion

        private UserControls.punch_count_comp punch_count_comp1;
    }
}
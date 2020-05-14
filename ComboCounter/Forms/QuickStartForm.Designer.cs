namespace ComboCounter.Forms
{
    partial class QuickStartForm
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
            this.quickStart1 = new ComboCounter.quickStart();
            this.SuspendLayout();
            // 
            // quickStart1
            // 
            this.quickStart1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(23)))), ((int)(((byte)(30)))));
            this.quickStart1.Location = new System.Drawing.Point(277, 22);
            this.quickStart1.Margin = new System.Windows.Forms.Padding(2);
            this.quickStart1.Name = "quickStart1";
            this.quickStart1.Size = new System.Drawing.Size(1297, 675);
            this.quickStart1.TabIndex = 0;
            // 
            // QuickStartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(23)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(1658, 722);
            this.ControlBox = false;
            this.Controls.Add(this.quickStart1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "QuickStartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QuickStartForm";
            this.ResumeLayout(false);

        }

        #endregion

        private quickStart quickStart1;
    }
}
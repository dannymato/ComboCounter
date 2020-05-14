namespace ComboCounter.Forms
{
    partial class SensorAdjusments
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
            this.censorControl1 = new ComboCounter.UserControls_Gabriel.CensorControl();
            this.SuspendLayout();
            // 
            // censorControl1
            // 
            this.censorControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(23)))), ((int)(((byte)(30)))));
            this.censorControl1.Location = new System.Drawing.Point(12, 12);
            this.censorControl1.Name = "censorControl1";
            this.censorControl1.Size = new System.Drawing.Size(1611, 700);
            this.censorControl1.TabIndex = 0;
            // 
            // SensorAdjusments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(23)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(1658, 761);
            this.ControlBox = false;
            this.Controls.Add(this.censorControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SensorAdjusments";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SensorAdjusments";
            this.ResumeLayout(false);

        }

        #endregion

        private UserControls_Gabriel.CensorControl censorControl1;
    }
}
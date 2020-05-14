namespace ComboCounter.Forms
{
    partial class TargetedTotalForce
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
            this.targeted_total_of_force1 = new ComboCounter.UserControls.targeted_total_of_force();
            this.SuspendLayout();
            // 
            // targeted_total_of_force1
            // 
            this.targeted_total_of_force1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(23)))), ((int)(((byte)(30)))));
            this.targeted_total_of_force1.Location = new System.Drawing.Point(1, 12);
            this.targeted_total_of_force1.Name = "targeted_total_of_force1";
            this.targeted_total_of_force1.Size = new System.Drawing.Size(1841, 883);
            this.targeted_total_of_force1.TabIndex = 0;
            // 
            // TargetedTotalForce
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(23)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(1874, 863);
            this.ControlBox = false;
            this.Controls.Add(this.targeted_total_of_force1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(0, 73);
            this.Name = "TargetedTotalForce";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TargetedTotalForce";
            this.ResumeLayout(false);

        }

        #endregion

        private UserControls.targeted_total_of_force targeted_total_of_force1;
    }
}
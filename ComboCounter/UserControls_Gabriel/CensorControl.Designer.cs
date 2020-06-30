using ComboCounter.CustomControls;
using System.Windows.Controls;

namespace ComboCounter.UserControls_Gabriel
{
    partial class CensorControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mediumInfo2 = new ComboCounter.Classes.MediumInfo();
            this.SensorHeader = new ComboCounter.Classes.MediumInfo();
            this.Minus_Icon1 = new ComboCounter.CustomControls.TextButton();
            this.Handicap1 = new ComboCounter.Classes.SmallInfo();
            this.Plus_Icon1 = new ComboCounter.CustomControls.TextButton();
            this.mediumInfo3 = new ComboCounter.Classes.MediumInfo();
            this.Plus_Icon2 = new ComboCounter.CustomControls.TextButton();
            this.Minus_Icon2 = new ComboCounter.CustomControls.TextButton();
            this.Handicap2 = new ComboCounter.Classes.SmallInfo();
            this.SensorPanel = new System.Windows.Forms.Panel();
            this.SensorPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mediumInfo2
            // 
            this.mediumInfo2.AutoSize = true;
            this.mediumInfo2.BackColor = System.Drawing.Color.Transparent;
            this.mediumInfo2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.mediumInfo2.Location = new System.Drawing.Point(87, 21);
            this.mediumInfo2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.mediumInfo2.Name = "mediumInfo2";
            this.mediumInfo2.Size = new System.Drawing.Size(392, 120);
            this.mediumInfo2.TabIndex = 81;
            this.mediumInfo2.Text = "Guest 1";
            // 
            // SensorHeader
            // 
            this.SensorHeader.AutoSize = true;
            this.SensorHeader.BackColor = System.Drawing.Color.Transparent;
            this.SensorHeader.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.SensorHeader.Location = new System.Drawing.Point(697, 36);
            this.SensorHeader.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SensorHeader.Name = "SensorHeader";
            this.SensorHeader.Size = new System.Drawing.Size(745, 120);
            this.SensorHeader.TabIndex = 82;
            this.SensorHeader.Text = "Sensor Reading";
            // 
            // Minus_Icon1
            // 
            this.Minus_Icon1.AutoSize = true;
            this.Minus_Icon1.BackColor = System.Drawing.Color.Transparent;
            this.Minus_Icon1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Minus_Icon1.FlatAppearance.BorderSize = 0;
            this.Minus_Icon1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Minus_Icon1.ForeColor = System.Drawing.Color.SteelBlue;
            this.Minus_Icon1.Location = new System.Drawing.Point(107, 151);
            this.Minus_Icon1.Margin = new System.Windows.Forms.Padding(4);
            this.Minus_Icon1.Name = "Minus_Icon1";
            this.Minus_Icon1.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.Minus_Icon1.Size = new System.Drawing.Size(103, 94);
            this.Minus_Icon1.TabIndex = 77;
            this.Minus_Icon1.Text = "-";
            this.Minus_Icon1.UseVisualStyleBackColor = true;
            this.Minus_Icon1.Click += new System.EventHandler(this.Minus_Icon1_Click);
            // 
            // Handicap1
            // 
            this.Handicap1.AutoSize = true;
            this.Handicap1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Handicap1.Location = new System.Drawing.Point(197, 165);
            this.Handicap1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Handicap1.Name = "Handicap1";
            this.Handicap1.Size = new System.Drawing.Size(160, 61);
            this.Handicap1.TabIndex = 78;
            this.Handicap1.Text = " 100%";
            this.Handicap1.Click += new System.EventHandler(this.smallInfo1_Click);
            // 
            // Plus_Icon1
            // 
            this.Plus_Icon1.AutoSize = true;
            this.Plus_Icon1.BackColor = System.Drawing.Color.Transparent;
            this.Plus_Icon1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Plus_Icon1.FlatAppearance.BorderSize = 0;
            this.Plus_Icon1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Plus_Icon1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Plus_Icon1.ForeColor = System.Drawing.Color.SteelBlue;
            this.Plus_Icon1.Location = new System.Drawing.Point(383, 165);
            this.Plus_Icon1.Margin = new System.Windows.Forms.Padding(4);
            this.Plus_Icon1.Name = "Plus_Icon1";
            this.Plus_Icon1.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.Plus_Icon1.Size = new System.Drawing.Size(67, 68);
            this.Plus_Icon1.TabIndex = 76;
            this.Plus_Icon1.Text = "+";
            this.Plus_Icon1.UseVisualStyleBackColor = false;
            this.Plus_Icon1.Click += new System.EventHandler(this.Plus_Icon1_Click);
            // 
            // mediumInfo3
            // 
            this.mediumInfo3.AutoSize = true;
            this.mediumInfo3.BackColor = System.Drawing.Color.Transparent;
            this.mediumInfo3.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.mediumInfo3.Location = new System.Drawing.Point(87, 327);
            this.mediumInfo3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.mediumInfo3.Name = "mediumInfo3";
            this.mediumInfo3.Size = new System.Drawing.Size(392, 120);
            this.mediumInfo3.TabIndex = 83;
            this.mediumInfo3.Text = "Guest 2";
            // 
            // Plus_Icon2
            // 
            this.Plus_Icon2.AutoSize = true;
            this.Plus_Icon2.BackColor = System.Drawing.Color.Transparent;
            this.Plus_Icon2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Plus_Icon2.FlatAppearance.BorderSize = 0;
            this.Plus_Icon2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Plus_Icon2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Plus_Icon2.ForeColor = System.Drawing.Color.SteelBlue;
            this.Plus_Icon2.Location = new System.Drawing.Point(395, 466);
            this.Plus_Icon2.Margin = new System.Windows.Forms.Padding(4);
            this.Plus_Icon2.Name = "Plus_Icon2";
            this.Plus_Icon2.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.Plus_Icon2.Size = new System.Drawing.Size(67, 68);
            this.Plus_Icon2.TabIndex = 84;
            this.Plus_Icon2.Text = "+";
            this.Plus_Icon2.UseVisualStyleBackColor = false;
            this.Plus_Icon2.Click += new System.EventHandler(this.Plus_Icon2_Click);
            // 
            // Minus_Icon2
            // 
            this.Minus_Icon2.AutoSize = true;
            this.Minus_Icon2.BackColor = System.Drawing.Color.Transparent;
            this.Minus_Icon2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Minus_Icon2.FlatAppearance.BorderSize = 0;
            this.Minus_Icon2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Minus_Icon2.ForeColor = System.Drawing.Color.SteelBlue;
            this.Minus_Icon2.Location = new System.Drawing.Point(84, 453);
            this.Minus_Icon2.Margin = new System.Windows.Forms.Padding(4);
            this.Minus_Icon2.Name = "Minus_Icon2";
            this.Minus_Icon2.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.Minus_Icon2.Size = new System.Drawing.Size(103, 94);
            this.Minus_Icon2.TabIndex = 85;
            this.Minus_Icon2.Text = "-";
            this.Minus_Icon2.UseVisualStyleBackColor = true;
            this.Minus_Icon2.Click += new System.EventHandler(this.Minus_Icon2_Click);
            // 
            // Handicap2
            // 
            this.Handicap2.AutoSize = true;
            this.Handicap2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Handicap2.Location = new System.Drawing.Point(209, 474);
            this.Handicap2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Handicap2.Name = "Handicap2";
            this.Handicap2.Size = new System.Drawing.Size(160, 61);
            this.Handicap2.TabIndex = 86;
            this.Handicap2.Text = " 100%";
            // 
            // SensorPanel
            // 
            this.SensorPanel.Controls.Add(this.Handicap2);
            this.SensorPanel.Controls.Add(this.Minus_Icon2);
            this.SensorPanel.Controls.Add(this.Plus_Icon2);
            this.SensorPanel.Controls.Add(this.mediumInfo3);
            this.SensorPanel.Controls.Add(this.Handicap1);
            this.SensorPanel.Controls.Add(this.Plus_Icon1);
            this.SensorPanel.Controls.Add(this.Minus_Icon1);
            this.SensorPanel.Controls.Add(this.mediumInfo2);
            this.SensorPanel.Location = new System.Drawing.Point(800, 230);
            this.SensorPanel.Margin = new System.Windows.Forms.Padding(4);
            this.SensorPanel.Name = "SensorPanel";
            this.SensorPanel.Size = new System.Drawing.Size(600, 577);
            this.SensorPanel.TabIndex = 87;
            // 
            // CensorControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.SensorPanel);
            this.Controls.Add(this.SensorHeader);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CensorControl";
            this.Size = new System.Drawing.Size(2133, 862);
            this.Load += new System.EventHandler(this.CensorControl_Load);
            this.SensorPanel.ResumeLayout(false);
            this.SensorPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Classes.MediumInfo mediumInfo2;
        private Classes.MediumInfo SensorHeader;
        private Classes.SmallInfo Handicap1;
        private Classes.MediumInfo mediumInfo3;
        private Classes.SmallInfo Handicap2;
        private System.Windows.Forms.Panel SensorPanel;
        private TextButton Minus_Icon1;
        private TextButton Plus_Icon1;
        private TextButton Plus_Icon2;
        private TextButton Minus_Icon2;
    }
}

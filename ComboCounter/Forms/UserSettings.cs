using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComboCounter.Classes;

namespace ComboCounter.Forms
{
    class UserSettings : BaseFormControl
    {
        private CustomControls.OutlineButton ThemeButton;
        private System.Windows.Forms.Panel CheckBoxPanel;
        private System.Windows.Forms.CheckBox ShowTimerToggle;
        private System.Windows.Forms.CheckBox AscendingTimeToggle;
        private System.Windows.Forms.CheckBox MissSoundsToggle;
        private System.Windows.Forms.CheckBox HitSoundsToggle;
        private System.Windows.Forms.CheckBox VisualFeedbackToggle;
        private System.Windows.Forms.Panel ThemeSelectPanel;
        private System.Windows.Forms.Button ThemeSelectClose;
        private CustomControls.OutlineButton DarkModeTheme;
        private CustomControls.OutlineButton LightModeTheme;
        private System.Windows.Forms.Panel MainPanel;

        public UserSettings()
        {
            InitializeComponent();

            this.AscendingTimeToggle.ForeColor = ThemeManager.initH2Color();
            this.ShowTimerToggle.ForeColor = ThemeManager.initH2Color();
            this.VisualFeedbackToggle.ForeColor = ThemeManager.initH2Color();
            this.HitSoundsToggle.ForeColor = ThemeManager.initH2Color();
            this.MissSoundsToggle.ForeColor = ThemeManager.initH2Color();


        }

        private void InitializeComponent()
        {
            this.MainPanel = new System.Windows.Forms.Panel();
            this.ThemeSelectPanel = new System.Windows.Forms.Panel();
            this.DarkModeTheme = new ComboCounter.CustomControls.OutlineButton();
            this.LightModeTheme = new ComboCounter.CustomControls.OutlineButton();
            this.ThemeSelectClose = new System.Windows.Forms.Button();
            this.CheckBoxPanel = new System.Windows.Forms.Panel();
            this.MissSoundsToggle = new System.Windows.Forms.CheckBox();
            this.HitSoundsToggle = new System.Windows.Forms.CheckBox();
            this.VisualFeedbackToggle = new System.Windows.Forms.CheckBox();
            this.ShowTimerToggle = new System.Windows.Forms.CheckBox();
            this.AscendingTimeToggle = new System.Windows.Forms.CheckBox();
            this.ThemeButton = new ComboCounter.CustomControls.OutlineButton();
            this.MainPanel.SuspendLayout();
            this.ThemeSelectPanel.SuspendLayout();
            this.CheckBoxPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.ThemeSelectPanel);
            this.MainPanel.Controls.Add(this.CheckBoxPanel);
            this.MainPanel.Controls.Add(this.ThemeButton);
            this.MainPanel.Location = new System.Drawing.Point(210, 27);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(605, 529);
            this.MainPanel.TabIndex = 0;
            // 
            // ThemeSelectPanel
            // 
            this.ThemeSelectPanel.BackColor = System.Drawing.Color.Transparent;
            this.ThemeSelectPanel.Controls.Add(this.DarkModeTheme);
            this.ThemeSelectPanel.Controls.Add(this.LightModeTheme);
            this.ThemeSelectPanel.Controls.Add(this.ThemeSelectClose);
            this.ThemeSelectPanel.Location = new System.Drawing.Point(78, 137);
            this.ThemeSelectPanel.Name = "ThemeSelectPanel";
            this.ThemeSelectPanel.Size = new System.Drawing.Size(443, 325);
            this.ThemeSelectPanel.TabIndex = 5;
            this.ThemeSelectPanel.Visible = false;
            // 
            // DarkModeTheme
            // 
            this.DarkModeTheme.AutoSize = true;
            this.DarkModeTheme.BackColor = System.Drawing.Color.Transparent;
            this.DarkModeTheme.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.DarkModeTheme.FlatAppearance.BorderSize = 2;
            this.DarkModeTheme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DarkModeTheme.ForeColor = System.Drawing.Color.White;
            this.DarkModeTheme.Location = new System.Drawing.Point(86, 129);
            this.DarkModeTheme.Name = "DarkModeTheme";
            this.DarkModeTheme.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.DarkModeTheme.Size = new System.Drawing.Size(329, 65);
            this.DarkModeTheme.TabIndex = 2;
            this.DarkModeTheme.Text = "Dark Mode Theme";
            this.DarkModeTheme.UseVisualStyleBackColor = false;
            // 
            // LightModeTheme
            // 
            this.LightModeTheme.AutoSize = true;
            this.LightModeTheme.BackColor = System.Drawing.Color.Transparent;
            this.LightModeTheme.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.LightModeTheme.FlatAppearance.BorderSize = 2;
            this.LightModeTheme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LightModeTheme.ForeColor = System.Drawing.Color.White;
            this.LightModeTheme.Location = new System.Drawing.Point(86, 30);
            this.LightModeTheme.Name = "LightModeTheme";
            this.LightModeTheme.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.LightModeTheme.Size = new System.Drawing.Size(335, 65);
            this.LightModeTheme.TabIndex = 1;
            this.LightModeTheme.Text = "Light Mode Theme";
            this.LightModeTheme.UseVisualStyleBackColor = false;
            // 
            // ThemeSelectClose
            // 
            this.ThemeSelectClose.Location = new System.Drawing.Point(191, 234);
            this.ThemeSelectClose.Name = "ThemeSelectClose";
            this.ThemeSelectClose.Size = new System.Drawing.Size(75, 23);
            this.ThemeSelectClose.TabIndex = 0;
            this.ThemeSelectClose.Text = "Close";
            this.ThemeSelectClose.UseVisualStyleBackColor = true;
            this.ThemeSelectClose.Click += new System.EventHandler(this.ThemeSelectClose_Click);
            // 
            // CheckBoxPanel
            // 
            this.CheckBoxPanel.Controls.Add(this.MissSoundsToggle);
            this.CheckBoxPanel.Controls.Add(this.HitSoundsToggle);
            this.CheckBoxPanel.Controls.Add(this.VisualFeedbackToggle);
            this.CheckBoxPanel.Controls.Add(this.ShowTimerToggle);
            this.CheckBoxPanel.Controls.Add(this.AscendingTimeToggle);
            this.CheckBoxPanel.Location = new System.Drawing.Point(151, 123);
            this.CheckBoxPanel.Name = "CheckBoxPanel";
            this.CheckBoxPanel.Size = new System.Drawing.Size(331, 271);
            this.CheckBoxPanel.TabIndex = 4;
            // 
            // MissSoundsToggle
            // 
            this.MissSoundsToggle.AutoSize = true;
            this.MissSoundsToggle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MissSoundsToggle.ForeColor = System.Drawing.Color.White;
            this.MissSoundsToggle.Location = new System.Drawing.Point(28, 184);
            this.MissSoundsToggle.Name = "MissSoundsToggle";
            this.MissSoundsToggle.Size = new System.Drawing.Size(348, 43);
            this.MissSoundsToggle.TabIndex = 7;
            this.MissSoundsToggle.Text = "Toggle Miss Sounds";
            this.MissSoundsToggle.UseVisualStyleBackColor = true;
            this.MissSoundsToggle.CheckedChanged += new System.EventHandler(this.MissSoundsToggle_CheckedChanged);
            // 
            // HitSoundsToggle
            // 
            this.HitSoundsToggle.AutoSize = true;
            this.HitSoundsToggle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HitSoundsToggle.ForeColor = System.Drawing.Color.White;
            this.HitSoundsToggle.Location = new System.Drawing.Point(28, 143);
            this.HitSoundsToggle.Name = "HitSoundsToggle";
            this.HitSoundsToggle.Size = new System.Drawing.Size(320, 43);
            this.HitSoundsToggle.TabIndex = 6;
            this.HitSoundsToggle.Text = "Toggle Hit Sounds";
            this.HitSoundsToggle.UseVisualStyleBackColor = true;
            this.HitSoundsToggle.CheckedChanged += new System.EventHandler(this.HitSoundsToggle_CheckedChanged);
            // 
            // VisualFeedbackToggle
            // 
            this.VisualFeedbackToggle.AutoSize = true;
            this.VisualFeedbackToggle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VisualFeedbackToggle.ForeColor = System.Drawing.Color.White;
            this.VisualFeedbackToggle.Location = new System.Drawing.Point(28, 96);
            this.VisualFeedbackToggle.Name = "VisualFeedbackToggle";
            this.VisualFeedbackToggle.Size = new System.Drawing.Size(416, 43);
            this.VisualFeedbackToggle.TabIndex = 5;
            this.VisualFeedbackToggle.Text = "Disable Visual Feedback";
            this.VisualFeedbackToggle.UseVisualStyleBackColor = true;
            this.VisualFeedbackToggle.CheckedChanged += new System.EventHandler(this.VisualFeebackToggle_CheckedChanged);
            // 
            // ShowTimerToggle
            // 
            this.ShowTimerToggle.AutoSize = true;
            this.ShowTimerToggle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowTimerToggle.ForeColor = System.Drawing.Color.White;
            this.ShowTimerToggle.Location = new System.Drawing.Point(28, 55);
            this.ShowTimerToggle.Name = "ShowTimerToggle";
            this.ShowTimerToggle.Size = new System.Drawing.Size(279, 43);
            this.ShowTimerToggle.TabIndex = 4;
            this.ShowTimerToggle.Text = "Timers on Page";
            this.ShowTimerToggle.UseVisualStyleBackColor = true;
            this.ShowTimerToggle.CheckedChanged += new System.EventHandler(this.ShowTimerToggle_CheckedChanged);
            // 
            // AscendingTimeToggle
            // 
            this.AscendingTimeToggle.AutoSize = true;
            this.AscendingTimeToggle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AscendingTimeToggle.ForeColor = System.Drawing.Color.Maroon;
            this.AscendingTimeToggle.Location = new System.Drawing.Point(28, 14);
            this.AscendingTimeToggle.Name = "AscendingTimeToggle";
            this.AscendingTimeToggle.Size = new System.Drawing.Size(284, 43);
            this.AscendingTimeToggle.TabIndex = 3;
            this.AscendingTimeToggle.Text = "Ascending Time";
            this.AscendingTimeToggle.UseVisualStyleBackColor = true;
            this.AscendingTimeToggle.CheckedChanged += new System.EventHandler(this.AscendingTime_CheckedChanged);
            // 
            // ThemeButton
            // 
            this.ThemeButton.AutoSize = true;
            this.ThemeButton.BackColor = System.Drawing.Color.Transparent;
            this.ThemeButton.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.ThemeButton.FlatAppearance.BorderSize = 2;
            this.ThemeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ThemeButton.ForeColor = System.Drawing.Color.White;
            this.ThemeButton.Location = new System.Drawing.Point(180, 30);
            this.ThemeButton.Name = "ThemeButton";
            this.ThemeButton.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.ThemeButton.Size = new System.Drawing.Size(280, 65);
            this.ThemeButton.TabIndex = 1;
            this.ThemeButton.Text = "Change Theme";
            this.ThemeButton.UseVisualStyleBackColor = false;
            this.ThemeButton.Click += new System.EventHandler(this.ThemeButton_Click);
            // 
            // UserSettings
            // 
            this.Controls.Add(this.MainPanel);
            this.Name = "UserSettings";
            this.Size = new System.Drawing.Size(971, 579);
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.ThemeSelectPanel.ResumeLayout(false);
            this.ThemeSelectPanel.PerformLayout();
            this.CheckBoxPanel.ResumeLayout(false);
            this.CheckBoxPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        private void ThemeButton_Click(object sender, EventArgs e)
        {
            CheckBoxPanel.Visible = false;
            ThemeButton.Visible = false;
            ThemeSelectPanel.Visible = true;

        }

        private void AscendingTime_CheckedChanged(object sender, EventArgs e)
        {
            if (AscendingTimeToggle.Checked == true)
            {
                //UserManager.UserSettings.AscendingClock = true;
            }

            if (AscendingTimeToggle.Checked == false)
            {
                //do whtever here when un checked  
            }
        }

        private void ShowTimerToggle_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowTimerToggle.Checked == true)
            {
                //do whtever here when checked  
            }

            if (ShowTimerToggle.Checked == false)
            {
                //do whtever here when un checked  
            }

        }


        private void VisualFeebackToggle_CheckedChanged(object sender, EventArgs e)
        {
            if (VisualFeedbackToggle.Checked == true)
            {
                //do whtever here when checked  
            }

            if (VisualFeedbackToggle.Checked == false)
            {
                //do whtever here when un checked  
            }

        }

        private void HitSoundsToggle_CheckedChanged(object sender, EventArgs e)
        {
            if (HitSoundsToggle.Checked == true)
            {
                //do whtever here when checked  
            }

            if (HitSoundsToggle.Checked == false)
            {
                //do whtever here when un checked  
            }
        }

        private void MissSoundsToggle_CheckedChanged(object sender, EventArgs e)
        {
            if (MissSoundsToggle.Checked == true)
            {
                //do whtever here when checked  
            }

            if (MissSoundsToggle.Checked == false)
            {
                //do whtever here when un checked  
            }
        }

        private void ThemeSelectClose_Click(object sender, EventArgs e)
        {
            ThemeSelectPanel.Visible = false;
            CheckBoxPanel.Visible = true;
            ThemeButton.Visible = true;
            //ThemeSelectPanel.Location = new Point((Width / 2) - (panel3.Width / 2) + 200, (Height / 2) - (panel3.Height / 2) + 150);

        }
    }
    
}

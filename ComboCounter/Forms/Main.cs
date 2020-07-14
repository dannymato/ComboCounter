using ComboCounter.Classes;
using ComboCounter.Forms;
using ComboCounter.UserControls;
using ComboCounter.UserControls_Gabriel;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ComboCounter
{

    public partial class Main : Form {

        Forms.UserSettings userSettingsForm;
        HomeScreen home;

        BaseFormControl currentControl = null;


        /// <summary>
        /// Contains all the pages that are displayed on the main page
        /// With the exception of the homescreen and the usersettings
        /// This allows us to easily reset the theme of all the pages
        /// by clearing the dictionary forcing all the pages to reset
        /// </summary>
        readonly Dictionary<string, BaseFormControl> pages;

        public Main()
        {
            pages = new Dictionary<string, BaseFormControl>();
            InitializeComponent();
        }

        #region Force Tracker
        private void force_tracker_Click(object sender, EventArgs e)
        {
            if (!pages.ContainsKey(nameof(CensorControl)))
            {
                pages.Add(nameof(CensorControl), new CensorControl());
            }
            LoadNewPage(pages[nameof(CensorControl)]);
        }

        #endregion

        #region Welcome Page
        private void home_button_Click(object sender, EventArgs e)
        {
            if (home == null)
            {
                LoadHomeScreen();
            }
            LoadNewPage(home);
            
        }

        /// <summary>
        /// Creates a new homescreen object and sets adds the newpage event handler
        /// to the option clicked event
        /// </summary>
        private void LoadHomeScreen()
        {
            home = new HomeScreen();
            home.OnOptionClicked += SelectNewPage;
        }

        #endregion

        private void user_button_Click(object sender, EventArgs e)
        {

            if (!pages.ContainsKey(nameof(UserAccount)))
            {
                pages.Add(nameof(UserAccount), new UserAccount());
            }
            LoadNewPage(pages[nameof(UserAccount)]);

        }

        private void exit_button_Click(object sender, EventArgs e)
        {

            Forms.Exit exit = new Forms.Exit();
            exit.ExitApplication += (s, arg) => 
            { 
                Close();
                foreach (var page in pages.Values)
                {
                    page.OnExit();
                }
            };

            exit.ClientSize = new Size(Width, Height);
            exit.Show();

        }

        
        private void user_settings_button_Click(object sender, EventArgs e)
        {
            if (userSettingsForm == null)
            {
                userSettingsForm = new Forms.UserSettings();
                userSettingsForm.OnThemeChanged += RefreshPages;
            }
            LoadNewPage(userSettingsForm);
        }

        private void histogram_Click(object sender, EventArgs e)
        {
            if (!pages.ContainsKey(nameof(histogram)))
            {
                pages.Add(nameof(histogram), new histogram());
            }
            LoadNewPage(pages[nameof(histogram)]);

        }

        private void Main_Load(object sender, EventArgs e)
        {

            ToolTip HomeToolTip = new ToolTip();
            HomeToolTip.SetToolTip(home_button, "Home");
            HomeToolTip.SetToolTip(force_tracker, "Sensor Calibration");
            HomeToolTip.SetToolTip(time_button, "User Settings");
            HomeToolTip.SetToolTip(histogram, "Show History");
            HomeToolTip.SetToolTip(user_button, "Show/Edit User Information");
            HomeToolTip.SetToolTip(exit_button, "Exit Program");

            Rectangle screenSize = Screen.PrimaryScreen.Bounds;
            Width = screenSize.Width;
            Height = screenSize.Height;


            mainPanel.Width = Width;
            mainPanel.Height = Height - tableLayoutPanel1.Height;
            mainPanel.Location = new Point(0, tableLayoutPanel1.Height);

            BackColor = ThemeManager.initBackground();

            LoadHomeScreen();
            LoadNewPage(home);

        }

        /// <summary>
        /// Called when the ThemeChanged event is fired
        /// Removes all the pages from the dictionary and recreates the HomeScreen
        /// It allows for the new theme to take effect on the rest of the pages
        /// Haven't been able to think of good solution of resetting all the pages without
        /// recreating the pages
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="eArgs"></param>
        private void RefreshPages(object sender, EventArgs eArgs)
        {
            pages.Clear();

            home = null;
            BackColor = ThemeManager.initBackground();
        }

        // Removes the old page in the panel and places the new one in
        // With the exception of the history page the old pages are still kept in memory for quicker access
        private void LoadNewPage(BaseFormControl newPage)
        {
            this.mainPanel.Hide();
            this.mainPanel.Controls.Clear();
            if (currentControl != null)
            {
                currentControl.OnPageRemoved();
            }

            newPage.OnPageAttached();
            this.mainPanel.Controls.Add(newPage);
            currentControl = newPage;
            newPage.Anchor = AnchorStyles.None;
            newPage.Left = (mainPanel.Width - newPage.Width) / 2;
            newPage.Top = (mainPanel.Height - newPage.Height) / 2;
            this.mainPanel.Show();
        }

        /// <summary>
        /// Event handler to detect when the user clicks on an option on the homescreen
        /// Depending on the ClassToCall method it will load a different page onto the homescreen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void SelectNewPage(object sender, OptionClickEventArgs args)
        {
            switch (args.ClassToCall)
            {
                case ClassToCall.ComboCounter:
                    if (!pages.ContainsKey(nameof(ComboScoreControl)))
                    {
                        pages.Add(nameof(ComboScoreControl), new ComboScoreControl());
                    }
                    LoadNewPage(pages[nameof(ComboScoreControl)]);
                    break;
                case ClassToCall.TotalForce:
                    if (!pages.ContainsKey(nameof(targeted_total_of_force)))
                    {
                        pages.Add(nameof(targeted_total_of_force), new targeted_total_of_force());
                    }
                    LoadNewPage(pages[nameof(targeted_total_of_force)]);
                    break;
                case ClassToCall.TotalForce2Play:
                    if (!pages.ContainsKey(nameof(Targeted_total_of_force_comp)))
                    {
                        pages.Add(nameof(Targeted_total_of_force_comp), new Targeted_total_of_force_comp());
                    }
                    LoadNewPage(pages[nameof(Targeted_total_of_force_comp)]);
                    break;
                case ClassToCall.TotalTime:
                    if (!pages.ContainsKey(nameof(targeted_total_of_time)))
                    {
                        pages.Add(nameof(targeted_total_of_time), new targeted_total_of_time());
                    }
                    LoadNewPage(pages[nameof(targeted_total_of_time)]);
                    break;
                case ClassToCall.TotalTimeCustom:
                    if (!pages.ContainsKey(nameof(targeted_total_of_time_comp)))
                    {
                        pages.Add(nameof(targeted_total_of_time_comp), new targeted_total_of_time_comp());
                    }
                    LoadNewPage(pages[nameof(targeted_total_of_time_comp)]);
                    break;
                case ClassToCall.CompetePound:
                    if (!pages.ContainsKey(nameof(ComboScoreCompControl)))
                    {
                        pages.Add(nameof(ComboScoreCompControl), new ComboScoreCompControl());
                    }
                    LoadNewPage(pages[nameof(ComboScoreCompControl)]);
                    break;
                case ClassToCall.SensorAdj:
                    if (!pages.ContainsKey(nameof(CensorControl)))
                    {
                        pages.Add(nameof(CensorControl), new CensorControl());
                    }
                    LoadNewPage(pages[nameof(CensorControl)]);
                    break;
                case ClassToCall.PunchCount:
                    if (!pages.ContainsKey(nameof(punch_count)))
                    {
                        pages.Add(nameof(punch_count), new punch_count());
                    }
                    LoadNewPage(pages[nameof(punch_count)]);
                    break;
                case ClassToCall.PunchCountCustom:
                    if (!pages.ContainsKey(nameof(punch_count_comp)))
                    {
                        pages.Add(nameof(punch_count_comp), new punch_count_comp());
                    }
                    LoadNewPage(pages[nameof(punch_count_comp)]);
                    break;
                case ClassToCall.PunchChallenge:
                    if (!pages.ContainsKey(nameof(punch_challenge)))
                    {
                        pages.Add(nameof(punch_challenge), new punch_challenge());
                    }
                    LoadNewPage(pages[nameof(punch_challenge)]);
                    break;
                case ClassToCall.PunchChallengeCustom:
                    if (!pages.ContainsKey(nameof(punch_challenge_comp)))
                    {
                        pages.Add(nameof(punch_challenge_comp), new punch_challenge_comp());
                    }
                    LoadNewPage(pages[nameof(punch_challenge_comp)]);
                    break;
                default:
                    break;
            }
        }

    }
}

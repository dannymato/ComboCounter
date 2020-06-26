using ComboCounter.Classes;
using ComboCounter.Forms;
using ComboCounter.UserControls;
using ComboCounter.UserControls_Gabriel;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ComboCounter
{

    public partial class Main : Form
    {
        HomeScreen home;
        
        ComboScoreControl comboScore;

        targeted_total_of_force totalForce;
        targeted_total_of_force_comp totalForceComp;
        targeted_total_of_time totalTime;
        targeted_total_of_time_comp totalTimeComp;
        ComboScoreCompControl poundForPound;
        CensorControl sensorAdj;
        punch_count punchCount;
        punch_count_comp punchCountComp;
        punch_challenge punchChallenge;
        punch_challenge_comp punchChallengeComp;

        UserAccount userAccount;



        public Main()
        {
            InitializeComponent();

        }

        #region Force Tracker
        private void force_tracker_Click(object sender, EventArgs e)
        {
            if (sensorAdj == null)
            {
                sensorAdj = new CensorControl();
            }
            LoadNewPage(sensorAdj);
        }

        #endregion

        #region Welcome Page
        private void home_button_Click(object sender, EventArgs e)
        {
            mainPanel.Hide();
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(home);
            mainPanel.Show();
        }

        #endregion

        private void user_button_Click(object sender, EventArgs e)
        {
            //Forms.justToTry UserAccountForm = new Forms.justToTry();
            // UserAccountForm.Show();

            Forms.UserAccountForm UserAccountForm = new Forms.UserAccountForm();
            UserAccountForm.Show();

            if (userAccount == null)
            {
                userAccount = new UserAccount();
            }
            LoadNewPage(userAccount);

            // user_control1.BringToFront();
        }

        private void exit_button_Click(object sender, EventArgs e)
        {

            Forms.Exit exit = new Forms.Exit();
            exit.ExitApplication += (s, arg) => { Close(); };

            exit.ClientSize = new Size(Width, Height);
            exit.Show();

        }

        
        private void time_button_Click(object sender, EventArgs e)
        {
            // Currently shows exit but is now disabled
            /* Forms.Exit QuickStartForm = new Forms.Exit();
             QuickStartForm.Show();*/
        }

        private void histogram_Click(object sender, EventArgs e)
        {
            LoadNewPage(new histogram());
        }

        private void Main_Load(object sender, EventArgs e)
        {

            ToolTip HomeToolTip = new ToolTip();
            HomeToolTip.SetToolTip(home_button, "Home");
            HomeToolTip.SetToolTip(force_tracker, "Force Tracker");
            HomeToolTip.SetToolTip(time_button, "Time Tracker");
            HomeToolTip.SetToolTip(histogram, "Show History");
            HomeToolTip.SetToolTip(user_button, "Show/Edit User Information");
            HomeToolTip.SetToolTip(exit_button, "Exit Program");

            Rectangle screenSize = Screen.PrimaryScreen.Bounds;
            Width = screenSize.Width;
            Height = screenSize.Height;

            home = new HomeScreen();
            mainPanel.Controls.Add(home);
            mainPanel.Width = Width;
            mainPanel.Height = Height - tableLayoutPanel1.Height;
            mainPanel.Location = new Point(0, tableLayoutPanel1.Height);

            home.Width = mainPanel.Width;
            home.Height = mainPanel.Height;

            BackColor = ThemeManager.initBackground();

            home.OnOptionClicked += (send, args) => {

                // Determines which control to page in depending on the argument passed through the event
                switch (args.ClassToCall)
                {
                    case ClassToCall.ComboCounter:
                        if (comboScore == null)
                        {
                            comboScore = new ComboScoreControl();
                        }
                        LoadNewPage(comboScore);
                        break;
                    case ClassToCall.TotalForce:
                        if (totalForce == null)
                        {
                            totalForce = new targeted_total_of_force();
                        }
                        LoadNewPage(totalForce);
                        break;
                    case ClassToCall.TotalForce2Play:
                        if (totalForceComp == null)
                        {
                            totalForceComp = new targeted_total_of_force_comp();
                        }
                        LoadNewPage(totalForceComp);
                        break;
                    case ClassToCall.TotalTime:
                        if (totalTime == null)
                        {
                            totalTime = new targeted_total_of_time();
                        }
                        LoadNewPage(totalTime);
                        break;
                    case ClassToCall.TotalTimeCustom:
                        if (totalTimeComp == null)
                        {
                            totalTimeComp = new targeted_total_of_time_comp();
                        }
                        LoadNewPage(totalTimeComp);
                        break;
                    case ClassToCall.CompetePound:
                        if (poundForPound == null)
                        {
                            poundForPound = new ComboScoreCompControl();
                        }
                        LoadNewPage(poundForPound);
                        break;
                    case ClassToCall.SensorAdj:
                        if (sensorAdj == null)
                        {
                            sensorAdj = new CensorControl();
                        }
                        LoadNewPage(sensorAdj);
                        break;
                    case ClassToCall.PunchCount:
                        if (punchCount == null)
                        {
                            punchCount = new punch_count();
                        }
                        LoadNewPage(punchCount);
                        break;
                    case ClassToCall.PunchCountCustom:
                        if (punchCountComp == null)
                        {
                            punchCountComp = new punch_count_comp();
                        }
                        LoadNewPage(punchCountComp);
                        break;
                    case ClassToCall.PunchChallenge:
                        if (punchChallenge == null)
                        {
                            punchChallenge = new punch_challenge();
                        }
                        LoadNewPage(punchChallenge);
                        break;
                    case ClassToCall.PunchChallengeCustom:
                        if (punchChallengeComp == null)
                        {
                            punchChallengeComp = new punch_challenge_comp();
                        }
                        LoadNewPage(punchChallengeComp);
                        break;
                    default:
                        break;
                }
            };


        }

        // Removes the old page in the panel and places the new one in
        // With the exception of the history page the old pages are still kept in memory for quicker access
        private void LoadNewPage(UserControl newPage)
        {
            this.mainPanel.Hide();
            this.mainPanel.Controls.Clear();
            this.mainPanel.Controls.Add(newPage);
            newPage.Anchor = AnchorStyles.None;
            newPage.Left = (mainPanel.Width - newPage.Width) / 2;
            newPage.Top = (mainPanel.Height - newPage.Height) / 2;
            this.mainPanel.Show();
        }

    }
}

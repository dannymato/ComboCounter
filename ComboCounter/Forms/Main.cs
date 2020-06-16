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



        public Main()
        {
            InitializeComponent();

        }

        #region Force Tracker
        private void force_tracker_Click(object sender, EventArgs e)
        {
            Forms.SensorAdjusments SensorAdjusments = new Forms.SensorAdjusments();
            SensorAdjusments.Show();

            // combo_tracker1.BringToFront();
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
             Forms.Exit QuickStartForm = new Forms.Exit();
             QuickStartForm.Show();

            //Forms.QuickStartForm QuickStartForm = new Forms.QuickStartForm();
            // QuickStartForm.Show();

            // timeMode1.BringToFront();
        }

        private void histogram_Click(object sender, EventArgs e)
        {
            LoadNewPage(new histogram());
        }

        private void Main_Load(object sender, EventArgs e)
        {
            // homeControl1.BringToFront();
            // home_user1.BringToFront();;

            ToolTip HomeToolTip = new ToolTip();
            HomeToolTip.SetToolTip(home_button, "Home");
            HomeToolTip.SetToolTip(force_tracker, "Force Tracker");
            HomeToolTip.SetToolTip(time_button, "Time Tracker");
            HomeToolTip.SetToolTip(histogram, "Show History");
            HomeToolTip.SetToolTip(user_button, "Show/Edit User Information");
            HomeToolTip.SetToolTip(exit_button, "Exit Program");

            FontManager fm = FontManager.getInstance();
            label1.Font = fm.getHeader3Font();
            label3.Font = fm.getHeader3Font();
            label6.Font = fm.getHeader3Font();
            label5.Font = fm.getHeader3Font();
            label2.Font = fm.getHeader3Font();
            label4.Font = fm.getHeader3Font();

            button1.Font = fm.getButtonFont();
            vstimeBtn.Font = fm.getButtonFont();
            ComboButton.Font = fm.getButtonFont();
            button6.Font = fm.getButtonFont();
            button10.Font = fm.getButtonFont();
            button9.Font = fm.getButtonFont();
            button3.Font = fm.getButtonFont();
            button7.Font = fm.getButtonFont();
            button4.Font = fm.getButtonFont();
            button8.Font = fm.getButtonFont();
            button5.Font = fm.getButtonFont();
            button2.Font = fm.getButtonFont();

            Rectangle screenSize = Screen.PrimaryScreen.Bounds;
            Width = screenSize.Width;
            Height = screenSize.Height;

            Console.WriteLine(screenSize);

            home = new HomeScreen();
            this.mainPanel.Controls.Add(home);
            this.mainPanel.Width = this.Width;
            this.mainPanel.Height = this.Height - tableLayoutPanel1.Height;
            mainPanel.Location = new Point(0, tableLayoutPanel1.Height);

            home.Width = mainPanel.Width;
            home.Height = mainPanel.Height;

            home.OnOptionClicked += (send, args) => {
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
                        LoadNewPage(totalForce);
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

        private void LoadNewPage(UserControl newPage)
        {
            this.mainPanel.Hide();
            this.mainPanel.Controls.Clear();
            this.mainPanel.Controls.Add(newPage);
            newPage.Size = new Size(mainPanel.Width, mainPanel.Height);
            newPage.Dock = DockStyle.Fill;
            this.mainPanel.Show();
        }

        private void quickStart1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Forms.TargetedTotalForce TargetedTotalForce = new Forms.TargetedTotalForce();
            TargetedTotalForce.Show();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ComboButton_Click(object sender, EventArgs e)
        {
            Forms.ComboScore ComboScore = new Forms.ComboScore();
            ComboScore.Show();

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Forms.PunchCount PunchCount = new Forms.PunchCount();
               PunchCount.Show();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Forms.CustomPunchCount CustomPunchCount = new Forms.CustomPunchCount();
            CustomPunchCount.Show();

        }

        private void vstimeBtn_Click(object sender, EventArgs e)
        {
            Forms.TargetTotalForceComp CustomTargetTotalForm = new Forms.TargetTotalForceComp();
            CustomTargetTotalForm.Show();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Forms.CustomTargetTotalTime CustomTargetTotalTime = new Forms.CustomTargetTotalTime();
            CustomTargetTotalTime.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Forms.TargetTotalTime TargetTotalTime = new Forms.TargetTotalTime();
            TargetTotalTime.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Forms.PunchChallange PunchChallange = new Forms.PunchChallange();
            PunchChallange.Show();


        }

        private void button8_Click(object sender, EventArgs e)
        {
            Forms.CustomPunchChallange CustomPunchChallange = new Forms.CustomPunchChallange();
            CustomPunchChallange.Show();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Forms.CustomComboScore CustomComboScore = new Forms.CustomComboScore();
            CustomComboScore.Show();

        }


        private void button9_Click(object sender, EventArgs e)
        {
            Forms.SensorAdjusments SensorAdjusments = new Forms.SensorAdjusments();
            SensorAdjusments.Show();


        }

        private void button10_Click(object sender, EventArgs e)
        {
            Forms.ComboScoreComp ComboScoreComp = new Forms.ComboScoreComp();
            ComboScoreComp.Show();

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void homeScreen1_Load(object sender, EventArgs e)
        {

        }
    }
}

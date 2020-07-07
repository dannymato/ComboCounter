using System;
using System.Windows.Forms;
using ComboCounter.Classes;
using System.Diagnostics;

namespace ComboCounter.UserControls
{
    public partial class targeted_total_of_time : BaseFormControl
    {

        const int timeIntervalDefault = 30;
        int totalForceBox;

        int timeIntervalSecs = 30;

        Session session;
        Stopwatch timeKeeper;

        public targeted_total_of_time()
        {
            InitializeComponent();
            timeKeeper = new Stopwatch();
            timer1 = new Timer();
            timer1.Interval = 100;
            timer1.Tick += new EventHandler(timer1_Tick);
        }

        // Start Button
        private void button1_Click(object sender, EventArgs e)
        {
            if (!timer1.Enabled)
            {
                timer1.Start();
                session = new Session(DateTime.Now);
                timeKeeper.Start();
            }
        }

        // Reset Button
        private void resetButton_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            timeIntervalSecs = timeIntervalDefault;
            setTime.Text = Tools.FormatTimeSetter(timeIntervalSecs);
            currentTime.Text = Tools.FormatCurrentTime(0);
            totalForceBox = 0;
            totalForce.Text = "0";
            timeKeeper.Reset();
        }

        private void setTimeSec_Click(object sender, EventArgs e)
        {

        }

        private void home_user2_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            long remainingMsecs = (timeIntervalSecs * 1000) - timeKeeper.ElapsedMilliseconds;

            currentTime.Text = Tools.FormatCurrentTime(remainingMsecs);
            
            totalForceBox += 50;
            totalForce.Text = totalForceBox.ToString();
            session.insertHit(50, timeKeeper.Elapsed.TotalSeconds);

            if (remainingMsecs <= 0)
            {
                timer1.Stop();
                timeKeeper.Stop();
                History.InsertSession(session);
            }
        }

        private void minusIcon_Click(object sender, EventArgs e)
        {
            timeIntervalSecs -= 15;
            if (timeIntervalSecs < 15)
            {
                timeIntervalSecs = 15;
            }
            setTime.Text = Tools.FormatTimeSetter(timeIntervalSecs);
        }

        private void plusIcon_Click(object sender, EventArgs e)
        {
            timeIntervalSecs += 15;
            setTime.Text = Tools.FormatTimeSetter(timeIntervalSecs);
        }

        private void PauseTimers()
        {
            timer1.Stop();
            timeKeeper.Stop();
        }


        public override void OnPageRemoved()
        {
            if (UserManager.TimerSetting())
            {
                PauseTimers();
            }
        }

    }
}

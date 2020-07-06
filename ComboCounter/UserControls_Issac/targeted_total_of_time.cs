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
        }

        // Start Button
        private void button1_Click(object sender, EventArgs e)
        {
            timer1 = new System.Windows.Forms.Timer();
            timer1.Interval = 100;
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Enabled = true;
            totalForceBox = 0;
            session = new Session(DateTime.Now);
            timeKeeper.Start();
        }

        // Reset Button
        private void resetButton_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            timeIntervalSecs = timeIntervalDefault;
            updateTimeSetter();
            currentTime.Text = "00:00.0";
            totalForceBox = 0;
            totalForce.Text = "0";
            timeKeeper.Reset();
        }

        private void updateTimeSetter()
        {
            setTime.Text = String.Format("{0:00}:{1:00}", timeIntervalSecs / 60, (timeIntervalSecs % 60));
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

            long secs = (remainingMsecs / 1000 % 60);
            long mins = remainingMsecs / 1000 / 60;
            long mSecs = remainingMsecs % 1000 / 100;

            currentTime.Text = String.Format("{0:00}:{1:00}.{2:0}", mins, secs, mSecs);
            
            totalForceBox = totalForceBox + 50;
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
            updateTimeSetter();
        }

        private void plusIcon_Click(object sender, EventArgs e)
        {
            timeIntervalSecs += 15;
            updateTimeSetter();
        }

        private void PauseTimers()
        {
            timer1.Stop();
            timeKeeper.Stop();
        }

        public override void OnPageAttached()
        {
            
        }

        public override void OnPageRemoved()
        {
            if (UserManager.UserSettings.TurnOffTimers)
            {
                PauseTimers();
            }
        }

        public override void OnExit()
        {

        }
    }
}

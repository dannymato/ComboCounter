using System;
using System.Windows.Forms;
using System.Timers;
using System.Media;
using System.Diagnostics;
using ComboCounter.Classes;

namespace ComboCounter.UserControls
{
    public partial class targeted_total_of_force : BaseFormControl
    {
        System.Timers.Timer t;
        int totalForceBox;
        int forceGoalNum = 15000;

        const int FORCE_INTERVAL = 100;

        Stopwatch stopwatch = new Stopwatch();
        Session session;

        public targeted_total_of_force()
        {
            InitializeComponent();
            header.Left = (Width - header.Width) / 2;
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            t.Start();
            session = new Session(DateTime.Now);
            stopwatch.Start();
        }

        private void targeted_total_of_force_Load(object sender, EventArgs e)
        {

            this.splitContainer1.SplitterDistance = Width / 2;

            t = new System.Timers.Timer();
            t.Interval = 100;
            t.Elapsed += OnTimeEvent;
            
        }

        private void plusIcon_Click(object sender, EventArgs e)
        {
            forceGoalNum += FORCE_INTERVAL;
            forceGoalLabel.Text = string.Format("{0:n0}", forceGoalNum);
        }

        private void minusIcon_Click(object sender, EventArgs e)
        {
            if (forceGoalNum != 0)
            {
                forceGoalNum -= FORCE_INTERVAL;
                forceGoalLabel.Text = string.Format("{0:n0}", forceGoalNum);
            }
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void OnTimeEvent(object sender, ElapsedEventArgs e)
        {
            SoundPlayer bellRing = new SoundPlayer(@"soundEffect\old-fashioned-bell.wav");
            Invoke(new Action(() =>
            {


                long seconds = stopwatch.ElapsedMilliseconds / 1000 % 60;
                long minutes = stopwatch.ElapsedMilliseconds / 1000 / 60;
                long fracSecs = stopwatch.ElapsedMilliseconds % 1000 / 100;

           
                txtResult.Text = string.Format("{0:00}:{1:00}.{2:0}", minutes, seconds, fracSecs);

                if (totalForceBox >= forceGoalNum)
                {
                    totalForce.ForeColor = System.Drawing.Color.Green;
                    bellRing.Play();
                    t.Stop();
                    stopwatch.Stop();
                    History.InsertSession(session);
                }
                else
                {
                    double time = stopwatch.Elapsed.TotalSeconds;
                    int newForce = new Random().Next(100, 700);
                    totalForceBox = totalForceBox + newForce;
                    totalForce.Text = totalForceBox.ToString();

                    session.insertHit(newForce, time);


                }
            }));
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            PauseTimers();
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            t.Stop();
            totalForceBox = 0;
            totalForce.Text = "0";
            txtResult.Text = "00:00.00";
            totalForce.ForeColor = System.Drawing.Color.DimGray;
            stopwatch.Stop();
            stopwatch.Reset(); 

        }

        private void PauseTimers()
        {
            t.Stop();
            stopwatch.Stop();
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

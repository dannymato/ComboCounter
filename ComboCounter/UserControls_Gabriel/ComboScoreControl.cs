using System.Windows.Forms;
using System.Timers;
using System;
using System.Media;
using ComboCounter.Classes;
using MySqlX.XDevAPI.Relational;
using System.Drawing;
using ComboCounter.CustomControls;

namespace ComboCounter.UserControls_Gabriel
{
    public partial class ComboScoreControl : BaseFormControl
    {
        System.Timers.Timer t;
        int h, m, s, totalForceBox;
        int actualForce = 50000;

        const float MAX_FORCE = 1600;

        const int MAX_LENGTH = 200;

        SmallInfo[] forceLabels = new SmallInfo[9];
        SmallInfo[] timeLabels = new SmallInfo[8];

        DateTime animationStart;
        TimeSpan animationDuration = new TimeSpan(1000000);

        VisualFeedbackControl feedbackControl;

        int forceIndex = 0;

        int timeLabelIndex = 0;

        readonly int[] forceArray = new int[] { 90, 152, 1041, 1541, 1098, 1012, 43, 704, 632, 323, 451, 341, 456, 711, 634 };
        readonly double[] timeArray = new double[] { 0.078, 0.297, 0.360, 0.500, 0.390, 0.300, 0.266, 0.438, .232, .453, .342, .235, .543, .343 };

        double cumulativeTime = 0.0;


        Session session;

        public ComboScoreControl()
        {
            InitializeComponent();
            feedbackControl = new VisualFeedbackControl();
            feedbackControl.Height = 80;
            feedbackControl.Left = 1000;
            feedbackControl.Top = 180;
            Controls.Add(feedbackControl);

        }

        // Start Button
        private void button1_Click(object sender, System.EventArgs e)
        {
            t.Start();
            session = new Session(DateTime.Now);
            
        }

        //Stop Button
        private void button2_Click(object sender, EventArgs e)
        {
            t.Stop();
        }

        //Reset Button
        private void button3_Click(object sender, EventArgs e)
        {
            t.Stop();
            s = 0; m = 0; h = 0;
            totalForceBox = 0;
            totalTime.Text = "00:00.0";

            scoreInfoLabel.Text = " N/A";
            totalTimeLabelnfo.Text = " N/A";

            //   totalForce.ForeColor = System.Drawing.Color.DimGray;
            for (int i = 0; i < forceLabels.Length; i++)
            {
                forceLabels[i].Text = "";
            }
            for (int i = 0; i < timeLabels.Length; i++)
            {
                timeLabels[i].Text = "";
            }

            forceIndex = 0;

            timeLabelIndex = 0;
        }

        private void PauseTimers()
        {
            t.Stop();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, System.EventArgs e)
        {

        }

        //private void IndicateHit(float force)
        //{
        //    System.Timers.Timer animate = new System.Timers.Timer();
        //    animate.Interval = 16;
        //    animate.Elapsed += (object sender, ElapsedEventArgs e) =>
        //    {
        //        TimeSpan span = e.SignalTime - animationStart;
        //        double percentTime = span.TotalMilliseconds / animationDuration.TotalMilliseconds;

        //        if (span >= animationDuration)
        //        {
        //            animate.Stop();
        //        }

        //        float percentForce = force / MAX_FORCE;

        //        Color forceColor = Tools.Interpolate(Color.Red, Color.Yellow, Color.Green, percentForce);
        //        int width = (int)(Math.Min(MAX_LENGTH, (MAX_LENGTH * percentForce + 40)));

        //        punchIndicator.Invoke((MethodInvoker)delegate
        //        {
        //            punchIndicator.Width = width;
        //        });
        //        punchIndicator.BackColor = Color.FromArgb((int)(255 * percentTime), forceColor.R, forceColor.G, forceColor.B);
        //    };
        //    animationStart = DateTime.Now;
        //    animate.Start();

        //}

        private void ComboScoreControl_Load(object sender, System.EventArgs e)
        {
            t = new System.Timers.Timer();
            t.Interval = 1;
            t.Elapsed += OnTimeEvent;

            FontManager fm = FontManager.getInstance();

            for (int i = 0; i < forceLabels.Length; i++)
            {

                forceLabels[i] = new SmallInfo
                {
                    Text = "Hit " + (i + 1),
                    TextAlign = ContentAlignment.MiddleCenter,
                    Anchor = AnchorStyles.None,
                    Dock = DockStyle.Fill
                };
                tableLayoutPanel1.Controls.Add(forceLabels[i]);
            }

            for (int i = 0; i < timeLabels.Length; i++)
            {
                timeLabels[i] = new SmallInfo
                {
                    TextAlign = ContentAlignment.MiddleCenter,
                    Anchor = AnchorStyles.None,
                    Dock = DockStyle.Fill
                };
                tableLayoutPanel2.Controls.Add(timeLabels[i]);
            }

            headerLabel.Font = fm.getHeaderFont();
            forceHeader.Font = fm.getHeader3Font();
            timeLabel.Font = fm.getHeader3Font();

            button1.Font = fm.getButtonFont();
            button2.Font = fm.getButtonFont();
            button3.Font = fm.getButtonFont();

            scoreLabel.Font = fm.getHeader3Font();
            totalTimeLabel.Font = fm.getHeader3Font();

            scoreInfoLabel.Font = fm.getHeader3Font();
            totalTimeLabelnfo.Font = fm.getHeader3Font();

        }

        private void OnTimeEvent(object sender, ElapsedEventArgs e)
        {
            Invoke(new Action(() =>
            {
                s += 1;
                if (s == 60)
                {
                    s = 0;
                    m += 1;
                }
                if (m == 60)
                {
                    m = 0;
                    h += 1;
                }

                if (s % 30 == 0)
                {
                    ;
                    if (forceIndex >= forceLabels.Length)
                    {
                        for (int i = 0; i < forceLabels.Length; i++)
                        {
                            forceLabels[i].Text = forceArray[forceIndex - (forceLabels.Length - i) + 1].ToString();
                        }
                        for (int i = 0; i < timeLabels.Length; i++)
                        {
                            timeLabels[i].Text = timeArray[forceIndex - (timeLabels.Length - i)].ToString();
                        }
                    }
                    else if (forceIndex > 0)
                    {
                        feedbackControl.PushPunch(forceArray[forceIndex]);
                        cumulativeTime += timeArray[forceIndex - 1];
                        timeLabels[forceIndex - 1].Text = timeArray[forceIndex - 1].ToString();
                        session.insertHit(forceArray[forceIndex], cumulativeTime);
                        forceLabels[forceIndex].Text = forceArray[forceIndex].ToString();
                        forceLabels[forceIndex].ForeColor = System.Drawing.Color.CadetBlue;
                        
                    }
                    else
                    {
                        forceLabels[forceIndex].Text = forceArray[forceIndex].ToString();
                        forceLabels[forceIndex].ForeColor = System.Drawing.Color.CadetBlue;
                        
                    }
                    forceIndex++;


                    totalTime.Text = string.Format("{0:00}:{1:00}:{2:00}", h, m, s);
                    if (forceIndex >= forceArray.Length)
                    {
                        SoundPlayer bellRing = new SoundPlayer(@"soundEffect\old-fashioned-bell.wav");
                        scoreInfoLabel.Text = string.Format("{0:n0} N", session.TotalForce);
                        totalTimeLabelnfo.Text = string.Format("{0:0.00} s", cumulativeTime);
                        bellRing.Play();
                        t.Stop();

                        History.InsertSession(session);

                    }

                }
                
            }));

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

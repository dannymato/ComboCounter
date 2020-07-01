using System.Windows.Forms;
using System.Timers;
using System;
using System.Media;
using ComboCounter.Classes;
using MySqlX.XDevAPI.Relational;

namespace ComboCounter.UserControls_Gabriel
{
    public partial class ComboScoreControl : BaseFormControl
    {
        System.Timers.Timer t;
        int h, m, s, totalForceBox;
        int actualForce = 50000;

        SmallInfo[] forceLabels = new SmallInfo[9];
        SmallInfo[] timeLabels = new SmallInfo[8];

        int forceIndex = 0;

        int timeLabelIndex = 0;

        int[] forceArray = new int[] { 90, 152, 1041, 1541, 1098, 1012, 43, 704, 632, 323, 451, 341, 456, 711, 634 };
        double[] timeArray = new double[] { 0.078, 0.297, 0.360, 0.500, 0.390, 0.300, 0.266, 0.438, .232, .453, .342, .235, .543, .343 };

        double cumulativeTime = 0.0;


        Session session;

        public ComboScoreControl()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

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
                    TextAlign = System.Drawing.ContentAlignment.MiddleCenter,
                    Anchor = AnchorStyles.None,
                    Dock = DockStyle.Fill
                };
                tableLayoutPanel1.Controls.Add(forceLabels[i]);
            }

            for (int i = 0; i < timeLabels.Length; i++)
            {
                timeLabels[i] = new SmallInfo
                {
                    TextAlign = System.Drawing.ContentAlignment.MiddleCenter,
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
                        scoreInfoLabel.Text = string.Format("{0:n0} N", session.GetTotalForce());
                        totalTimeLabelnfo.Text = string.Format("{0:0.00} s", cumulativeTime);
                        bellRing.Play();
                        t.Stop();

                        History.InsertSession(session);

                    }

                }
                
            }));

        }

        public override void OnPageAttached()
        {
        }

        public override void OnPageRemoved()
        {
        }

        public override void OnExit()
        {

        }
    }
}

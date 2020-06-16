using System.Windows.Forms;
using System.Timers;
using System;
using System.Media;
using ComboCounter.Classes;
using MySqlX.XDevAPI.Relational;

namespace ComboCounter.UserControls_Gabriel
{
    public partial class ComboScoreControl : UserControl
    {
        System.Timers.Timer t;
        int h, m, s, totalForceBox;
        int actualForce = 50000;

        Label[] forceLabels = new Label[9];
        Label[] timeLabels = new Label[8];

        int forceLabelIndex = 0;
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
            txtResult.Text = "00:00.0";

            label23.Text = " N/A";
            label24.Text = " N/A";

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
            forceLabelIndex = 0;

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

                forceLabels[i] = new Label
                {
                    Text = "Hit " + (i + 1),
                    ForeColor = System.Drawing.Color.DimGray,
                    Font = fm.getSmallInfoFont(),
                    TextAlign = System.Drawing.ContentAlignment.MiddleCenter,
                    Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom,
                    Dock = DockStyle.Fill
                };
                tableLayoutPanel1.Controls.Add(forceLabels[i]);
            }

            for (int i = 0; i < timeLabels.Length; i++)
            {
                timeLabels[i] = new Label
                {
                    ForeColor = System.Drawing.Color.DimGray,
                    Font = fm.getSmallInfoFont(),
                    TextAlign = System.Drawing.ContentAlignment.MiddleCenter,
                    Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom,
                    Dock = DockStyle.Fill
                };
                tableLayoutPanel2.Controls.Add(timeLabels[i]);
            }

            label7.Font = fm.getHeaderFont();
            label19.Font = fm.getHeader3Font();
            label20.Font = fm.getHeader3Font();

            button1.Font = fm.getButtonFont();
            button2.Font = fm.getButtonFont();
            button3.Font = fm.getButtonFont();

            label21.Font = fm.getHeader3Font();
            label22.Font = fm.getHeader3Font();

            label23.Font = fm.getHeader3Font();
            label24.Font = fm.getHeader3Font();

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


                    txtResult.Text = string.Format("{0}:{1}:{2}", h.ToString().PadLeft(2, '0'), m.ToString().PadLeft(2, '0'), s.ToString().PadLeft(2, '0'));
                    if (forceIndex >= forceArray.Length)
                    {
                        SoundPlayer bellRing = new SoundPlayer(@"soundEffect\old-fashioned-bell.wav");
                        label23.Text = string.Format("{0:n0} N", session.GetTotalForce());
                        label24.Text = string.Format("{0:0.00} s", cumulativeTime);
                        bellRing.Play();
                        t.Stop();

                        History.GetSessions().Add(session);

                    }

                }
                
            }));

        }

    }
}

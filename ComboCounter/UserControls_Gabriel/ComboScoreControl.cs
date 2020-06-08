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

        int[] forceArray = new int[] { 90, 152, 1041, 1541, 1098, 1012, 43, 704 };
        double[] timeArray = new double[] { 0.078, 0.297, 0.360, 0.500, 0.390, 0.300, 0.266, 0.438 };

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
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
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

            for (int i = 0; i < forceLabels.Length; i++)
            {

                forceLabels[i] = new Label();
                forceLabels[i].Text = "Hit " + (i + 1);
                forceLabels[i].ForeColor = System.Drawing.Color.DimGray;
                forceLabels[i].Font = new System.Drawing.Font("Times New Roman", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                forceLabels[i].Height = tableLayoutPanel1.Height;
                tableLayoutPanel1.Controls.Add(forceLabels[i]);
            }

            for (int i = 0; i < timeLabels.Length; i++)
            {
                timeLabels[i] = new Label();
                timeLabels[i].ForeColor = System.Drawing.Color.DimGray;
                timeLabels[i].Font = new System.Drawing.Font("Times New Roman", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
                timeLabels[i].Height = tableLayoutPanel2.Height;
                tableLayoutPanel2.Controls.Add(timeLabels[i]);
            }

            

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
                    forceLabels[forceLabelIndex].Text = forceArray[forceIndex].ToString();
                    forceLabels[forceLabelIndex].ForeColor = System.Drawing.Color.CadetBlue;
                    if (forceIndex > 0)
                    {
                        cumulativeTime += timeArray[forceIndex - 1];
                        timeLabels[timeLabelIndex].Text = timeArray[forceIndex - 1].ToString();
                        session.insertHit(forceArray[forceIndex], cumulativeTime);
                        timeLabelIndex = (timeLabelIndex + 1) % 8;
                    }
                    forceIndex++;
                    forceLabelIndex = (forceLabelIndex + 1) % 9;
                }

                txtResult.Text = string.Format("{0}:{1}:{2}", h.ToString().PadLeft(2, '0'), m.ToString().PadLeft(2, '0'), s.ToString().PadLeft(2, '0'));
                if (forceIndex >= forceArray.Length)
                {
                    SoundPlayer bellRing = new SoundPlayer(@"soundEffect\old-fashioned-bell.wav");
                    label23.Text = "4,933.98'N";
                    label24.Text = "1.25's";
                    bellRing.Play();
                    // totalForce.ForeColor = System.Drawing.Color.Green;
                    // bellRing.Play();
                    t.Stop();

                    History.GetSessions().Add(session);

                }
                else
                {
                      totalForceBox = totalForceBox + 50;
                  //  totalForce.Text = totalForceBox.ToString();
                }
            }));

        }

    }
}

using System.Windows.Forms;
using System.Timers;
using System;
using System.Media;
using ComboCounter.Classes;

namespace ComboCounter.UserControls_Gabriel
{
    public partial class ComboScoreControl : UserControl
    {
        System.Timers.Timer t;
        int h, m, s, totalForceBox;
        int actualForce = 50000;

        Label[] forceLabels = new Label[9];



        int[] forceArray = new int[] { 90, 152, 1041, 1541, 1098, 1012, 43, 704 };
        double[] timeArray = new double[] { 0.078, 0.297, 0.360, 0.500, 0.390, 300, 0.266, 0.438 };

        double cumulativeTime = 0.0;

        Session session;

        public ComboScoreControl()
        {
            session = new Session(DateTime.Now);
            InitializeComponent();
        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        // Start Button
        private void button1_Click(object sender, System.EventArgs e)
        {
            t.Start();
            
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

            label13.Text = "";
            label14.Text = "";
            label11.Text = "";
            label12.Text = "";
            label17.Text = "";

            label23.Text = " N/A";
            label24.Text = " N/A";

            //   totalForce.ForeColor = System.Drawing.Color.DimGray;
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
                tableLayoutPanel1.Controls.Add(forceLabels[i]);
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

                txtResult.Text = string.Format("{0}:{1}:{2}", h.ToString().PadLeft(2, '0'), m.ToString().PadLeft(2, '0'), s.ToString().PadLeft(2, '0'));
                if (totalForceBox == actualForce)
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

using System.Windows.Forms;
using System.Timers;
using System;
using System.Media;

namespace ComboCounter.UserControls_Gabriel
{
    public partial class ComboScoreControl : UserControl
    {
        System.Timers.Timer t;
        int h, m, s, totalForceBox;
        int actualForce = 50000;



        int[] forceArray = new int[] { 90, 152, 1041, 1541, 1098, 1012, 43, 704 };
        double[] timeArray = new double[] { 0.078, 0.297, 0.360, 0.500, 0.390, 300, 0.266, 0.438 };

        public ComboScoreControl()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            t.Start();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            t.Stop();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            t.Stop();
            s = 0; m = 0; h = 0;
            totalForceBox = 0;
            txtResult.Text = "00:00.0";


            label1.Text = "Hit1";
            label2.Text = "Hit2";
            label3.Text = "Hit3";
            label4.Text = "Hit4";
            label5.Text = "Hit5";
            label6.Text = "Hit6";

            label13.Text = "";
            label14.Text = "";
            label11.Text = "";
            label12.Text = "";
            label17.Text = "";

            label23.Text = " N/A";
            label24.Text = " N/A";

            label1.ForeColor = System.Drawing.Color.DimGray;
            label2.ForeColor = System.Drawing.Color.DimGray;
            label3.ForeColor = System.Drawing.Color.DimGray;
            label4.ForeColor = System.Drawing.Color.DimGray;
            label5.ForeColor = System.Drawing.Color.DimGray;
            label6.ForeColor = System.Drawing.Color.DimGray;

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

                if (m == 2)
                {
                    label1.Text = "" + forceArray[0];
                    label1.ForeColor = System.Drawing.Color.Red;
                }

                if ( m == 4) 
                {

                    label2.Text = "" + forceArray[1];
                    label2.ForeColor = System.Drawing.Color.Red;

                    label13.Text = " " + timeArray[0];
                    label13.ForeColor = System.Drawing.Color.Green;
                }

                if ( m == 6)
                {

                    label3.Text = "" + forceArray[2];
                    label3.ForeColor = System.Drawing.Color.Green;

                    label14.Text = " " + timeArray[1];
                    label14.ForeColor = System.Drawing.Color.Red;

                }

                if (m == 8) 
                {
                    label4.Text = "" + forceArray[3];
                    label4.ForeColor = System.Drawing.Color.Green;

                    label11.Text = " " + timeArray[2];
                    label11.ForeColor = System.Drawing.Color.Red;
                }

                if (m == 10) 
                {
                    label5.Text = "" + forceArray[4];
                    label5.ForeColor = System.Drawing.Color.Green;

                    label12.Text = " " + timeArray[3];
                    label12.ForeColor = System.Drawing.Color.Red;
                }

                if (m == 12)
                {
                    label6.Text = "" + forceArray[5];
                    label6.ForeColor = System.Drawing.Color.Green;

                    label17.Text = " " + timeArray[4];
                    label17.ForeColor = System.Drawing.Color.Red;
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

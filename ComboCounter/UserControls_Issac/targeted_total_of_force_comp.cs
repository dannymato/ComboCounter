using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;
using System.Media;

namespace ComboCounter.UserControls
{
    public partial class targeted_total_of_force_comp : UserControl
    {
        System.Timers.Timer t;
        System.Timers.Timer t1;
        int h, m, s, totalForceBox;
        int h1, m1, s1, totalForceBox1;
        string timerOn, timerOn1;
        string timerStart = "On";
        int forceGoal2 = 15;
        int forceGoal3 = 15;
        int actualforce = 15000;
        int actualForce1 = 15000;

        public targeted_total_of_force_comp()
        {
            InitializeComponent();
        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        

        

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {

        }

        private void force_textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtResult_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void startButton_Click_1(object sender, EventArgs e)
        {
            t.Start();
        }

        private void stopButton_Click_1(object sender, EventArgs e)
        {
            t.Stop();
        }

        private void resetButton_Click_1(object sender, EventArgs e)
        {
            t.Stop();
            s = 0; m = 0; h = 0;
            totalForceBox = 0;
            totalForce.Text = "N/A";
            totalForce.ForeColor = System.Drawing.Color.DimGray;
            txtResult.Text = "00:00.0";
        }

        private void minusIcon_Click(object sender, EventArgs e)
        {
            if (forceGoal3 != 0)
            {
                forceGoal3--;
                forceGoal1.Text = "" + forceGoal3 + ",000";
            }

            if(actualForce1 != 0)
            actualForce1 = actualForce1 - 1000;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (forceGoal2 != 0)
            {
                forceGoal2--;
                forceGoal.Text = "" + forceGoal2 + ",000";
            }

            if(actualforce != 0)
            actualforce = actualforce - 1000;
        }

        private void forceGoal_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            forceGoal2++;
            forceGoal.Text = "" + forceGoal2 + ",000";
            actualforce = actualforce + 1000;
        }

        private void plusIcon_Click(object sender, EventArgs e)
        {
            forceGoal3++;
            forceGoal1.Text = "" + forceGoal3 + ",000";
            actualForce1 = actualForce1 + 1000;
        }

        private void resetButton1_Click_1(object sender, EventArgs e)
        {
            t1.Stop();
            s1 = 0; m1 = 0; h1 = 0;
            totalForceBox1 = 0;
            totalForce1.Text = "N/A";
            totalForce1.ForeColor = System.Drawing.Color.DimGray;
            txtResult1.Text = "00:00.0";
        }

        private void stopButton1_Click_1(object sender, EventArgs e)
        {
            t1.Stop();
        }

        private void startButton1_Click_1(object sender, EventArgs e)
        {
            t1.Start();
        }

        private void targeted_total_of_force_comp_Load(object sender, EventArgs e)
        {
                t = new System.Timers.Timer();
                t.Interval = 1;
                t.Elapsed += OnTimeEvent;
                t1 = new System.Timers.Timer();
                t1.Interval = 5;
                t1.Elapsed += OnTimeEvent1;


        }

        private void targeted_total_of_force_comp_Load1(object sender, EventArgs e)
        {

        }

        private void OnTimeEvent(object sender, ElapsedEventArgs e)
        {
            SoundPlayer bellRing = new SoundPlayer(@"C:\Users\gabri\Desktop\12-HeavyHangingPunchingBag-Ver1\12-HeavyHangingPunchingBag-Ver1\SourceCode\ComboMeter V.1\ComboCounter\ComboCounter\soundEffect\old-fashioned-bell.wav");
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
                if (totalForceBox == actualforce)
                {
                    totalForce.ForeColor = System.Drawing.Color.Green;
                    bellRing.Play();
                    t.Stop();
                }
                else
                {
                    totalForceBox = totalForceBox + 50;
                    totalForce.Text = totalForceBox.ToString();
                }
            }));
        }

        private void OnTimeEvent1(object sender, ElapsedEventArgs e)
        {
            SoundPlayer bellRing = new SoundPlayer(@"C:\Users\gabri\Desktop\12-HeavyHangingPunchingBag-Ver1\12-HeavyHangingPunchingBag-Ver1\SourceCode\ComboMeter V.1\ComboCounter\ComboCounter\soundEffect\old-fashioned-bell.wav");
            Invoke(new Action(() =>
            {
                s1 += 1;
                if (s1 == 60)
                {
                    s1 = 0;
                    m1 += 1;
                }
                if (m1 == 60)
                {
                    m1 = 0;
                    h1 += 1;
                }
                txtResult1.Text = string.Format("{0}:{1}:{2}", h1.ToString().PadLeft(2, '0'), m1.ToString().PadLeft(2, '0'), s1.ToString().PadLeft(2, '0'));
                
                if (totalForceBox1 == actualForce1)
                {
                    totalForce1.ForeColor = System.Drawing.Color.Green;
                    bellRing.Play();
                    t1.Stop();
                }
                else
                {
                    totalForceBox1 = totalForceBox1 + 50;
                    totalForce1.Text = totalForceBox1.ToString();

                }
            }));
        }

       

       

       
    }
}

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
    public partial class targeted_total_of_force : UserControl
    {
        System.Timers.Timer t;
        int h, m, s, totalForceBox;
        int forceGoal1 = 15;
        int actualForce = 15000;
        public targeted_total_of_force()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            t.Start();
        }

        private void targeted_total_of_force_Load(object sender, EventArgs e)
        {
            t = new System.Timers.Timer();
            t.Interval = 1;
            t.Elapsed += OnTimeEvent;
        }

        private void totalForce_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void plusIcon_Click(object sender, EventArgs e)
        {
            forceGoal1++;
            forceGoal.Text = "" + forceGoal1 + ",000";
            actualForce = actualForce + 1000;
        }

        private void minusIcon_Click(object sender, EventArgs e)
        {
            if (forceGoal1 != 0)
            {
                forceGoal1--;
                forceGoal.Text = "" + forceGoal1 + ",000";
            }
           
            if (actualForce != 0)
            actualForce = actualForce - 1000;
            
        }

        private void timer1_Tick(object sender, EventArgs e)
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
                if (totalForceBox == actualForce)
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

        private void stopButton_Click(object sender, EventArgs e)
        {
            t.Stop();
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            t.Stop();
            s = 0; m = 0; h = 0;
            totalForceBox = 0;
            totalForce.Text = "0";
            txtResult.Text = "00:00.00";
            totalForce.ForeColor = System.Drawing.Color.DimGray;

        }
    }
}

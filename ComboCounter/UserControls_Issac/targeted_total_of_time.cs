using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComboCounter.UserControls
{
    public partial class home_user2 : UserControl
    {
        Int32 quick, quickMins, quickTotal;
        int totalForceBox, timeIntervalSec, timeIntervalMin;
        public home_user2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1 = new System.Windows.Forms.Timer();
            timer1.Interval = 1;
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Enabled = true;
            quickMins = Int32.Parse(setTimeMins.Text);
            quickMins = quickMins * 3600;
            quick = Int32.Parse(setTimeSec.Text);
            quick = quick * 60;
            quickTotal = quickMins + quick;
            totalForceBox = 0;

        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            timeIntervalMin = 0;
            timeIntervalSec = 0;
            setTimeSec.Text = "0";
            setTimeMins.Text = "0";
            currentTime.Text = "0";
            totalForceBox = 0;
            totalForce.Text = "0";
        }

        private void setTimeSec_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            quickTotal--;
            currentTime.Text = "00:" + quickTotal / 60 + "." + ((quickTotal % 60) >= 10 ? (quickTotal % 60).ToString() : "0" + (quickTotal % 60));
            if (currentTime.Text == "00:0.00")
            {
                timer1.Stop();
            }
            totalForceBox = totalForceBox + 50;
            totalForce.Text = totalForceBox.ToString();
        }

        private void minusIcon_Click(object sender, EventArgs e)
        {
            if (timeIntervalSec == 0)
            {
                timeIntervalMin = timeIntervalMin - 1;
                timeIntervalSec = 30;
            }
            else
            {
                timeIntervalSec = timeIntervalSec - 30;
            }
            setTimeMins.Text = Convert.ToString(timeIntervalMin);
            setTimeSec.Text = Convert.ToString(timeIntervalSec);
        }

        private void plusIcon_Click(object sender, EventArgs e)
        {
            if (timeIntervalSec == 0)
            {
                timeIntervalSec = 30;
            }
            else
            {
                timeIntervalMin = timeIntervalMin + 1;
                timeIntervalSec = 0;
            }
            setTimeMins.Text = Convert.ToString(timeIntervalMin);
            setTimeSec.Text = Convert.ToString(timeIntervalSec);
        }
    }
}

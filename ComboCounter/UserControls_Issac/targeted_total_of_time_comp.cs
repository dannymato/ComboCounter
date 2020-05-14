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
    public partial class targeted_total_of_time_comp : UserControl
    {
        int timeLimit = 100;
        int timeIntervalMin, timeIntervalSec, totalForceBox, totalForceBox1;
        
        Int32 quickMins, quick, quickTotal, quickMins1, quick1, quickTotal1;

        public targeted_total_of_time_comp()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void startButton_Click(object sender, EventArgs e)
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
            totalForceBox1 = 0;
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            timeIntervalMin = 0;
            timeIntervalSec = 0;
            setTimeSec.Text = "0";
            setTimeMins.Text = "0";
            currentTime.Text = "0";
            totalForceBox1 = 0;
            totalForce.Text = "0";
        }

        private void startButton1_Click(object sender, EventArgs e)
        {
            timer2 = new System.Windows.Forms.Timer();
            timer2.Interval = 1;
            timer2.Tick += new EventHandler(timer2_Tick);
            timer2.Enabled = true;
            quickMins1 = Int32.Parse(setTimeMins1.Text);
            quickMins1 = quickMins1 * 3600;
            quick1 = Int32.Parse(setTimeSec1.Text);
            quick1 = quick1 * 60;
            quickTotal1 = quickMins1 + quick1;
        }

        private void stopButton1_Click(object sender, EventArgs e)
        {
            timer2.Stop();
        }

        private void resetButton1_Click(object sender, EventArgs e)
        {
            timer2.Stop();
            timeIntervalMin = 0;
            timeIntervalSec = 0;
            setTimeSec.Text = "0".ToString();
            setTimeMins.Text = "0".ToString();
            currentTime.Text = "0".ToString();
            totalForceBox1 = 0;
            totalForce1.Text = "0";

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

        private void timer2_Tick(object sender, EventArgs e)
        {
            quickTotal1--;
            currentTime1.Text = "00:" + quickTotal1 / 60 + "." + ((quickTotal1 % 60) >= 10 ? (quickTotal1 % 60).ToString() : "0" + (quickTotal1 % 60));
            if (currentTime.Text == "00:0.00")
            {
                timer2.Stop();
            }
            totalForceBox1 = totalForceBox1 + 50;
            totalForce1.Text = totalForceBox1.ToString();

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void totalForce_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void minusIcon1_Click(object sender, EventArgs e)
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
            setTimeMins1.Text = Convert.ToString(timeIntervalMin);
            setTimeSec1.Text = Convert.ToString(timeIntervalSec);
        }

        private void plusIcon1_Click(object sender, EventArgs e)
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
            setTimeMins1.Text = Convert.ToString(timeIntervalMin);
            setTimeSec1.Text = Convert.ToString(timeIntervalSec);
        }
    }
}

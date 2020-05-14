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
    public partial class punch_count_comp : UserControl
    {
        Int32 quick;
        Int32 quickMins;
        Int32 quickTotal;
        Int32 quick1;
        Int32 quickMins1;
        Int32 quickTotal1;
        int setThreshold = 200;
        int setThreshold1 = 150;
        int timeIntervalMin, timeIntervalSec;
        int timeIntervalMin1, timeIntervalSec1;

        int i, j = 0;
        int[] arrayTest = new int[] { 150, 210, 250, 160, 225, 300, 210, 130, 250, 200, 50, 140 };
        int[] arrayTest1 = new int[] { 200, 130, 230, 140, 190, 200, 300, 230, 100, 230, 240, 100 };
        int punchCounterVal = 0;
        int punchCounterVal1 = 0;

        public punch_count_comp()
        {
            InitializeComponent();
        }

        private void propagate()
        {

            if (i != arrayTest.Length)
            {
                lastHit.Text = arrayTest[i].ToString();
            }
            else
            {
                timer1.Stop();
                i = 0;
                startButton.Enabled = true;
            }
            i++;
        }

        private void propagate1()
        {

            if (j != arrayTest1.Length)
            {
                lastHit1.Text = arrayTest[j].ToString();
            }
            else
            {
                timer3.Stop();
                j = 0;
                startButton.Enabled = true;
            }
            j++;
        }



        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void threshold1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox17_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void lastHit_TextChanged(object sender, EventArgs e) //Player 2
        {
            int lastHitVal1 = Int32.Parse(lastHit1.Text);
            int thresholdVal1 = Int32.Parse(threshold1.Text);
            thresholdVal1 = setThreshold1;
            if (lastHitVal1 < (thresholdVal1 - (thresholdVal1 * 0.1)))
            {
                lastHit1.ForeColor = System.Drawing.Color.Red;
            }
            if (lastHitVal1 >= (thresholdVal1 - (thresholdVal1 * 0.1)) && lastHitVal1 < (thresholdVal1 + (thresholdVal1 * 0.1)))
            {
                lastHit1.ForeColor = System.Drawing.Color.Yellow;
            }
            if (lastHitVal1 > (thresholdVal1 + (thresholdVal1 * 0.1)))
            {
                lastHit1.ForeColor = System.Drawing.Color.Green;
            }

            if (lastHit1.ForeColor == System.Drawing.Color.Yellow || lastHit1.ForeColor == System.Drawing.Color.Green)
            {
                punchCounterVal1++;
                punchCounter1.Text = punchCounterVal1.ToString();
            }
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timer1.Interval == 1000)
            {
                timer1.Interval = timer1.Interval * 2;
            }
            propagate();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            quickTotal--;
            currentTime.Text = "00:" + quickTotal / 60 + "." + ((quickTotal % 60) >= 10 ? (quickTotal % 60).ToString() : "0" + (quickTotal % 60));
            if (currentTime.Text == "00:0.00")
            {
                timer2.Stop();
                timer1.Stop();
            }
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == true)
            {
                timer1.Start();
                timer2.Start();
            }
            else
            {
                lastHit.Text = arrayTest[0].ToString();
                timer1 = new System.Windows.Forms.Timer();
                timer1.Interval = 1000;
                timer1.Tick += new EventHandler(timer1_Tick);
                timer1.Enabled = true;
                timer2 = new System.Windows.Forms.Timer();
                timer2.Interval = 1;
                quickMins = Int32.Parse(setTimeMins.Text);
                quickMins = quickMins * 3600;
                quick = Int32.Parse(setTimeSec.Text);
                quick = quick * 60;
                quickTotal = quickMins + quick;
                timer2.Tick += new EventHandler(timer2_Tick);
                timer2.Enabled = true;
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            timer2.Stop();
            timeIntervalMin = 0;
            timeIntervalSec = 0;
            setTimeSec.Text = "0".ToString();
            setTimeMins.Text = "0".ToString();
            currentTime.Text = "0".ToString();
            lastHit.Text = "0".ToString();
            punchCounterVal = 0;
            punchCounter.Text = "0".ToString(); ;
            i = 0;
        }

        private void startButton1_Click(object sender, EventArgs e)
        {
            if (timer3.Enabled == true)
            {
                timer3.Start();
                timer4.Start();
            }
            else
            {
                lastHit1.Text = arrayTest1[0].ToString();
                timer3 = new System.Windows.Forms.Timer();
                timer3.Interval = 900;
                timer3.Tick += new EventHandler(timer3_Tick);
                timer3.Enabled = true;
                timer4 = new System.Windows.Forms.Timer();
                timer4.Interval = 1;
                quickMins1 = Int32.Parse(setTimeMins1.Text);
                quickMins1 = quickMins * 3600;
                quick1 = Int32.Parse(setTimeSec1.Text);
                quick1 = quick1 * 60;
                quickTotal1 = quickMins1 + quick1;
                timer4.Tick += new EventHandler(timer4_Tick);
                timer4.Enabled = true;
            }
        }

        private void resetButton1_Click(object sender, EventArgs e)
        {
            timer3.Stop();
            timer4.Stop();
            timeIntervalMin1 = 0;
            timeIntervalSec1 = 0;
            setTimeSec1.Text = "0".ToString();
            setTimeMins1.Text = "0".ToString();
            currentTime1.Text = "0".ToString();
            lastHit1.Text = "0".ToString();
            punchCounterVal1 = 0;
            punchCounter1.Text = "0".ToString(); ;
            j = 0;
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

        private void lastHit_TextChanged_1(object sender, EventArgs e) //Player 1
        {
            int lastHitVal = Int32.Parse(lastHit.Text);
            int thresholdVal = Int32.Parse(threshold.Text);
            thresholdVal = setThreshold;
            if (lastHitVal < (thresholdVal - (thresholdVal * 0.1)))
            {
                lastHit.ForeColor = System.Drawing.Color.Red;
            }
            if (lastHitVal >= (thresholdVal - (thresholdVal * 0.1)) && lastHitVal < (thresholdVal + (thresholdVal * 0.1)))
            {
                lastHit.ForeColor = System.Drawing.Color.Yellow;
            }
            if (lastHitVal > (thresholdVal + (thresholdVal * 0.1)))
            {
                lastHit.ForeColor = System.Drawing.Color.Green;
            }

            if (lastHit.ForeColor == System.Drawing.Color.Yellow || lastHit.ForeColor == System.Drawing.Color.Green)
            {
                punchCounterVal++;
                punchCounter.Text = punchCounterVal.ToString();
            }
        }

        private void currentTime_TextChanged(object sender, EventArgs e)
        {

        }

        private void currentTime1_TextChanged(object sender, EventArgs e)
        {

        }

        private void punchCounter1_TextChanged(object sender, EventArgs e)
        {

        }

        private void plusIcon1_Click(object sender, EventArgs e)
        {
            if (timeIntervalSec1 == 0)
            {
                timeIntervalSec1 = 30;
            }
            else
            {
                timeIntervalMin1 = timeIntervalMin1 + 1;
                timeIntervalSec1 = 0;
            }
            setTimeMins1.Text = Convert.ToString(timeIntervalMin1);
            setTimeSec1.Text = Convert.ToString(timeIntervalSec1);
        }

        private void minusIcon1_Click(object sender, EventArgs e)
        {
            if (timeIntervalSec1 == 0)
            {
                timeIntervalMin1 = timeIntervalMin1 - 1;
                timeIntervalSec1 = 30;
            }
            else
            {
                timeIntervalSec1 = timeIntervalSec1 - 30;
            }
            setTimeMins1.Text = Convert.ToString(timeIntervalMin1);
            setTimeSec1.Text = Convert.ToString(timeIntervalSec1);
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            timer2.Stop();
        }

        private void stopButton1_Click_1(object sender, EventArgs e)
        {
            timer3.Stop();
            timer4.Stop();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (timer3.Interval == 1000)
            {
                timer3.Interval = timer3.Interval * 2;
            }
            propagate1();
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            quickTotal1--;
            currentTime1.Text = "00:" + quickTotal1 / 60 + "." + ((quickTotal1 % 60) >= 10 ? (quickTotal1 % 60).ToString() : "0" + (quickTotal1 % 60));
            if (currentTime.Text == "00:0.00")
            {
                timer4.Stop();
                timer3.Stop();
            }
        }

        private void punch_count_comp_Load(object sender, EventArgs e)
        {

        }
    }
}

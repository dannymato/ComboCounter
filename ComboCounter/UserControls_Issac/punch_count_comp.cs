using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComboCounter.Classes;

namespace ComboCounter.UserControls
{
    public partial class punch_count_comp : BaseFormControl
    {
        int setThreshold = 200;
        int setThreshold1 = 150;
        int timeIntervalSecP1 = 30;
        int timeIntervalSecP2 = 30;

        int i, j = 0;
        int[] arrayTest = new int[] { 150, 210, 250, 160, 225, 300, 210, 130, 250, 200, 50, 140 };
        int[] arrayTest1 = new int[] { 200, 130, 230, 140, 190, 200, 300, 230, 100, 230, 240, 100 };
        int punchCounterVal = 0;
        int punchCounterVal1 = 0;

        long totalMsecsP1;
        long totalMsecsP2;

        public punch_count_comp()
        {
            InitializeComponent();
        }

        private void propagate()
        {
            p1LastHit.Text = arrayTest[i].ToString();
            i = (i + 1) % arrayTest.Length;
        }

        private void propagate1()
        {

            p2LastHit.Text = arrayTest1[j].ToString();
            j = (j + 1) % arrayTest1.Length;
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

        private void p2LastHit_TextChanged(object sender, EventArgs e) //Player 2
        {

            int lastHitVal1 = Int32.Parse(p2LastHit.Text);
            int thresholdVal1 = setThreshold1;
            // Less than within 10% of the threshold
            if (lastHitVal1 < (thresholdVal1 - (thresholdVal1 * 0.1)))
            {
                p2LastHit.ForeColor = System.Drawing.Color.Red;
            }
            // Within 10% of the threshold
            else if (lastHitVal1 >= (thresholdVal1 - (thresholdVal1 * 0.1)) && lastHitVal1 < (thresholdVal1 + (thresholdVal1 * 0.1)))
            {
                p2LastHit.ForeColor = System.Drawing.Color.Yellow;
                punchCounterVal1++;
                p2ValidPunch.Text = punchCounterVal1.ToString();
            }
            // Greater than 10% of the threshold
            else
            {
                p2LastHit.ForeColor = System.Drawing.Color.Green;
                punchCounterVal1++;
                p2ValidPunch.Text = punchCounterVal1.ToString();
            }
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private string formatTimeFromMsecs(long msecs)
        {
            long minutes = msecs / 1000 / 60;
            long secs = msecs / 1000 % 60;
            long fracSecs = msecs % 1000 / 100;

            return string.Format("{0:00}:{1:00}.{2:0}", minutes, secs, fracSecs);
        }

        private string formatTimeSetter(int seconds)
        {
            return string.Format("{0:00}:{1:00}", seconds / 60, seconds % 60);
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
            totalMsecsP1 -= 100;
            p1CurrTime.Text = formatTimeFromMsecs(totalMsecsP1);


            if (totalMsecsP1 <= 0)
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
                p1LastHit.Text = arrayTest[0].ToString();
                timer1 = new System.Windows.Forms.Timer();
                timer1.Interval = 1000;
                timer1.Tick += new EventHandler(timer1_Tick);
                timer1.Enabled = true;

                timer2 = new System.Windows.Forms.Timer();
                timer2.Interval = 100;

                totalMsecsP1 = timeIntervalSecP1 * 1000;
                timer2.Tick += new EventHandler(timer2_Tick);
                timer2.Enabled = true;


            }
        }

        private void p1ResetButton_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            timer2.Stop();
            p1CurrTime.Text = formatTimeFromMsecs(0);
            p1LastHit.Text = "0";
            punchCounterVal = 0;
            p1ValidPunch.Text = "0";
            i = 0;
        }

        private void p2StartButton1_Click(object sender, EventArgs e)
        {
            if (timer3.Enabled == true)
            {
                timer3.Start();
                timer4.Start();
            }
            else
            {
                p2LastHit.Text = arrayTest1[0].ToString();

                timer3 = new System.Windows.Forms.Timer();
                timer3.Interval = 900;
                timer3.Tick += new EventHandler(timer3_Tick);
                timer3.Enabled = true;

                timer4 = new System.Windows.Forms.Timer();
                timer4.Interval = 100;

                totalMsecsP2 = timeIntervalSecP2 * 1000;
                timer4.Tick += new EventHandler(timer4_Tick);
                timer4.Enabled = true;
            }
        }

        private void p2ResetButton1_Click(object sender, EventArgs e)
        {
            timer3.Stop();
            timer4.Stop();

            p2CurrTime.Text = formatTimeFromMsecs(0); ;
            p2LastHit.Text = "0";
            punchCounterVal1 = 0;
            p2ValidPunch.Text = "0";
            j = 0;
        }

        private void p1PlusIcon_Click(object sender, EventArgs e)
        {
            timeIntervalSecP1 += 30;
            setTimeP1.Text = formatTimeSetter(timeIntervalSecP1);
        }

        private void p1MinusIcon_Click(object sender, EventArgs e)
        {
            if (timeIntervalSecP1 > 30)
            {
                timeIntervalSecP1 -= 30;
                setTimeP1.Text = formatTimeSetter(timeIntervalSecP1);
            }
        }

        private void lastHit_TextChanged_1(object sender, EventArgs e) //Player 1
        {
            int lastHitVal = Int32.Parse(p1LastHit.Text);
            int thresholdVal = setThreshold;

            // Below the threshold
            if (lastHitVal < (thresholdVal - (thresholdVal * 0.1)))
            {
                p1LastHit.ForeColor = System.Drawing.Color.Red;
            }
            // Within 10% of the threshold
            else if (lastHitVal >= (thresholdVal - (thresholdVal * 0.1)) && lastHitVal < (thresholdVal + (thresholdVal * 0.1)))
            {
                p1LastHit.ForeColor = System.Drawing.Color.Yellow;
                punchCounterVal++;
                p1ValidPunch.Text = punchCounterVal.ToString();
            }
            // More than 10% above the threshold
            else
            {
                p1LastHit.ForeColor = System.Drawing.Color.Green;
                punchCounterVal++;
                p1ValidPunch.Text = punchCounterVal.ToString();
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

        private void p2PlusIcon1_Click(object sender, EventArgs e)
        {
            timeIntervalSecP2 += 30;

            p2SetTime.Text = formatTimeSetter(timeIntervalSecP2);
        }

        private void minusIcon1_Click(object sender, EventArgs e)
        {
            if (timeIntervalSecP2 > 30)
            {
                timeIntervalSecP2 -= 30;
                p2SetTime.Text = formatTimeSetter(timeIntervalSecP2);
            }
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
            totalMsecsP2 -= 100;

            p2CurrTime.Text = formatTimeFromMsecs(totalMsecsP2);

            if (totalMsecsP2 <= 100)
            {
                timer4.Stop();
                timer3.Stop();
            }
        }

        private void punch_count_comp_Load(object sender, EventArgs e)
        {

        }

        private void PauseClocks()
        {
            timer1.Stop();
            timer2.Stop();
            timer3.Stop();
            timer4.Stop();
        }

        public override void OnPageAttached()
        {
            if (UserManager.UserSettings.TurnOffTimers)
            {
                PauseClocks();
            }
        }

        public override void OnPageRemoved()
        {
            
        }

        public override void OnExit()
        {

        }
    }
}

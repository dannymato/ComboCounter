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


namespace ComboCounter.UserControls
{
    public partial class punch_challenge_comp : UserControl
    {
        int punchLimit = 100;
        int i, j, k, l = 0;
        int currentForceVal, lastHitVal, currentForceVal1, lastHitVal1;
        int[] arrayTest = new int[] { 150, 210, 250, 160, 225, 300, 210, 130, 250, 200, 50, 140 };
        int[] arrayTest1 = new int[] { 200, 130, 230, 140, 190, 200, 300, 230, 100, 230, 240, 100 };

        public punch_challenge_comp()
        {
            InitializeComponent();

        }

        private void minusIcon_Click(object sender, EventArgs e)
        {
            punchLimit = punchLimit - 5;
            limit.Text = Convert.ToString(punchLimit);
        }

        private void totalForce1_TextChanged(object sender, EventArgs e)
        {

        }

        private void totalForce_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            propagate1();
        }

        private void limit_TextChanged(object sender, EventArgs e)
        {

        }

        private void punchNum_TextChanged(object sender, EventArgs e)
        {
            if(punchNum.Text == limit.Text)
            {
                punchNum.ForeColor = System.Drawing.Color.Green;
                timer1.Stop();
            }
        }

        private void force_textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void punchNum1_TextChanged(object sender, EventArgs e)
        {
            if(punchNum1.Text == limit.Text )
            {
                punchNum1.ForeColor = System.Drawing.Color.Green;
                timer2.Stop();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            punchNum.Text = "0".ToString();
            totalForce.Text = "0".ToString();
            i = 0;
            j = 0;
            currentForceVal = 0;
            lastHitVal = 0;
        }

        private void stopButton1_Click(object sender, EventArgs e)
        {
            timer2.Stop();
        }

        private void resetButton1_Click(object sender, EventArgs e)
        {
            punchNum1.Text = "0".ToString();
            totalForce1.Text = "0".ToString();
            k = 0;
            l= 0;
            currentForceVal1 = 0;
            lastHitVal1 = 0;
        }

        private void startButton1_Click(object sender, EventArgs e)
        {
            timer2 = new System.Windows.Forms.Timer();
            timer2.Interval = 1000;
            timer2.Tick += new EventHandler(timer2_Tick);
            timer2.Enabled = true;
        }

        private void plusIcon_Click(object sender, EventArgs e)
        {
            punchLimit = punchLimit + 5;
            limit.Text = Convert.ToString(punchLimit);

        }

        private void startButton_Click(object sender, EventArgs e)
        {
            timer1 = new System.Windows.Forms.Timer();
            timer1.Interval = 1000;
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            propagate();
        }

        private void propagate()
        {

            if (i != arrayTest.Length)
            {
                currentForceVal = arrayTest[i];
                currentForceVal = currentForceVal + lastHitVal;
                totalForce.Text = currentForceVal.ToString();
            }
            else
            {
                timer1.Stop();
                i = 0;
            }
            i++;
            lastHitVal = currentForceVal;
            if (lastHitVal != 0)
            {
                punchNum.Text = j.ToString();
                j++;
            }
        }

        private void propagate1()
        {

            if (k != arrayTest.Length)
            {
                currentForceVal1 = arrayTest1[k];
                currentForceVal1 = currentForceVal1 + lastHitVal1;
                totalForce1.Text = currentForceVal1.ToString();
            }
            else
            {
                timer2.Stop();
                k = 0;
            }
            k++;
            lastHitVal1 = currentForceVal1;

            if (lastHitVal != 0)
            {
                punchNum1.Text = l.ToString();
                l++;
            }
        }
    }
}

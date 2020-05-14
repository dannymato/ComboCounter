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
    public partial class punch_challenge : UserControl
    {
        int punchLimit = 100;
        int i,j = 0;
        int currentForceVal, lastHitVal;
        int[] arrayTest = new int[] { 150, 210, 250, 160, 225, 300, 210, 130, 250, 200, 50, 140 };

        public punch_challenge()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void consecutive_punch_challenge_Load(object sender, EventArgs e)
        {
            
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

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

        private void timer1_Tick(object sender, EventArgs e)
        {
            propagate();
        }

        private void punchNum_TextChanged(object sender, EventArgs e)
        {
            if (punchNum.Text == limit.Text)
            {
                punchNum.ForeColor = System.Drawing.Color.Green;
                timer1.Stop();
            }

        }


        private void minusIcon_Click_1(object sender, EventArgs e)
        {
            punchLimit = punchLimit - 5;
            limit.Text = Convert.ToString(punchLimit);
        }

        private void plusIcon_Click_1(object sender, EventArgs e)
        {
            punchLimit = punchLimit + 5;
            limit.Text = Convert.ToString(punchLimit);
        }

        private void stopButton_Click(object sender, EventArgs e)
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void totalForce_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1 = new System.Windows.Forms.Timer();
            timer1.Interval = 1000;
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Enabled = true;
        }
    }
}

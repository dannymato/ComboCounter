using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;
namespace ComboCounter.UserControls
{
    public partial class punch_count : UserControl
    {
        
        
        Int32 quick;
        Int32 quickMins;
        Int32 quickTotal;
        int setThreshold = 200;
        int timeIntervalMin = 0;
        int timeIntervalSec = 30;
        


        int i = 0;
        int[] arrayTest = new int[] { 150, 210, 250, 160, 225, 300, 210, 130, 250, 200, 50, 140 };
        int punchCounterVal = 0;
        int missPunch = 0;
        public punch_count()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

    

        private void button2_Click(object sender, EventArgs e)
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
                quick = Int32.Parse(setTime.Text);
                quick = quick * 60;
                quickTotal = quickMins + quick;
                timer2.Tick += new EventHandler(timer2_Tick);
                timer2.Enabled = true;
            }


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
                button2.Enabled = true;
            }
            i++;
        }

        private void button1_Click(object sender, EventArgs e)
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

        private void punchCounter_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            timer1.Stop();
            timer2.Stop();
        }

        private void currentTime_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            quickTotal--;
            currentTime.Text = "00:" + quickTotal / 60 + "." + ((quickTotal % 60) >= 10 ? (quickTotal % 60).ToString() : "0" + (quickTotal % 60));
            if (currentTime.Text == "0:00")
            {
                timer2.Stop();
                timer1.Stop();
            }

        }

        private void setTimeMins_TextChanged(object sender, EventArgs e)
        {

        }


        private void minusIcon_Click(object sender, EventArgs e)
        {
            if (timeIntervalSec == 0)
            {
                timeIntervalMin = timeIntervalMin - 1;
                timeIntervalSec = 50;
                setTime.Text = Convert.ToString(timeIntervalSec);
            }
            else
            {
                timeIntervalSec = timeIntervalSec - 10;
                if (timeIntervalSec == 0)
                {
                    setTime.Text = "0" + timeIntervalSec;
                }
                else { setTime.Text = "" + timeIntervalSec; }

               
            }

            if (timeIntervalMin < 9)
            {
                setTimeMins.Text = "0"+ Convert.ToString(timeIntervalMin);
            }
            else
            { 
                setTimeMins.Text = Convert.ToString(timeIntervalMin);
               //setTime.Text = Convert.ToString(timeIntervalSec);
             }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            timer1.Stop();
            timer2.Stop();
            timeIntervalMin = 0;
            setTime.Text = "30";
            timeIntervalSec = 30;
            setTimeMins.Text = "00";
            currentTime.Text = "00:00.00";
           
            lastHit.Text = "N/A";
            lastHit.ForeColor = System.Drawing.Color.DimGray;
            punchCounterVal = 0;
            punchCounter.Text = "0"; ;
            i = 0;
            missPunch = 0;
            textBox7.Text = missPunch.ToString();
            
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void lastHit_TextChanged_1(object sender, EventArgs e)
        {
            SoundPlayer rightHook = new SoundPlayer(@"C:\Users\gabri\Desktop\12-HeavyHangingPunchingBag-Ver1\12-HeavyHangingPunchingBag-Ver1\SourceCode\ComboMeter V.1\ComboCounter\ComboCounter\soundEffect\RightHook.wav");
           

            SoundPlayer upperCut = new SoundPlayer(@"C:\Users\gabri\Desktop\12-HeavyHangingPunchingBag-Ver1\12-HeavyHangingPunchingBag-Ver1\SourceCode\ComboMeter V.1\ComboCounter\ComboCounter\soundEffect\UpperCut.wav");

            SoundPlayer bellRing = new SoundPlayer(@"C:\Users\gabri\Desktop\12-HeavyHangingPunchingBag-Ver1\12-HeavyHangingPunchingBag-Ver1\SourceCode\ComboMeter V.1\ComboCounter\ComboCounter\soundEffect\old-fashioned-bell.wav");

            if (lastHit.Text == "N/A")
            {
                //dont do anything 
            }
            else
            {
                int lastHitVal = Int32.Parse(lastHit.Text); //breaks here


                int thresholdVal = Int32.Parse(threshold.Text);
                thresholdVal = setThreshold;
                if (lastHitVal < (thresholdVal - (thresholdVal * 0.1)))
                {
                    lastHit.ForeColor = System.Drawing.Color.Red;
                   // bellRing.Play();
                }
                if (lastHitVal >= (thresholdVal - (thresholdVal * 0.1)) && lastHitVal < (thresholdVal + (thresholdVal * 0.1)))
                {
                    lastHit.ForeColor = System.Drawing.Color.Yellow;
                    bellRing.Play();
                }
                if (lastHitVal > (thresholdVal + (thresholdVal * 0.1)))
                {
                    lastHit.ForeColor = System.Drawing.Color.Green;
                    bellRing.Play();
                }

                if (lastHit.ForeColor == System.Drawing.Color.Yellow || lastHit.ForeColor == System.Drawing.Color.Green)
                {
                    punchCounterVal++;
                    punchCounter.Text = punchCounterVal.ToString();
                }
                else
                {
                    missPunch++;
                    textBox7.Text = missPunch.ToString();


                }
            }
        }

       

        private void plusIcon_Click(object sender, EventArgs e)
        {
            if (timeIntervalSec < 50)
            {
                timeIntervalSec = timeIntervalSec + 10;
                setTime.Text = Convert.ToString(timeIntervalSec);
            }
            else
            {
                timeIntervalMin = timeIntervalMin + 1;
                timeIntervalSec = 0;
                setTime.Text = "00";
                if (timeIntervalMin > 9)
                {
                    setTimeMins.Text = Convert.ToString(timeIntervalMin);
                }
                else
                {
                    setTimeMins.Text = "0" + Convert.ToString(timeIntervalMin);
                }
            }
           // setTimeMins.Text = Convert.ToString(timeIntervalMin);
            //setTime.Text = Convert.ToString(timeIntervalSec);
        }

        public string force
        {
            set { threshold.Text = value; setThreshold = Int32.Parse(value) ; }
           
        }
        public string minutes
        {
            set { timeIntervalMin = Int32.Parse(value); setTimeMins.Text = value; }

        }
        public string seconds
        {
            set { timeIntervalSec = Int32.Parse(value); setTime.Text = value; }

        }

        private void punch_count_Load(object sender, EventArgs e)
        {
           
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}

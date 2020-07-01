using System;
using ComboCounter.Classes;
using System.Diagnostics;

namespace ComboCounter.UserControls
{
    public partial class punch_challenge : BaseFormControl
    {
        int punchLimit = 100;
        int i,j = 0;
        int currentForceVal, lastHitVal;
        int[] arrayTest = new int[] { 150, 210, 250, 160, 225, 300, 210, 130, 250, 200, 50, 140 };

        int numPunches = 0;

        Session session;

        Stopwatch stopwatch;

        public punch_challenge()
        {
            stopwatch = new Stopwatch();
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

        // Occurs on every tick of the clock
        private void propagate()
        {
  
            currentForceVal = arrayTest[i];
            currentForceVal += lastHitVal;
            totalForce.Text = currentForceVal.ToString();
            session.insertHit(arrayTest[i], stopwatch.Elapsed.TotalSeconds);

            i = (i + 1) % arrayTest.Length;

            numPunches++;
            punchNum.Text = numPunches.ToString();
            if (numPunches >= punchLimit)
            {
                punchNum.ForeColor = System.Drawing.Color.Green;
                
                History.InsertSession(session);
                ResetClocks();
            }
            
            
            lastHitVal = currentForceVal;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            propagate();
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

            ResetClocks();
            
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            punchNum.Text = "0";
            totalForce.Text = "0";
            i = 0;
            j = 0;
            currentForceVal = 0;
            lastHitVal = 0;
            numPunches = 0;

            ResetClocks();
        }

        private void ResetClocks()
        {
            timer1.Stop();
            timer1.Enabled = false;
            stopwatch.Stop();
            stopwatch.Reset();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


        // Start Button
        private void button2_Click(object sender, EventArgs e)
        {
            if (!timer1.Enabled)
            {
                timer1 = new System.Windows.Forms.Timer();
                timer1.Interval = 1000;
                timer1.Tick += new EventHandler(timer1_Tick);
                timer1.Enabled = true;
                session = new Session(DateTime.Now);
                stopwatch.Start();
            }
        }

        public override void OnPageAttached()
        {
            
        }

        public override void OnPageRemoved()
        {
            
        }

        public override void OnExit()
        {

        }
    }
}

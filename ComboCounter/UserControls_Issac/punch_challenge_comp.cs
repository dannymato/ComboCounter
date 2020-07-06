using System;
using System.Drawing;
using ComboCounter.Classes;

namespace ComboCounter.UserControls
{
    public partial class punch_challenge_comp : BaseFormControl
    {
        int punchLimit = 100;
        int i, punchCountPlayer1, j, punchCountPlayer2 = 0;
        int totalForceNumPlayer1, lastHitVal, totalForceNumPlayer2, lastHitValPlayer2;
        int[] arrayTest = new int[] { 150, 210, 250, 160, 225, 300, 210, 130, 250, 200, 50, 140 };
        int[] arrayTest1 = new int[] { 200, 130, 230, 140, 190, 200, 300, 230, 100, 230, 240, 100 };

        public punch_challenge_comp()
        {
            InitializeComponent();
            limit.Text = punchLimit.ToString();
            header.Left = (Width - header.Width) / 2;
            GoalPanel.Top = header.Top + header.Height;
            GoalPanel.Left = (Width - GoalPanel.Width) / 2;

            timer1 = new System.Windows.Forms.Timer();
            timer1.Interval = 1000;
            timer1.Tick += new EventHandler(timer1_Tick);

            timer2 = new System.Windows.Forms.Timer();
            timer2.Interval = 1000;
            timer2.Tick += new EventHandler(timer2_Tick);
        }

        private void minusIcon_Click(object sender, EventArgs e)
        {
            punchLimit = punchLimit - 5;
            if (punchLimit < 5)
            {
                punchLimit = 200;
            }
            limit.Text = Convert.ToString(punchLimit);
        }

        // Player 2 Tick
        private void timer2_Tick(object sender, EventArgs e)
        {
            propagate1();
        }

        // Player 1 Stop Button
        private void button1_Click_1(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        // Player 1 Reset Button
        private void resetButton_Click(object sender, EventArgs e)
        {
            punchNumPlay1.Text = "0".ToString();
            totalForcePlayer1.Text = "0".ToString();
            punchNumPlay1.ForeColor = ThemeManager.initTextColor();
            i = 0;
            punchCountPlayer1 = 0;
            totalForceNumPlayer1 = 0;
            lastHitVal = 0;
        }

        // Player 2 Stop Button
        private void stopButton1_Click(object sender, EventArgs e)
        {
            timer2.Start();
        }

        // Player 2 Reset Button
        private void resetButton1_Click(object sender, EventArgs e)
        {
            totalPunchPlay2.Text = "0".ToString();
            totalForcePlayer2.Text = "0".ToString();
            totalPunchPlay2.ForeColor = ThemeManager.initTextColor();
            j = 0;
            punchCountPlayer2 = 0;
            totalForceNumPlayer2 = 0;
            lastHitValPlayer2 = 0;
        }

        // Player 2 Start Button
        private void startButton1_Click(object sender, EventArgs e)
        {
            timer2.Start();
        }

        private void plusIcon_Click(object sender, EventArgs e)
        {
            punchLimit = punchLimit + 5;
            if (punchLimit > 200)
            {
                punchLimit = 5;
            }
            limit.Text = Convert.ToString(punchLimit);

        }

        // Player 1 Start Button
        private void startButton_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;

        }

        // Player 1 Tick
        private void timer1_Tick(object sender, EventArgs e)
        {
            propagate();
        }

        // Player 1 Tick
        private void propagate()
        {
            lastHitVal = arrayTest[i];
            totalForceNumPlayer1 += lastHitVal;
            totalForcePlayer1.Text = totalForceNumPlayer1.ToString();

            i = (i + 1) % arrayTest.Length;
            
            if (lastHitVal > 0)
            {
                punchCountPlayer1++;
                punchNumPlay1.Text = punchCountPlayer1.ToString();
            }

            if (punchCountPlayer1 >= punchLimit)
            {
                punchNumPlay1.ForeColor = Color.Green;
                timer1.Stop();
            }

        }

        // Player 2 Tick
        private void propagate1()
        {

            lastHitValPlayer2 = arrayTest1[j];
            totalForceNumPlayer2 += lastHitValPlayer2;
            totalForcePlayer2.Text = totalForceNumPlayer2.ToString();

            j = (j + 1) % arrayTest1.Length;

            if (lastHitValPlayer2 > 0)
            {
                punchCountPlayer2++;
                totalPunchPlay2.Text = punchCountPlayer2.ToString();
            }

            if (punchCountPlayer2 >= punchLimit)
            {
                totalPunchPlay2.ForeColor = Color.Green;
                timer2.Stop();
            }
        }

        private void PauseClocks()
        {
            timer1.Stop();
            timer2.Stop();
        }

        public override void OnPageAttached()
        {
            
        }

        public override void OnPageRemoved()
        {
            if (UserManager.UserSettings.TurnOffTimers)
            {
                PauseClocks();
            }
        }

        public override void OnExit()
        {

        }
    }
}

using System;
using System.Windows.Forms;
using System.Media;
using ComboCounter.Classes;
using ComboCounter.CustomControls;

namespace ComboCounter.UserControls
{
    public partial class punch_count : BaseFormControl
    {
        const int DEFAULT_INTERVAL = 30;
        
        Int32 quickTotal;
        int setThreshold = 200;
        int timeIntervalSec = DEFAULT_INTERVAL;

        // The amount of seconds each press of either the plus or minus button changes the time
        const int TIME_UNIT = 15;

        private readonly SoundPlayer bellRung;
        private readonly SoundPlayer missedHit;

        private VisualFeedbackControl feedbackControl;

        private Session session;


        private bool useFeedback;

        int i = 0;
        int[] arrayTest = new int[] { 150, 210, 250, 160, 225, 300, 210, 130, 250, 200, 50, 140 };
        int punchCounterVal = 0;
        int missPunch = 0;
        public punch_count()
        {
            bellRung = new SoundPlayer(@"soundEffect\old-fashioned-bell.wav");
            missedHit = new SoundPlayer(@"soundEffect\MissedHit.wav");
            InitializeComponent();

            feedbackControl = new VisualFeedbackControl();
            
            feedbackControl.Left = 100;
            feedbackControl.Top = 10;
            feedbackControl.Height = 50;
            Controls.Add(feedbackControl);
            Header.Left = tableLayoutPanel1.Left + ((tableLayoutPanel1.Width - Header.Width) / 2);
        }
    
        // Start Button
        private void button2_Click(object sender, EventArgs e)
        {
            if (!timer1.Enabled || !timer2.Enabled)
            {
                lastHit.Text = arrayTest[0].ToString();

                timer1 = new Timer();
                timer1.Interval = 1000;
                timer1.Tick += new EventHandler(timer1_Tick);
                timer1.Enabled = true;

                timer2 = new Timer();
                timer2.Interval = 100;
                timer2.Tick += new EventHandler(timer2_Tick);

                quickTotal = timeIntervalSec * 1000;
                timer2.Enabled = true;

                session = new Session(DateTime.Now);

            }
            
        }

        private void propagate()
        {
            lastHit.Text = arrayTest[i].ToString();

            if (useFeedback)
                feedbackControl.PushPunch(arrayTest[i]);

            session.insertHit(arrayTest[i], timeIntervalSec - (quickTotal / 1000.0));
            
            i = (i + 1) % arrayTest.Length;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timer1.Interval == 1000)
            {
                timer1.Interval = timer1.Interval * 2;
            }
            propagate();

        }

        // Stop Button
        private void button3_Click(object sender, EventArgs e)
        {
            
            timer1.Stop();
            timer2.Stop();

        }

        private void timer2_Tick(object sender, EventArgs e)
        {

            quickTotal -= 100;
            currentTime.Text = Tools.FormatCurrentTime(quickTotal);
            
            if (quickTotal == 0)
            {
                timer2.Stop();
                timer1.Stop();

                bellRung.Play();
                History.InsertSession(session);
            }

        }

        private void minusIcon_Click(object sender, EventArgs e)
        {
            timeIntervalSec -= TIME_UNIT;
            if (timeIntervalSec < 0)
            {
                timeIntervalSec = 0;
            }

            setTime.Text = Tools.FormatTimeSetter(timeIntervalSec);
        }

        // Reset Button
        private void button1_Click_1(object sender, EventArgs e)
        {
            timer1.Stop();
            timer2.Stop();
            timeIntervalSec = DEFAULT_INTERVAL;
            setTime.Text = Tools.FormatTimeSetter(timeIntervalSec);
            currentTime.Text = "00:00.00";
           
            lastHit.Text = "N/A";
            lastHit.ForeColor = System.Drawing.Color.DimGray;
            punchCounterVal = 0;
            punchCounter.Text = "0";
            i = 0;
            missPunch = 0;
            numInvalidPunch.Text = missPunch.ToString();
            
        }

        private void lastHit_TextChanged_1(object sender, EventArgs e)
        {
            SoundPlayer rightHook = new SoundPlayer(@"soundEffect\RightHook.wav");
           
            SoundPlayer upperCut = new SoundPlayer(@"soundEffect\UpperCut.wav");

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
                    missPunch++;
                    numInvalidPunch.Text = missPunch.ToString();
                    missedHit.Play();
                }
                else if (lastHitVal >= (thresholdVal - (thresholdVal * 0.1)) && lastHitVal < (thresholdVal + (thresholdVal * 0.1)))
                {
                    lastHit.ForeColor = System.Drawing.Color.Yellow;
                    rightHook.Play();
                }
                else if (lastHitVal > (thresholdVal + (thresholdVal * 0.1)))
                {
                    lastHit.ForeColor = System.Drawing.Color.Green;
                    rightHook.Play();
                }

                if (lastHit.ForeColor == System.Drawing.Color.Yellow || lastHit.ForeColor == System.Drawing.Color.Green)
                {
                    punchCounterVal++;
                    punchCounter.Text = punchCounterVal.ToString();
                }
                else
                {
                    missPunch++;
                    numInvalidPunch.Text = missPunch.ToString();


                }
            }
        }       

        private void plusIcon_Click(object sender, EventArgs e)
        {
            timeIntervalSec += TIME_UNIT;
            setTime.Text = Tools.FormatTimeSetter(timeIntervalSec);
        }

        private void punch_count_Load(object sender, EventArgs e)
        {
           
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void setTimeMins_Click(object sender, EventArgs e)
        {

        }

        private void PauseClocks()
        {
            timer1.Stop();
            timer2.Stop();
        }

        public override void OnPageAttached()
        {
            base.OnPageAttached();
            useFeedback = !UserManager.VisualFeedbackOff();
        }

        public override void OnPageRemoved()
        {
            if (UserManager.TimerSetting())
            {
                PauseClocks();
            }
        }

        public override void OnExit()
        {
            base.OnExit();
            feedbackControl.Cleanup();
        }
    }
}

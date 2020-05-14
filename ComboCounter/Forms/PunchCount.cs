using System;
using System.Windows.Forms;


namespace ComboCounter.Forms
{
    public partial class PunchCount : Form
    {
        int min;
        int sec = 30;
        int forcee = 200;
        public PunchCount()
        {
            InitializeComponent();
            
        }

        public PunchCount(Int32 minutes, Int32 seconds, Int32 force)
        {
            InitializeComponent();
            min = minutes;
            sec = seconds;
            forcee = force;
           
        }
        
        private void punch_count1_Load(object sender, EventArgs e)
        {
            punch_count1.force = "" + forcee;

            if (min > 9)
            {
                punch_count1.minutes = "" + min;
            }
            else
            {
                punch_count1.minutes = "0" + min;
            }

            if (sec == 0)
            {
                punch_count1.seconds = "0" + sec;
            }
            else 
            {
                punch_count1.seconds = "" + sec;
            }

            //punch_count1.minutes = "" + min;
            //punch_count1.seconds = "" + sec;



        }

        public string force
        {
            get { return (min + ""); }
        }



    }
}


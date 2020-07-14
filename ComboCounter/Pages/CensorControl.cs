using System;
using System.Drawing;
using System.Windows.Forms;
using ComboCounter.Classes;

namespace ComboCounter.UserControls_Gabriel
{
    public partial class CensorControl : BaseFormControl
    {

        int handicapVal1 = 75;
        int handicapVal2 = 100;

        public CensorControl()
        {
            InitializeComponent();
        }

        private void CensorControl_Load(object sender, EventArgs e)
        {
            SensorHeader.Location = new Point((Width / 2) - (SensorHeader.Width / 2), 0);
            SensorPanel.Location = new Point((Width / 2) - (SensorPanel.Width / 2), (Height / 2) - (SensorPanel.Height / 2));

            this.Handicap1.ForeColor = ThemeManager.initH2Color();
            this.Handicap1.ForeColor = ThemeManager.initH2Color();
            this.SensorHeader.ForeColor = ThemeManager.initH2Color();

        }

      
        private void Plus_Icon1_Click(object sender, EventArgs e)
        {
            if(handicapVal1 == 100)
            {
                // play sound

            }
            else
            {
                handicapVal1 += 5;
                this.Handicap1.Text = " " + handicapVal1 + "%";
            }
          
        }


        private void Minus_Icon1_Click(object sender, EventArgs e)
        {
            if (handicapVal1 == 0)
            {
                // play sound

            }
            else
            {
                handicapVal1 -= 5;
                this.Handicap1.Text = " " + handicapVal1 + "%";
            }


        }


        private void Plus_Icon2_Click(object sender, EventArgs e)
        {
            if (handicapVal2 == 100)
            {
                // play sound

            }
            else
            {
                handicapVal2 += 5;
                this.Handicap2.Text = " " + handicapVal2 + "%";
            }


        }


        private void Minus_Icon2_Click(object sender, EventArgs e)
        {
            if (handicapVal2 == 0)
            {
                // play sound

            }
            else
            {
                handicapVal2 -= 5;
                this.Handicap2.Text = " " + handicapVal2 + "%";
            }


        }



        private void smallInfo1_Click(object sender, EventArgs e)
        {

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

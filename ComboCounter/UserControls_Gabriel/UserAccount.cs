using System;
using System.Drawing;
using System.Windows.Forms;
using ComboCounter.Classes;
using MySql.Data.MySqlClient;

namespace ComboCounter.UserControls_Gabriel
{
    public partial class UserAccount : BaseFormControl
    {

        public UserAccount()
        {
            InitializeComponent();
        }

        private string username;
        private string password;
        private string fname;
        private string lname;

        public void getInfo()
        {
                username = UserManager.GetUsername();
                password = UserManager.GetPassword();
                fname = UserManager.GetFname();
                lname = UserManager.GetLname();
                textBox17.Text = username;
                textBox18.Text = password;

        }


        private void button1_Click(object sender, EventArgs e)
        {

            username_tb.Visible = true;
            textBox2.Visible = true;
            textBox1.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = true;
            textBox5.Visible = true;
            textBox8.Visible = true;
            textBox9.Visible = true;
            textBox7.Visible = true;
            submit_b.Visible = true;
            panel1.Visible = false;
            panel2.Location = new Point((Width / 2) - (panel3.Width / 2) + 200, (Height / 2) - (panel3.Height / 2) + 150);
            // panel2.Location = panel1.Location;
            // panel1.SendToBack();
            // panel2.BringToFront();
            panel2.Show();

        }

        private void submit_b_Click(object sender, EventArgs e)
        {
            username_tb.Visible = false;
            textBox2.Visible = false;
            textBox1.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            textBox5.Visible = false;
            textBox8.Visible = false;
            textBox9.Visible = false;
            textBox7.Visible = false;
            submit_b.Visible = false;
        }

        private void UserAccount_Load(object sender, EventArgs e)
        {


            FontManager fm = FontManager.getInstance();

            header11.Font = fm.getHeader2Font();
            header11.ForeColor = ThemeConstants.HeaderTextColor1;
            UsernameAccount.ForeColor = ThemeConstants.HeaderTextColor1;
            PasswordAccount.ForeColor = ThemeConstants.HeaderTextColor1;
            NameAccount.ForeColor = ThemeConstants.HeaderTextColor1;
            EmailAccount.ForeColor = ThemeConstants.HeaderTextColor1;
            SexAccount.ForeColor = ThemeConstants.HeaderTextColor1;
            ClassAccount.ForeColor = ThemeConstants.HeaderTextColor1;


            panel3.Location = new Point((Width / 2) - (panel3.Width / 2), (Height / 2) - (panel3.Height / 2));
            panel1.Location = new Point((panel3.Width / 2) - (panel1.Width / 2), (panel1.Height / 2) - (panel1.Height / 2) + 110);
            header11.Location = new Point((panel3.Width / 2) - (header11.Width / 2), 0);
            /**
            panel1.Visible = false;
            panel2.Visible = true;
            panel2.Location = new Point((panel3.Width / 2) - (panel2.Width / 2), (panel2.Height / 2) - (panel2.Height / 2) + 110);
            **/    
    


        }

        private void panel1_Enter(object sender, EventArgs e)
        {

            //groupBox1.Visibility = System.Visibility.Hidden;

        }

        private void header11_Click(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void smallInfo1_Click(object sender, EventArgs e)
        {

        }

        private void smallInfo1_Click_1(object sender, EventArgs e)
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

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        /**
        private void button1(object sender, EventArgs e)
        {

        }
        **/
    }
}

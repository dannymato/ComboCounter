using System;
using System.Windows.Forms;
using ComboCounter.Classes;
using MySql.Data.MySqlClient;

namespace ComboCounter.UserControls_Gabriel
{
    public partial class UserAccount : UserControl
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
                // age_tb.Text = (reader["age"]).ToString();
                //  id.Text = (reader["id"]).ToString();
                //  height_tb.Text = (reader["height"]).ToString();
                //  weight_tb.Text = (reader["weight"]).ToString();
                // cl.Text = (reader["class"]).ToString();
                //   sex_tb.Text = (reader["age"]).ToString();
                textBox17.Text = username;
                textBox18.Text = password;
                textBox11.Text = fname;

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

            //       textBox18.Text = "load";
                   getInfo();
            //   
        }
    }
}

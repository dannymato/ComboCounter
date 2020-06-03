using System;
using System.Data.Common;
using System.Drawing.Text;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ComboCounter.Forms
{
    public partial class Register1 : Form
    {

        public Register1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void Register1_Load(object sender, EventArgs e)
        {

            
        }

        private void signupButton_Click(object sender, EventArgs e)
        {
            Classes.DBConnection db = Classes.DBConnection.getInstance();

            Random r = new Random();

            int id = r.Next();

            Guid guid = Guid.NewGuid();



            User newUser = db.insertUser(
                id,
                username_tb.Text,
                passwordBox.Text,
                fNameBox.Text,
                lNameBox.Text,
                sexBox.Text,
                classBox.Text,
                heightBox.Text,
                weightBox.Text,
                GetAgeFromDOB()
                );

            if (newUser != null)
            {
                // UserManagement Code
                Main main = new Main();
                Hide();
                main.Show();
                main.FormClosed += (o, closeEvent) => { Close(); };
            }
        }

        private int GetAgeFromDOB()
        {
            int age = 0;

            DateTime today = DateTime.Today;

            if (today.Month > Int32.Parse(monthBox.Text))
            {
                age = today.Year - Int32.Parse(yearBox.Text);
            }
            else
            {
                age = today.Year - Int32.Parse(yearBox.Text) - 1;
            }

            return age;
        }

        private void username_tb_TextChanged(object sender, EventArgs e)
        {

        }

        private void monthBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void dayBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void submit_b_Click(object sender, EventArgs e)
        {
            Classes.DBConnection db = Classes.DBConnection.getInstance();

            Random r = new Random();

            int id = r.Next();

            Guid guid = Guid.NewGuid();



            User newUser = db.insertUser(
                id,
                username_tb.Text,
                passwordBox.Text,
                fNameBox.Text,
                lNameBox.Text,
                sexBox.Text,
                classBox.Text,
                heightBox.Text,
                weightBox.Text,
                GetAgeFromDOB()
                );

            if (newUser != null)
            {
                // UserManagement Code
                Main main = new Main();
                Hide();
                main.Show();
                main.FormClosed += (s, args) => { Close(); };
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}

using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using ComboCounter.Forms;
using ComboCounter.Classes;

namespace ComboCounter
{
    public partial class Login : Form
    {
        public String user;
        Main c = new Main();
        Register1 reg = new Register1();


        public Login()
        {
            InitializeComponent();
        }


        // Reacts to button presses for the login button
        private void button1_Click(object sender, EventArgs e)
        {

            if (GetLogin())
            {
                this.Hide();
                c.Closed += (s, args) => this.Close();
                c.Show();
            }
            else
            {
                MessageBox.Show("Wrong password or username, please try again or register");
            }

        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            { button1_Click(this, new EventArgs()); }
        }

        private void register_button_Click(object sender, EventArgs e)
        {
            Hide();
            reg.ShowDialog();
        }               


        // Makes a call to the database to verify the username and password typed by the user
        // If the credientials are valid the UserManagement class is populated with the user info
        private bool GetLogin()
        {
            DBConnection db = DBConnection.getInstance();

            User newUser = db.getLogin(username_tb.Text, password_tb.Text);

            if (newUser != null)
            {
                //UserManagement code goes here

                return true;
            }
            return false;
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}

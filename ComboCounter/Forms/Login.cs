using System;
using System.Windows.Forms;
using ComboCounter.Forms;
using ComboCounter.Classes;

namespace ComboCounter
{
    public partial class Login : Form
    { 
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
                Hide();
                c.Closed += (s, args) => Close();
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
            reg.FormClosed += closeOnRegisterClose;
            reg.ReturnToLogin += (send, args) =>
            {
                reg.FormClosed -= closeOnRegisterClose;
                Show();
                reg.Close();
            };
            reg.ShowDialog();
            

        }
        
        private void closeOnRegisterClose(object sender, EventArgs e)
        {
            Close();
        }


        // Makes a call to the database to verify the username and password typed by the user
        // If the credientials are valid the UserManagement class is populated with the user info
        private bool GetLogin()
        {
            DBConnection db = DBConnection.getInstance();

            User newUser = db.getLogin(username_tb.Text, password_tb.Text);

            
            if (newUser != null)
            {
                UserManager.setUser(newUser);
                #if NEW_DB
                UserManager.UserSettings = db.ReadUserSettings(newUser.Id);
                #endif      
                return true;
            }
            return false;
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}

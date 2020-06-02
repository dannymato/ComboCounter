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

       /* private const String SERVER = "127.0.0.1";
        private const String DATABASE = "project";
        private const String UID = "root";
        private const String PASSWORD = "692Trrbw83";
        private static MySqlConnection dbConn;
        private string username;
        private string password;
        public string fname;
        public string lname;*/


        public Login()
        {
            InitializeComponent();
            //InitializeDB();
        }
        /*
        public static void InitializeDB()
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = SERVER;
            builder.UserID = UID;
            builder.Password = PASSWORD;
            builder.Database = DATABASE;
            builder.SslMode = MySqlSslMode.None;

            String connString = builder.ToString();

            builder = null;

            Console.WriteLine(connString);

            dbConn = new MySqlConnection(connString);

            Application.ApplicationExit += (sender, args) =>
            {
                if (dbConn != null)
                {
                    dbConn.Dispose();
                    dbConn = null;
                }
            };
        }*/

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
        /*
        private bool GetLogin()
        {
            bool flag = false;
            String query = "SELECT username, password, fname, lname FROM project.users WHERE username='" + username_tb.Text + "';";
            String logQuery = "UPDATE project.users SET isloggedin=1 WHERE username='" + username_tb.Text + "';";

            MySqlCommand cmd = new MySqlCommand(query, dbConn);
            MySqlCommand cmd2 = new MySqlCommand(logQuery, dbConn);

            dbConn.Open();

            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                username = (reader["username"]).ToString();
                password = (reader["password"]).ToString();
                fname = (reader["fname"]).ToString();
                lname = (reader["lname"]).ToString();
            }
            reader.Close();

            cmd2.ExecuteNonQuery();
            dbConn.Close();

            if (username != null && password_tb.Text == password)
            {
                flag = true;

            }
            return flag;
        }*/


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

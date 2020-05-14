using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComboCounter.Classes
{
    class DBConnection
    {
        private const String SERVER = "localhost";
        private const String DATABASE = "project";
        private const String UID = "root";
        private const String PASSWORD = "root";
        private static MySqlConnection dbConn;

        private static DBConnection instance;

        public static DBConnection getInstance()
        {
            if (instance == null)
            {
                instance = new DBConnection();
            }
            return instance;
        }

        private DBConnection()
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder()
            {
                Server = SERVER,
                UserID = UID,
                Password = PASSWORD,
                Database = DATABASE,
                SslMode = MySqlSslMode.None
            };

            String connString = builder.ToString();

            dbConn = new MySqlConnection(connString);

            Application.ApplicationExit += (sender, args) =>
            {
                if (dbConn != null)
                {
                    dbConn.Dispose();
                    dbConn = null;
                }
            };
        }

        public bool insertUser(int id, String username, String password, String fName, String lName, String sex,
            String wClass, String height, String weight, int age)
        {
            String query = "INSERT into project.users(id, username, password, fname, lname, sex, height, weight, " +
                "class, age) values (@id, @username, @password, @fname, @lname, @sex, @height, @weight, @class, @age);";

            MySqlCommand cmd = new MySqlCommand(query, dbConn);
            dbConn.Open();
            cmd.Parameters.AddWithValue("id", id);
            cmd.Parameters.AddWithValue("username", username);
            cmd.Parameters.AddWithValue("password", password);
            cmd.Parameters.AddWithValue("fname", fName);
            cmd.Parameters.AddWithValue("lname", lName);
            cmd.Parameters.AddWithValue("sex", sex);
            cmd.Parameters.AddWithValue("height", height);
            cmd.Parameters.AddWithValue("weight", weight);
            cmd.Parameters.AddWithValue("class", wClass);
            cmd.Parameters.AddWithValue("age", age);

            int success = cmd.ExecuteNonQuery();
            dbConn.Close();

            return success == 1;

        }

    }
}

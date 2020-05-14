using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ComboCounter
{
    class User
    {
        //set variables for connection
        private const String SERVER = "127.0.0.1";
        private const String DATABASE = "project";
        private const String UID = "root";
        private const String PASSWORD = "692Trrbw83";
        private static MySqlConnection dbConn;

        public int Id { get; private set; }
        public String Username { get; private set; }
        public String Password { get; private set; }
        public String fname { get; set; }
        public String lname { get; set; }
        public String sex { get; set; }
        public String c_lass { get; set; }
        public String height { get; set; }
        public String weight { get; set; }
        public int age { get; set; }




        public User(int id, String u, String p, String f, String l, String s, String c, String h, String w, int a)
        {
            Id = id;
            Username = u;
            Password = p;
            fname = f;
            lname = l;
            sex = s;
            c_lass = c;
            height = h;
            weight = w;
            age = a;
        }

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
        }

        public static User Insert(int i, String u, String p, String f, String l, String s, String c, String h, String w, int a)
        {
            int id = i;
            string username = u;
            string password = p;
            string fname = f;
            string lname = l;
            string sex = s;
            string cl = c;
            string height = h;
            string weight = w;
            int age = a;
            String query = "insert into project.users(id, username, password, fname, lname, sex, height, weight, class, age) values ('" + id + "','" + username + "','" + password + "', '" + fname + "','" + lname + "','" + sex + "','" + cl + "','" + height + "','" + weight + "','" + age + "');";

            MySqlCommand cmd = new MySqlCommand(query, dbConn);

            dbConn.Open();

            cmd.ExecuteNonQuery();

            User user = new User(id, u, p, f, l, s, c, h, w, a);

            dbConn.Close();

            return user;

        }


    }
}

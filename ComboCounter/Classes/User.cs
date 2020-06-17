using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ComboCounter
{
    class User
    {

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




    }
}

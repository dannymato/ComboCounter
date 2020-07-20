using System;

namespace ComboCounter
{
    /// <summary>
    /// Represents the user as it is shown in the database
    /// </summary>
    class User
    {

        public int Id { get; private set; }
        public String Username { get; private set; }
        public String Password { get; private set; }
        public String fname { get; set; }
        public String lname { get; set; }
        public String sex { get; set; }
        public int year { get; set; }
        public int height { get; set; }
        public int weight { get; set; }

        /// <summary>
        /// Initializes a new user with the paramaters shown
        /// </summary>
        /// <param name="id">Individual user ID</param>
        /// <param name="u">Username</param>
        /// <param name="p">Password</param>
        /// <param name="f">First Name</param>
        /// <param name="l">Last Name</param>
        /// <param name="s">Sex</param>
        /// <param name="c">Weight Class</param>
        /// <param name="h">Height</param>
        /// <param name="w">Weight</param>
        /// <param name="a">Age</param>
        public User(int id, String u, String p, String f, String l, 
            String s, int h, int w, int y)
        {
            Id = id;
            Username = u;
            Password = p;
            fname = f;
            lname = l;
            sex = s;
            height = h;
            weight = w;
            year = y;
        }

    }
}

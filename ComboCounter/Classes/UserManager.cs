using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComboCounter.Classes
{
    class UserManager
    {



        private int id;
        private static string username;
        private static string password;
        private static string fname;
        private static string lname;
        private static string sex;
        private static string c_lass;
        private static string height;
        private static string weight;
        private static int age;
        //private static string s_lname;

        // GETTER SETTER ID
        public int GetId()
        {
            return id;
        }

        private void SetId(int value)
        {
            id = value;
        }

        public static User currentUser { get; set; }



        // GETTER SETTER USERNAME
        public static string GetUsername()
        {
            return username;
        }

        private static void SetUsername(string value)
        {
            username = value;
        }


        // GETTER SETTER PASSWORD
        public static string GetPassword()
        {
            return password;
        }

        private static void SetPassword(string value)
        {
            password = value;
        }

        // GETTER SETTER FNAME

        public static string GetFname()
        {
            return fname;
        }

        public static void SetFname(string value)
        {
            fname = value;
        }

        public static string GetLname()
        {
            return lname;
        }

        public static void SetLname(string value)
        {
            lname = value;
        }

        // GETTER SETTER SEX
        public static string GetSex()
        {
            return sex;
        }

        public static void SetSex(string value)
        {
            sex = value;
        }

        // GETTER SETTER CLASS
        public static string GetClass()
        {
            return c_lass;
        }

        public static void SetClass(string value)
        {
            c_lass = value;
        }

        // GETTER SETTER HEIGHT
        public static string GetHeight()
        {
            return height;
        }

        public static void SetHeight(string value)
        {
            height = value;
        }


        // GETTER SETTER WEIGHT
        public static string GetWeight()
        {
            return weight;
        }

        public static void SetWeight(string value)
        {
            weight = value;
        }


        // GETTER SETTER AGE
        public static int GetAge()
        {
            return age;
        }

        public static void SetAge(int value)
        {
            age = value;
        }

    }

}

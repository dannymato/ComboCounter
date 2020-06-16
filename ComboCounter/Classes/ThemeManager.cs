using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace ComboCounter.Classes
{
    class ThemeManager
    {
        private static int DBThemeNum = 1;
        private static int ThemeNum = 2;
        //Boolean ThemeBoolean;


        public static Color initBackground()
        {
           
            if (Verify())
            {
                return ChangeBackground(GetDBThemeNum());
            }
            else
            {
                return ChangeBackground(GetThemeNum());
            }
      
        }

        public static Color initButtonColor()
        {
            if (Verify())
            {
                return ChangeButtonColor(GetDBThemeNum());

            }
            else
            {
                return ChangeButtonColor(GetThemeNum());
            }
        }

        public static Color initHeaderColor()
        {
            if (Verify())
            {
                // DEFINE METOD FOR RETURNING ISHHH
                return ChangeHeaderColor(GetDBThemeNum());

            }
            else
            {
                return ChangeHeaderColor(GetThemeNum());
            }
        }


        public static Color initH2Color()
        {
            if (Verify())
            {
            
                return ChangeH2Color(GetDBThemeNum());

            }
            else
            {
                return ChangeH2Color(GetThemeNum());
            }
        }

        public static Color initH3Color()
        {
            if (Verify())
            {
                return ChangeH3Color(GetDBThemeNum());

            }
            else
            {
                return ChangeH3Color(GetThemeNum());
            }
        }

        public static Color initTextColor()
        {
            if (Verify())
            {
                return ChangeTextColor(GetDBThemeNum());

            }
            else
            {
                return ChangeTextColor(GetThemeNum());
            }
        }



        //----------------------------
        public static Boolean Verify()
        {
            // GET LAST THEME NUMBER
            if(GetThemeNum() == GetDBThemeNum())
            {
                return true;
            }
            else
            {
                return false;
               //ChangeBackground(t);
            }
        }

        //RETRIEVES THEME NUMBER
        private static int GetThemeNum()
        {
            return ThemeNum;
        }

        private static int GetDBThemeNum()
        {
            return DBThemeNum;
        }

        //----------------------------


        // CHANGE COLOR ELEMENTS
        
        private static Color ChangeBackground(int t)
        {
         
          
            if(t == 1)
            {
                return ThemeConstants.white;
            }
            else if(t == 2)
            {
                return ThemeConstants.red;
            }
            else if (t == 3)
            {
                return ThemeConstants.green;
            }
            else
            {
                return ThemeConstants.white;
            }
        }


        private static Color ChangeButtonColor(int t)
        {


            if (t == 1)
            {
                return ThemeConstants.white;
            }
            else if (t == 2)
            {
                return ThemeConstants.red;
            }
            else if (t == 3)
            {
                return ThemeConstants.green;
            }
            else
            {
                return ThemeConstants.white;
            }
        }


        private static Color ChangeHeaderColor(int t)
        {


            if (t == 1)
            {
                return ThemeConstants.white;
            }
            else if (t == 2)
            {
                return ThemeConstants.red;
            }
            else if (t == 3)
            {
                return ThemeConstants.green;
            }
            else
            {
                return ThemeConstants.white;
            }
        }

        private static Color ChangeH2Color(int t)
        {

            if (t == 1)
            {
                return ThemeConstants.white;
            }
            else if (t == 2)
            {
                return ThemeConstants.red;
            }
            else if (t == 3)
            {
                return ThemeConstants.green;
            }
            else
            {
                return ThemeConstants.white;
            }
        }

        private static Color ChangeH3Color(int t)
        {
            if (t == 1)
            {
                return ThemeConstants.white;
            }
            else if (t == 2)
            {
                return ThemeConstants.red;
            }
            else if (t == 3)
            {
                return ThemeConstants.green;
            }
            else
            {
                return ThemeConstants.white;
            }
        }

        private static Color ChangeTextColor(int t)
        {
            if (t == 1)
            {
                return ThemeConstants.white;
            }
            else if (t == 2)
            {
                return ThemeConstants.red;
            }
            else if (t == 3)
            {
                return ThemeConstants.green;
            }
            else
            {
                return ThemeConstants.white;
            }
        }



    }
}

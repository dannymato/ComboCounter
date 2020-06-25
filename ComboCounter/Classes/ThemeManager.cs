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

        // THEME NUMBER FROM DB
        private static int DBThemeNum = 2;

        // THEME CHOSEN BY USER
        private static int ThemeNum = 2;
        


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

        public static Color initH2HoverColor()
        {
            if (Verify())
            {

                return ChangeHeaderColor(GetDBThemeNum());

            }
            else
            {
                return ChangeHeaderColor(GetThemeNum());
            }
        }

        public static Color initH2ClickColor()
        {
            if (Verify())
            {

                return ChangeHeaderColor(GetDBThemeNum());

            }
            else
            {
                return ChangeHeaderColor(GetThemeNum());
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

        // VERIFIES THEME CHOSEN BY USER IS DIFFERENT FROM ONE STORED IN DB
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



        // CHANGE ELEMENTS
        
        private static Color ChangeBackground(int t)
        {
         
          
            if(t == 1)
            {
                return ThemeConstants.Theme1BgColor;
            }
            else if(t == 2)
            {
                return ThemeConstants.Theme2BgColor;
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

        // MAY NOT USE****
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

        // CHANGES COLOR OF HEADER ELEMENT
        private static Color ChangeHeaderColor(int t)
        {

            if (t == 1)
            {
                return ThemeConstants.HeaderTextColor1;
            }
            else if (t == 2)
            {
                return ThemeConstants.HeaderTextColor2;
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

        // CHANGES COLOR OF H2 ELEMENT
        private static Color ChangeH2Color(int t)
        {

            if (t == 1)
            {
                return ThemeConstants.H2TextColor1;
            }
            else if (t == 2)
            {
                return ThemeConstants.H2TextColor2;
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

        // COLOR OF BUTTON CLICK FEEDBACK
        private static Color ChangeH2ClickColor(int t)
        {

            if (t == 1)
            {
                return ThemeConstants.H2ClickColor1;
            }
            else if (t == 2)
            {
                return ThemeConstants.H2ClickColor2;
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

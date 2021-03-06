﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace ComboCounter.Classes
{
    class ThemeManager
    {
        

        

        public static Color initBackground()
        {           
           /** if (Verify())
            {
                return ChangeBackground(GetDBThemeNum());
            }
            else
            {**/
                return ChangeBackground(GetThemeNum());
            //}
      
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
            return UserManager.ThemeSetting();

        }

        private static int GetDBThemeNum()
        {
            return UserManager.ThemeSetting();
        }

        //----------------------------



        // CHANGE ELEMENTS
        
        private static Color ChangeBackground(int t)
        {
         
          
            if(t == 0)
            {
                return ThemeConstants.Theme1BgColor;
            }
            else if(t == 1)
            {
                return ThemeConstants.Theme2BgColor;
            }
            else if (t == 2)
            {
                return ThemeConstants.Theme3BgColor;
            }
            else
            {
                return ThemeConstants.white;
            }
        }

        // MAY NOT USE****
        private static Color ChangeButtonColor(int t)
        {


            if (t == 0)
            {
                return ThemeConstants.black;
            }
            else if (t == 1)
            {
                return ThemeConstants.white;
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

            if (t == 0)
            {
                return ThemeConstants.HeaderTextColor1;
            }
            else if (t == 1)
            {
                return ThemeConstants.HeaderTextColor2;
            }
            else if (t == 2)
            {
                return ThemeConstants.HeaderTextColor3;
            }
            else
            {
                return ThemeConstants.white;
            }
        }

        private static Color ChangeH2Color(int t)
        {

            if (t == 0)
            {
                return ThemeConstants.H2TextColor1;
            }
            else if (t == 1)
            {
                return ThemeConstants.H2TextColor2;
            }
            else if (t == 2)
            {
                return ThemeConstants.H2TextColor3;
            }
            else
            {
                return ThemeConstants.white;
            }
        }

        private static Color ChangeH2ClickColor(int t)
        {

            if (t == 0)
            {
                return ThemeConstants.H2ClickColor1;
            }
            else if (t == 1)
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
            if (t == 0)
            {
                return ThemeConstants.white;
            }
            else if (t == 1)
            {
                return ThemeConstants.red;
            }
            else if (t == 2)
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
            if (t == 0)
            {
                return ThemeConstants.Theme1TextColor;
            }
            else if (t == 1)
            {
                return ThemeConstants.Theme2TextColor;
            }
            else if (t == 2)
            {
                return ThemeConstants.Theme3TextColor;
            }
            else
            {
                return ThemeConstants.white;
            }
        }

    }
}

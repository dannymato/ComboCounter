using System.Windows.Forms;



namespace ComboCounter.Classes
{
    class H2 : Label
    {
        public H2() : base()
        {
            FontManager fm = FontManager.getInstance();
            Font = fm.getHeader2Font();

            AutoSize = false;

        }

    }
}
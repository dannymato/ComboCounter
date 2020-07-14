using System.Drawing;
using System.Drawing.Text;
using System.Runtime.InteropServices;

namespace ComboCounter.Classes
{
    class FontManager
    {

        // pfc Family indices
        // 0 Roboto 
        // 1 Roboto Medium
        // 2 Roboto Slab Extra Bold
        // When adding fonts to the PrivateFontCollection the fonts will be sorted by name
        PrivateFontCollection pfc;

        private static FontManager instance;

        private FontManager()
        {

            pfc = new PrivateFontCollection();

            AddToPfc(Properties.Resources.RobotoSlab_ExtraBold);
            AddToPfc(Properties.Resources.Roboto_Regular);
            AddToPfc(Properties.Resources.Roboto_Medium);
        }

        /// <summary>
        /// Adds the font to the PrivateFontCollection from the Resources.resx
        /// </summary>
        /// <param name="newFont">The font from thre Resources.resx</param>
        private void AddToPfc(byte[] newFont)
        {
            int fontLength = newFont.Length;

            System.IntPtr fontPtr = Marshal.AllocCoTaskMem(fontLength);
            Marshal.Copy(newFont, 0, fontPtr, fontLength);

            this.pfc.AddMemoryFont(fontPtr, fontLength);
        }

        /// <summary>
        /// Returns the instance of the FontManager class
        /// Creates the instance if it is not yet created
        /// </summary>
        /// <returns>The instance of the FontManager class</returns>
        public static FontManager getInstance()
        {
            if (instance == null)
            {
                instance = new FontManager();
            }

            return instance;
        }

        /// <summary>
        /// Returns a Font used by the Header controls
        /// </summary>
        /// <returns>Font used by the Header controls</returns>
        public Font getHeaderFont()
        {
            return new Font(pfc.Families[2], 80);
        }

        /// <summary>
        /// Returns a font used by the H2 controls
        /// </summary>
        /// <returns>new Font used by the H2 controls</returns>
        public Font getHeader2Font()
        {
            return new Font(pfc.Families[2], 70);
        }

        /// <summary>
        /// Returns a font used by the H3 controls
        /// </summary>
        /// <returns></returns>
        public Font getHeader3Font()
        {
            return new Font(pfc.Families[2], 36);
        }

        /// <summary>
        /// Returns a font used by the H4
        /// </summary>
        /// <returns></returns>
        public Font getHeader4Font()
        {
            return new Font(pfc.Families[2], 24);
        }

        /// <summary>
        /// Returns a font used by the BigInfo controls
        /// </summary>
        /// <returns></returns>
        public Font getBigInfoFont()
        {
            return new Font(pfc.Families[0], 120);
        }

        /// <summary>
        /// Returns a font used by the MediumInfo controls
        /// </summary>
        /// <returns></returns>
        public Font getMediumInfoFont()
        {
            return new Font(pfc.Families[0], 60);
        }

        /// <summary>
        /// Returns a font used by the SmallInfo controls
        /// </summary>
        /// <returns></returns>
        public Font getSmallInfoFont()
        {
            return new Font(pfc.Families[0], 30);
        }

        /// <summary>
        /// Returns a font used by the Button controls
        /// </summary>
        /// <returns></returns>
        public Font getButtonFont()
        {
            return new Font(pfc.Families[1], 20);
        }

        /// <summary>
        /// Returns a font used by the TextBoxes
        /// </summary>
        /// <returns></returns>
        public Font getTextBoxFont()
        {
            return new Font(pfc.Families[0], 18);
        }

    }
}

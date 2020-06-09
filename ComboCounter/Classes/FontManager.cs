using System.Drawing;
using System.Drawing.Text;
using System.Runtime.InteropServices;

namespace ComboCounter.Classes
{
    class FontManager
    {

        PrivateFontCollection pfc;

        private static FontManager instance;

        private FontManager()
        {

            pfc = new PrivateFontCollection();

            int fontLength = Properties.Resources.RobotoSlab_ExtraBold.Length;
            byte[] fontData = Properties.Resources.RobotoSlab_ExtraBold;

            System.IntPtr data = Marshal.AllocCoTaskMem(fontLength);
            Marshal.Copy(fontData, 0, data, fontLength);

            pfc.AddMemoryFont(data, fontLength);

            int fontLength2 = Properties.Resources.Roboto_Regular.Length;
            byte[] fontData2 = Properties.Resources.Roboto_Regular;

            System.IntPtr data2 = Marshal.AllocCoTaskMem(fontLength2);
            Marshal.Copy(fontData2, 0, data2, fontLength2);

            pfc.AddMemoryFont(data2, fontLength2);
        }

        public static FontManager getInstance()
        {
            if (instance == null)
            {
                instance = new FontManager();
            }

            return instance;
        }

        public Font getHeaderFont()
        {
            return new Font(pfc.Families[1], 75);
        }

        public Font getSubheaderFont()
        {
            return new Font(pfc.Families[1], 36);
        }

        public Font getBigInfoFont()
        {
            return new Font(pfc.Families[0], 120);
        }

        public Font getSmallInfoFont()
        {
            return new Font(pfc.Families[0], 30);
        }

        public Font getButtonFont()
        {
            return new Font(pfc.Families[0], 20);
        }
    }
}

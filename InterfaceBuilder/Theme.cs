using Xamarin.Forms;

namespace InterfaceBuilder
{
    public class Theme
    {
        public Sizes Sizes = new Sizes();
        public KeyColors KeyColors = new KeyColors();
        public Colors Colors = new Colors();

        public Theme()
        {
            KeyColors.Background = Colors.White;
            KeyColors.Text = Colors.Black;
            KeyColors.NavigationBarBackground = Colors.Gray;
        }
    }

    public class Sizes
    {
        public int NormalFont = 18;
        public int HeadlineFont = 22;
        public int LargeFont = 30;
    }

    public class KeyColors
    {
        public Color Text = Color.Black;
        public Color Background = Color.White;
        public Color NavigationBarBackground = Color.Gray;
        public Color? NavigationBarText = null;
    }

    public class Colors
    {
        public Color Green = Color.FromHex("BBCA72");
        public Color LightGray = Color.FromHex("EFEFEF");
        public Color DarkGray = Color.FromHex("3A3E42");
        public Color Gray = Color.FromHex("CCCCCC");
        public Color White = Color.White;
        public Color Black = Color.FromHex("222");
    }
}

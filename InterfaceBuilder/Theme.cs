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
            KeyColors.SecondaryColor = Colors.DarkGray;
        }
    }

    public class Sizes
    {
        public int NormalFont = 15;
        public int HeadlineFont = 18;
        public int PageMargin = 20;
    }

    public class KeyColors
    {
        public Color Text = Color.Black;
        public Color Background = Color.White;
        public Color SecondaryColor = Color.Black;
        public Color TintColor = Color.White;
    }

    public class Colors
    {
        public Color Green = Color.FromHex("BBCA72");
        public Color LightGray = Color.FromHex("EFEFEF");
        public Color DarkGray = Color.FromHex("3A3E42");
        public Color Gray = Color.FromHex("CCCCCC");
        public Color White = Color.White;
        public Color Yellow = Color.FromHex("FFDD00");
        public Color Black = Color.FromHex("222");
    }
}

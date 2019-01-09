using Xamarin.Forms;

namespace InterfaceBuilder
{
    public class Theme
    {
        public Sizes Sizes = new Sizes();
        public ColorScheme Colors = new ColorScheme();
    }

    public class Sizes
    {
        public int NormalFont = 15;
        public int HeadlineFont = 18;
        public int PageMargin = 20;
    }

    public class ColorScheme
    {
        public ColorPair Primary = new ColorPair();
        public ColorPair Accent = new ColorPair("EEE", "333");
        public ColorPair Error = new ColorPair(Color.White, Color.OrangeRed);
    }

    public class ColorPair
    {
        public Color Foreground = Color.Black;
        public Color Background = Color.White;

        public ColorPair() { }

        public ColorPair(Color foreground, Color background)
        {
            Foreground = foreground;
            Background = background;
        }

        public ColorPair(string foreground, string background)
        {
            Foreground = Color.FromHex(foreground);
            Background = Color.FromHex(background);
        }

        public ColorPair Flip()
        {
            return new ColorPair(Background, Foreground);
        }
    }
}

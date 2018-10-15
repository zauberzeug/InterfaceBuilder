using Xamarin.Forms;

namespace InterfaceBuilder.Styling
{
    public class Theme
    {
        public Theme()
        {
            BackgroundColor = Colors.White;
            NavigationBarBackgroundColor = Colors.Gray;
            TextColor = Colors.Black;
            NavigationBarTextColor = null;
            NormalFontSize = 18;
        }

        public Color BackgroundColor { get; protected set; }
        public Color TextColor { get; protected set; }
        public Color NavigationBarBackgroundColor { get; protected set; }
        public Color? NavigationBarTextColor { get; protected set; }
        public int NormalFontSize { get; protected set; }
    }
}

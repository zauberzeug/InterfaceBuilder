using Xamarin.Forms;

namespace InterfaceBuilder
{
    public class ElusiveIcon : Label
    {
        public ElusiveIcon(string icon)
        {
            Text = icon;
            VerticalTextAlignment = TextAlignment.Center;
            HorizontalTextAlignment = TextAlignment.Center;
            MinimumWidthRequest = 1e6; // https://stackoverflow.com/questions/41861020/
            TextColor = Theme.Colors.Gray;
            FontFamily = "Elusive-Icons";
            FontSize = 25;
        }

        public static class Named
        {
            public static readonly string Checkmark = "";
            public static readonly string Plus = "";
            public static readonly string Trash = "";
            public static readonly string ChevronUp = "";
            public static readonly string ChevronDown = "";
            public static readonly string ChevronRight = "";
            public static readonly string Magnifier = "";
            public static readonly string Telephone = "";
            public static readonly string Email = "";
            public static readonly string Play = "";
            public static readonly string Pause = "";
            public static readonly string Stop = "";
            public static readonly string Remove = "";
            public static readonly string Camera = "";
            public static readonly string Circle = "";
            public static readonly string ArrowUpDown = "";
            public static readonly string Key = "";
            public static readonly string InfoCircle = "";
            public static readonly string Dashboard = "";
            public static readonly string FileEdit = "";
            public static readonly string Signal = "";
        }
    }
}

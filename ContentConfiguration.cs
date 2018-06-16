using Xamarin.Forms;
using Xamarin.Forms.Internals;

namespace InterfaceBuilder
{
    public static class ContentConfiguration
    {
        public static T Add<T>(this T layout, params View[] views) where T : StackLayout
        {
            views.ForEach(v => layout.Children.Add(v));
            return layout;
        }

        public static Label Text(this Label label, string text)
        {
            label.Text = text;
            return label;
        }

        public static Label Bold(this Label label)
        {
            label.FontAttributes = FontAttributes.Bold;
            return label;
        }

        public static Label Centered(this Label label)
        {
            label.HorizontalTextAlignment = TextAlignment.Center;
            return label;
        }

        public static StackLayout Vertical(this StackLayout layout)
        {
            layout.Orientation = StackOrientation.Vertical;
            layout.VerticalOptions = LayoutOptions.FillAndExpand;
            return layout;
        }

        public static StackLayout Horizontal(this StackLayout layout)
        {
            layout.Orientation = StackOrientation.Horizontal;
            layout.HorizontalOptions = LayoutOptions.FillAndExpand;
            return layout;
        }

        public static StackLayout Space(this StackLayout layout, int spacing)
        {
            layout.Spacing = spacing;
            layout.Padding = spacing;
            return layout;
        }

        public static StackLayout With(this StackLayout layout, params View[] views)
        {
            layout.Add(views);
            return layout;
        }

        public static T Content<T>(this ContentPage page, T view) where T : View
        {
            page.Content(view);
            return view;
        }

        public static T Background<T>(this T page, Color color) where T : Page
        {
            page.BackgroundColor = color;
            return page;
        }

        public static T Padding<T>(this T layout, Thickness thickness) where T : Layout
        {
            layout.Padding = thickness;
            return layout;
        }

        public static T Padding<T>(this T layout, int horizontal, int vertical) where T : Layout
        {
            layout.Padding = new Thickness(horizontal, vertical);
            return layout;
        }
    }
}

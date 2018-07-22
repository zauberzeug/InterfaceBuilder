using Xamarin.Forms;
using Xamarin.Forms.Internals;

namespace InterfaceBuilder
{
    public static class ContentConfiguration
    {
        public static T Add<T>(this T layout, params View[] views) where T : Layout<View>
        {
            views.ForEach(v => layout.Children.Add(v));
            return layout;
        }

        public static Label Text(this Label label, string text)
        {
            label.Text = text;
            return label;
        }

        public static Label Size(this Label label, int size)
        {
            label.FontSize = size;
            return label;
        }

        public static Label Color(this Label label, Color color)
        {
            label.TextColor = color;
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
            layout.VerticalOptions = LayoutOptions.Center;
            layout.HorizontalOptions = LayoutOptions.FillAndExpand;
            return layout;
        }

        public static T FillHorizontal<T>(this T view) where T : View
        {
            view.HorizontalOptions = LayoutOptions.FillAndExpand;
            return view;
        }

        public static T Size<T>(this T view, double size) where T : View
        {
            view.HeightRequest = size;
            view.WidthRequest = size;
            return view;
        }

        public static StackLayout Space(this StackLayout layout, int spacing)
        {
            layout.Spacing = spacing;
            layout.Padding = spacing;
            return layout;
        }

        public static T With<T>(this T layout, params View[] views) where T : Layout<View>
        {
            layout.Add(views);
            return layout;
        }

        public static T Content<T>(this ContentPage page, T view) where T : View
        {
            page.Content(view);
            return view;
        }

        public static T Background<T>(this T page, Color color) where T : View
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

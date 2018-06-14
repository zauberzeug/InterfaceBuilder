using System;

using SVG.Forms.Plugin.Abstractions;
using Xamarin.Forms;

namespace InterfaceBuilder
{
    public static class UI
    {
        public static Label Label(string text = "")
        {
            return new Label
            {
                HorizontalTextAlignment = TextAlignment.Center,
                TextColor = Theme.Colors.White,
                FontSize = Theme.Sizes.NormalFont,
                Margin = Theme.Sizes.NormalFont,
            }.Text(text);
        }

        public static StackLayout Stack()
        {
            return new StackLayout
            {
                BackgroundColor = Color.Transparent,
            };
        }

        public static ContentPage Page(string title, View content)
        {
            return new ContentPage
            {
                Title = title,
                Content = content,
            };
        }

        public static BoxView HorizontalFill()
        {
            return new BoxView()
            {
                HorizontalOptions = LayoutOptions.FillAndExpand,
            };
        }

        public static BoxView VerticalFill()
        {
            return new BoxView()
            {
                VerticalOptions = LayoutOptions.FillAndExpand,
            };
        }

        public static ElusiveIcon Icon(string icon) => new ElusiveIcon(icon);
    }
}

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
                TextColor = Theme.KeyColors.Text,
                FontSize = Theme.Sizes.NormalFont,
                Margin = Theme.Sizes.NormalFont,
            }.Text(text);
        }

        public static StackLayout Action(string text = "", ElusiveIcon icon = null)
        {
            var stack = UI.Stack().Horizontal().Padding(new Thickness(10, 0));
            if (icon != null)
                stack.Children.Insert(0, icon);
            return stack.With(UI.Label(text));
        }

        public static StackLayout Stack()
        {
            return new StackLayout
            {
                BackgroundColor = Color.Transparent,
                Spacing = 0,
            };
        }

        public static BoxView Box(int size)
        {
            return new BoxView
            {
                BackgroundColor = Color.Transparent,
                WidthRequest = size,
                HeightRequest = size,
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

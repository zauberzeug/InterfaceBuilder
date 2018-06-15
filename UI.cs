using System;

using SVG.Forms.Plugin.Abstractions;
using Xamarin.Forms;

namespace InterfaceBuilder
{
    public class UI
    {
        public Theme Theme { get; private set; }

        public static UI Current;

        public UI(Theme theme = null)
        {
            this.Theme = theme ?? new Theme();
            Current = this;
        }

        public Label Label(string text = "")
        {
            return new Label
            {
                HorizontalTextAlignment = TextAlignment.Center,
                TextColor = Theme.KeyColors.Text,
                FontSize = Theme.Sizes.NormalFont,
                Margin = Theme.Sizes.NormalFont,
            }.Text(text);
        }

        public StackLayout Action(string text = "", string icon = null)
        {
            var stack = Stack().Horizontal().Padding(new Thickness(10, 0));
            if (icon != null)
                stack.Children.Insert(0, Icon(icon));
            return stack.With(Label(text));
        }

        public StackLayout Stack()
        {
            return new StackLayout
            {
                BackgroundColor = Color.Transparent,
                Spacing = 0,
            };
        }

        public BoxView Box(int size)
        {
            return new BoxView
            {
                BackgroundColor = Color.Transparent,
                WidthRequest = size,
                HeightRequest = size,
            };
        }

        public ContentPage Page(string title, View content)
        {
            return new ContentPage
            {
                Title = title,
                Content = content,
            };
        }

        public BoxView HorizontalFill()
        {
            return new BoxView()
            {
                HorizontalOptions = LayoutOptions.FillAndExpand,
            };
        }

        public BoxView VerticalFill()
        {
            return new BoxView()
            {
                VerticalOptions = LayoutOptions.FillAndExpand,
            };
        }

        public Label Icon(string icon)
        {
            return new Label
            {
                Text = icon,
                VerticalTextAlignment = TextAlignment.Center,
                HorizontalTextAlignment = TextAlignment.Center,
                MinimumWidthRequest = 1e6, // https://stackoverflow.com/questions/41861020/
                TextColor = Theme.KeyColors.Text,
                FontFamily = "Elusive-Icons",
                FontSize = 25,
            };
        }
    }
}
using InterfaceBuilder.Styling;
using Xamarin.Forms;
using Xamarin.Forms.Internals;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;

namespace InterfaceBuilder
{
    public class UI
    {
        public Theme Theme { get; private set; }

        public UI(Theme theme = null) => this.Theme = theme ?? new Theme();

        public Label Label(string text = "")
        {
            return new Label {
                HorizontalTextAlignment = TextAlignment.Start,
                TextColor = Theme.TextColor,
                FontSize = Theme.NormalFontSize,
                HeightRequest = Theme.NormalFontSize * 2,
                VerticalTextAlignment = TextAlignment.Center,
                Margin = new Thickness(Theme.NormalFontSize, 0),
            }.Text(text);
        }

        public Xamarin.Forms.Entry Entry(string placeholder = "")
        {
            return new Xamarin.Forms.Entry {
                TextColor = Theme.TextColor,
                FontSize = Theme.NormalFontSize,
                HorizontalOptions = LayoutOptions.FillAndExpand,
                Placeholder = placeholder,
                BackgroundColor = Theme.BackgroundColor,
                Margin = new Thickness(Theme.NormalFontSize, Theme.NormalFontSize / 2.0),
            };
        }

        public Label Headline(string text = "")
        {
            return Label(text).Bold();
        }

        public StackLayout Action(string text = "", string icon = null)
        {
            var stack = Stack().Horizontal().Padding(new Thickness(25, 0));
            if (icon != null)
                stack.Children.Insert(0, Icon(icon));
            return stack.With(Label(text));
        }

        public StackLayout Stack()
        {
            return new StackLayout {
                BackgroundColor = Color.Transparent,
                Spacing = 0,
            };
        }

        public BoxView Box()
        {
            return new BoxView {
                BackgroundColor = Color.Transparent,
            };
        }

        public BoxView Box(int size)
        {
            return new BoxView {
                BackgroundColor = Color.Transparent,
                WidthRequest = size,
                HeightRequest = size,
                Margin = new Thickness(Theme.NormalFontSize, Theme.NormalFontSize / 2.0),
            };
        }

        public Frame Frame(View content)
        {
            return new Frame {
                BackgroundColor = Theme.BackgroundColor,
                HorizontalOptions = LayoutOptions.FillAndExpand,
                Content = content,
                BorderColor = Theme.TextColor,
                HasShadow = false,
                CornerRadius = 0
            }.Padding(5);
        }

        public ContentView Scrollable(View content)
        {
            return new ContentView {
                Content = content
            };
        }

        public FlexLayout Flex()
        {
            return new FlexLayout() {
                AlignItems = FlexAlignItems.Center,
                JustifyContent = FlexJustify.SpaceBetween,
                AlignContent = FlexAlignContent.SpaceEvenly,
                HorizontalOptions = LayoutOptions.FillAndExpand,
            };
        }

        public ContentPage Page(string title, View content)
        {
            var page = new ContentPage {
                Title = title,
                Content = content,
                BackgroundColor = Theme.BackgroundColor,
            };

            page.On<Xamarin.Forms.PlatformConfiguration.iOS>().SetLargeTitleDisplay(LargeTitleDisplayMode.Never);
            page.On<Xamarin.Forms.PlatformConfiguration.iOS>().SetUseSafeArea(true);

            return page;
        }

        public ContentPage ScrollPage(string title, View content)
        {
            return Page(title, Scrollable(content));
        }

        public TabbedPage TabbedPage(string title, params Xamarin.Forms.Page[] pages)
        {
            var page = new TabbedPage {
                Title = title,
            };

            pages.ForEach(p => page.Children.Add(p));

            return page;
        }

        public Xamarin.Forms.NavigationPage NavigationPage(string title, View content)
        {
            return NavigationPage(Page(title, content));
        }

        public Xamarin.Forms.NavigationPage NavigationPage(Xamarin.Forms.Page page)
        {
            var navigation = new Xamarin.Forms.NavigationPage(page);
            navigation.BarBackgroundColor = Theme.NavigationBarBackgroundColor;
            navigation.BarTextColor = Theme.NavigationBarTextColor ?? Theme.BackgroundColor;
            return navigation;
        }

        public BoxView HorizontalFill()
        {
            return new BoxView() {
                HorizontalOptions = LayoutOptions.FillAndExpand,
            };
        }

        public BoxView VerticalFill()
        {
            return new BoxView() {
                VerticalOptions = LayoutOptions.FillAndExpand,
            };
        }

        public Label Icon(string icon)
        {
            var fontFamily = "";
            if (Device.RuntimePlatform == Device.Android)
                fontFamily = "Elusive-Icons.ttf#Elusive-Icons Regular";
            else if (Device.RuntimePlatform == Device.iOS)
                fontFamily = "Elusive-Icons";

            return new Label {
                Text = icon,
                VerticalTextAlignment = TextAlignment.Center,
                HorizontalTextAlignment = TextAlignment.Center,
                MinimumWidthRequest = 1e6, // https://stackoverflow.com/questions/41861020/
                TextColor = Theme.TextColor,
                FontFamily = fontFamily,
                FontSize = 25,
            };
        }

        public Slider Slider(double min, double max)
        {
            return new Slider {
                Minimum = min,
                Maximum = max,
                ThumbColor = Colors.Yellow,
                MinimumTrackColor = Colors.Yellow,
                MaximumTrackColor = Colors.DarkGray
            };
        }
    }
}
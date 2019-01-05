using System.IO;
using System.Reflection;
using Naxam.Controls.Forms;
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
                TextColor = Theme.KeyColors.Text,
                FontSize = Theme.Sizes.NormalFont,
                VerticalTextAlignment = TextAlignment.Center,
                Margin = new Thickness(Theme.Sizes.NormalFont, Theme.Sizes.NormalFont / 2),
                LineBreakMode = LineBreakMode.WordWrap,
            }.Text(text);
        }

        public Button Button(string text = "")
        {
            return new Button {
                FontSize = Theme.Sizes.NormalFont,
                TextColor = Theme.KeyColors.Text,
                Text = text,
            };
        }

        public Image Image(string resourceId = "")
        {
            var image = new Image {
                Source = ImageSource.FromResource(resourceId, FindCallingAssembly()),
                Aspect = Aspect.AspectFill,
            };
            image.Source.AutomationId = resourceId;
            return image;
        }

        public WebView Html(string content)
        {
            var ressource = FindCallingAssembly().GetManifestResourceStream(content);

            if (ressource != null)
                content = new StreamReader(ressource).ReadToEnd();

            if (!content.Contains("<head>"))
                content = @"<html>
<head>
     <style type='text/css'>
        body {
            background-color: transparent;
            font-family: sans-serif;
            font-size: " + Theme.Sizes.NormalFont + @"px;
        }
    </style>
</head>
<body>" + content + "</body></html>";
            return new WebView {
                Source = new HtmlWebViewSource { Html = content },
                BackgroundColor = Color.Transparent,
                IsEnabled = false,
            }.FillVertical();
        }

        public WebView Website(string url)
        {
            return new WebView {
                Source = url
            };
        }

        public Xamarin.Forms.Entry Entry(string placeholder = "")
        {
            return new Xamarin.Forms.Entry {
                TextColor = Theme.KeyColors.Text,
                FontSize = Theme.Sizes.NormalFont,
                HorizontalOptions = LayoutOptions.FillAndExpand,
                Placeholder = placeholder,
                BackgroundColor = Theme.KeyColors.Background,
                Margin = new Thickness(Theme.Sizes.NormalFont, Theme.Sizes.NormalFont / 2.0),
            };
        }

        public Label Headline(string text = "")
        {
            return Label(text).Bold().FontSize(Theme.Sizes.HeadlineFont).
                              Margin(new Thickness(Theme.Sizes.NormalFont, 2 * Theme.Sizes.NormalFont, Theme.Sizes.NormalFont, 0));
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

        public ActivityIndicator ActivityIndicator()
        {
            return new ActivityIndicator { IsRunning = true, IsVisible = true, Margin = 10 };
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
                Margin = new Thickness(Theme.Sizes.NormalFont, Theme.Sizes.NormalFont / 2.0),
            };
        }

        public Frame Frame(View content)
        {
            return new Frame {
                BackgroundColor = Theme.KeyColors.Background,
                HorizontalOptions = LayoutOptions.FillAndExpand,
                Content = content,
                BorderColor = Theme.KeyColors.Text,
                HasShadow = false,
                CornerRadius = 0
            }.Padding(5);
        }

        public Xamarin.Forms.ScrollView Scrollable(View content)
        {
            return new Xamarin.Forms.ScrollView {
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

        public MasterDetailPage MasterDetailPage(ContentPage menu, Xamarin.Forms.NavigationPage initialContent)
        {
            return new MasterDetailPage {
                Master = menu,
                Detail = initialContent
            };
        }

        public ContentPage Page(string title, View content)
        {
            return new ContentPage {
                Title = title,
                Content = content,
                BackgroundColor = Theme.KeyColors.Background,
            }.WithSafeAreas();
        }

        public ContentPage ScrollPage(string title, View content)
        {
            return Page(title, Scrollable(content));
        }

        public TabbedPage TabbedPage(string title, params Xamarin.Forms.Page[] pages)
        {
            var page = new TopTabbedPage {
                Title = title,
                BarTextColor = Theme.KeyColors.Background,
                BarIndicatorColor = Theme.KeyColors.TintColor,
                BarBackgroundColor = Theme.KeyColors.SecondaryColor,
            };

            pages.ForEach(p => page.Children.Add(p));

            return page.WithSafeAreas();
        }

        public Xamarin.Forms.NavigationPage NavigationPage(string title, View content)
        {
            return NavigationPage(Page(title, content)).WithSafeAreas();
        }

        public Xamarin.Forms.NavigationPage NavigationPage(Xamarin.Forms.Page page)
        {
            var navigation = new Xamarin.Forms.NavigationPage(page);
            navigation.BarBackgroundColor = Theme.KeyColors.SecondaryColor;
            navigation.BarTextColor = Theme.KeyColors.TintColor;
            return navigation.WithSafeAreas();
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
                fontFamily = "elusiveicons";

            return new Label {
                Text = icon,
                VerticalTextAlignment = TextAlignment.Center,
                HorizontalTextAlignment = TextAlignment.Center,
                MinimumWidthRequest = 1e6, // https://stackoverflow.com/questions/41861020/
                TextColor = Theme.KeyColors.Text,
                FontFamily = fontFamily,
                FontSize = 25,
            };
        }

        public Xamarin.Forms.Slider Slider(double min, double max)
        {
            return new Xamarin.Forms.Slider {
                Maximum = max, // Set max before min to avoid crash
                Minimum = min,
            };
        }

        static Assembly FindCallingAssembly()
        {
            var stackTrace = new System.Diagnostics.StackTrace();
            var frame = stackTrace.GetFrames()[2]; // NOTE assuming that this helper method will be called from UI methods which get called from production code where the ressource is defined
            var method = frame.GetMethod();
            string methodName = method.Name;
            var methodsClass = method.DeclaringType;
            var assembly = methodsClass.Assembly;
            return assembly;
        }
    }
}
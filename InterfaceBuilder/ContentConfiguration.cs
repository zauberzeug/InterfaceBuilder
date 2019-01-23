using System;
using System.Linq;
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

        public static T AddFirst<T>(this T layout, params View[] views) where T : Layout<View>
        {
            views.ForEach(v => layout.Children.Insert(0, v));
            return layout;
        }

        public static T Remove<T>(this T layout, params View[] views) where T : Layout<View>
        {
            views.ForEach(v => layout.Children.Remove(v));
            return layout;
        }

        public static Button Color(this Button button, Xamarin.Forms.Color color)
        {
            button.BackgroundColor = color;
            return button;
        }

        public static Label Text(this Label label, string text)
        {
            label.Text = text;
            return label;
        }

        public static Entry Text(this Entry entry, string text)
        {
            entry.Text = text;
            return entry;
        }

        public static Entry Keyboard(this Entry entry, Keyboard keyboard)
        {
            entry.Keyboard = keyboard;
            return entry;
        }

        public static Label LineBreakMode(this Label label, LineBreakMode mode)
        {
            label.LineBreakMode = mode;
            return label;
        }

        public static T FontSize<T>(this T label, int size) where T : Label
        {
            label.FontSize = size;
            return label;
        }

        public static T Font<T>(this T label, string family) where T : Label
        {
            label.FontFamily = family;
            return label;
        }

        public static Label Color(this Label label, Xamarin.Forms.Color color)
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
            label.VerticalTextAlignment = TextAlignment.Center;
            return label;
        }

        public static Label Right(this Label label)
        {
            label.HorizontalTextAlignment = TextAlignment.End;
            label.VerticalTextAlignment = TextAlignment.Center;
            return label;
        }

        public static Label Left(this Label label)
        {
            label.HorizontalTextAlignment = TextAlignment.Start;
            label.VerticalTextAlignment = TextAlignment.Center;
            return label;
        }

        public static Frame Color(this Frame frame, Xamarin.Forms.Color color)
        {
            frame.BorderColor = color;
            return frame;
        }

        public static Frame NoBorder(this Frame frame)
        {
            frame.BorderColor = Xamarin.Forms.Color.Transparent;
            return frame;
        }

        public static Slider MinimumTrackColor(this Slider slider, Xamarin.Forms.Color color)
        {
            slider.MinimumTrackColor = color;
            return slider;
        }

        public static Slider MaximumTrackColor(this Slider slider, Xamarin.Forms.Color color)
        {
            slider.MaximumTrackColor = color;
            return slider;
        }

        public static Slider ThumbColor(this Slider slider, Xamarin.Forms.Color color)
        {
            slider.ThumbColor = color;
            return slider;
        }

        public static FlexLayout AlignFromStart(this FlexLayout flex)
        {
            flex.AlignItems = FlexAlignItems.Start;
            return flex;
        }

        public static FlexLayout JustifyFromStart(this FlexLayout flex)
        {
            flex.JustifyContent = FlexJustify.Start;
            return flex;
        }

        public static FlexLayout JustifyCenter(this FlexLayout flex)
        {
            flex.JustifyContent = FlexJustify.Center;
            return flex;
        }

        public static FlexLayout JustifyFromEnd(this FlexLayout flex)
        {
            flex.JustifyContent = FlexJustify.End;
            return flex;
        }

        public static FlexLayout SpaceEvenly(this FlexLayout flex)
        {
            flex.JustifyContent = FlexJustify.SpaceEvenly;
            return flex;
        }

        public static FlexLayout Wrap(this FlexLayout flex)
        {
            flex.Wrap = FlexWrap.Wrap;
            return flex;
        }

        public static FlexLayout Centered(this FlexLayout flex)
        {
            flex.AlignItems = FlexAlignItems.Center;
            return flex;
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

        public static FlexLayout AsRow(this FlexLayout layout)
        {
            layout.Direction = FlexDirection.Row;
            return layout;
        }

        /// <summary>Stretchs the children on the cross axis via AlignItems and AlignContent property.</summary>
        public static FlexLayout StretchChildren(this FlexLayout flex)
        {
            flex.AlignContent = FlexAlignContent.Stretch;
            flex.AlignItems = FlexAlignItems.Stretch;
            return flex;
        }

        public static FlexLayout AsColumn(this FlexLayout layout)
        {
            layout.Direction = FlexDirection.Column;
            return layout;
        }

        public static T CenterHorizontal<T>(this T view) where T : View
        {
            view.HorizontalOptions = LayoutOptions.CenterAndExpand;
            return view;
        }

        public static T CenterVertical<T>(this T view) where T : View
        {
            view.VerticalOptions = LayoutOptions.CenterAndExpand;
            return view;
        }

        public static T Center<T>(this T view) where T : View
        {
            return view.CenterHorizontal().CenterVertical();
        }

        public static T FillHorizontal<T>(this T view) where T : View
        {
            view.HorizontalOptions = LayoutOptions.FillAndExpand;
            return view;
        }

        public static T FillVertical<T>(this T view) where T : View
        {
            view.VerticalOptions = LayoutOptions.FillAndExpand;
            return view;
        }

        public static T Fill<T>(this T view) where T : View
        {
            return view.FillHorizontal().FillVertical();
        }

        public static T Grow<T>(this T view) where T : View
        {
            FlexLayout.SetGrow(view, 1);
            return view;
        }

        public static T Size<T>(this T view, double size) where T : View
        {
            view.HeightRequest = size;
            view.WidthRequest = size;
            return view;
        }

        public static T Height<T>(this T view, double size) where T : View
        {
            view.HeightRequest = size;
            return view;
        }

        public static T Width<T>(this T view, double size) where T : View
        {
            view.WidthRequest = size;
            return view;
        }

        public static T SquareByWidth<T>(this T view) where T : View
        {
            view.SizeChanged += (s, e) => view.HeightRequest = view.Width;
            return view;
        }

        public static T SquareByHeight<T>(this T view) where T : View
        {
            view.SizeChanged += (s, e) => view.WidthRequest = view.Height;
            return view;
        }

        public static T Automation<T>(this T view, string id) where T : View
        {
            view.AutomationId = id;
            return view;
        }

        public static StackLayout Space(this StackLayout layout, int spacing)
        {
            layout.Spacing = spacing;
            layout.Padding = spacing;
            return layout;
        }

        public static StackLayout Spacing(this StackLayout layout, int spacing)
        {
            layout.Spacing = spacing;
            return layout;
        }

        public static T With<T>(this T layout, params View[] views) where T : Layout<View>
        {
            layout.Add(views);
            return layout;
        }

        public static T ForEach<T, V>(this T layout, Action<V> action) where T : Layout<View> where V : View
        {
            layout.Children.ForEach(v => action((V)v));
            return layout;
        }


        public static T Content<T>(this ContentPage page, T view) where T : View
        {
            page.Content(view);
            return view;
        }

        public static ContentPage OnAppearing(this ContentPage page, params Action[] actions)
        {
            foreach (var action in actions)
                page.Appearing += (s, e) => action();
            return page;
        }

        public static NavigationPage OnAppearing(this NavigationPage page, params Action[] actions)
        {
            foreach (var action in actions)
                page.Navigation.NavigationStack.First().Appearing += (s, e) => action();
            return page;
        }

        public static TabbedPage OnAppearing(this TabbedPage page, Action action)
        {
            page.Children.First().Appearing += (s, e) => action();
            return page;
        }

        public static T Background<T>(this T view, Xamarin.Forms.Color color) where T : VisualElement
        {
            view.BackgroundColor = color;
            return view;
        }

        public static T Invisible<T>(this T view) where T : View
        {
            view.IsVisible = false;
            return view;
        }

        public static T Visible<T>(this T view) where T : View
        {
            view.IsVisible = true;
            return view;
        }

        public static T Margin<T>(this T view, int horizontal, int vertical) where T : View
        {
            view.Margin = new Thickness(horizontal, vertical);
            return view;
        }

        public static T Margin<T>(this T view, int left, int top, int right, int bottom) where T : View
        {
            view.Margin = new Thickness(left, top, right, bottom);
            return view;
        }

        public static T Margin<T>(this T view, Thickness thickness) where T : View
        {
            view.Margin = thickness;
            return view;
        }

        public static T Padding<T>(this T layout, Thickness thickness) where T : Layout
        {
            layout.Padding = thickness;
            return layout;
        }

        public static T Padding<T>(this T layout, int padding) where T : Layout
        {
            layout.Padding = new Thickness(padding);
            return layout;
        }

        public static T Padding<T>(this T layout, int horizontal, int vertical) where T : Layout
        {
            layout.Padding = new Thickness(horizontal, vertical);
            return layout;
        }

        public static T Padding<T>(this T layout, int left, int top, int right, int bottom) where T : Layout
        {
            layout.Margin = new Thickness(left, top, right, bottom);
            return layout;
        }

        public static Slider WithValue(this Slider slider, double value)
        {
            slider.Value = value;
            return slider;
        }

        public static ContentPage Padding(this ContentPage layout, int padding)
        {
            layout.Padding = new Thickness(padding);
            return layout;
        }

        public static Picker DisplayBinding(this Picker picker, BindingBase binding)
        {
            picker.ItemDisplayBinding = binding;
            return picker;
        }

        public static Picker Select(this Picker picker, int index)
        {
            picker.SelectedIndex = index;
            return picker;
        }

        public static TimePicker Select(this TimePicker picker, TimeSpan time)
        {
            picker.Time = time;
            return picker;
        }

        public static DatePicker Select(this DatePicker picker, DateTime date)
        {
            picker.Date = date;
            return picker;
        }
    }
}

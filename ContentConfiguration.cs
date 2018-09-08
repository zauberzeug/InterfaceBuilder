using System;
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

        public static T Remove<T>(this T layout, params View[] views) where T : Layout<View>
        {
            views.ForEach(v => layout.Children.Remove(v));
            return layout;
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

        public static Label FontSize(this Label label, int size)
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
            label.VerticalTextAlignment = TextAlignment.Center;
            return label;
        }

        public static Label Right(this Label label)
        {
            label.HorizontalTextAlignment = TextAlignment.End;
            label.VerticalTextAlignment = TextAlignment.End;
            return label;
        }

        public static Label Left(this Label label)
        {
            label.HorizontalTextAlignment = TextAlignment.Start;
            label.VerticalTextAlignment = TextAlignment.Start;
            return label;
        }

        public static Frame Color(this Frame frame, Color color)
        {
            frame.BorderColor = color;
            return frame;
        }

        public static Frame BackgroundColor(this Frame frame, Color color)
        {
            frame.BackgroundColor = color;
            return frame;
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

        public static FlexLayout StrechChildren(this FlexLayout flex)
        {
            flex.AlignItems = FlexAlignItems.Stretch;
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

        public static FlexLayout Strech(this FlexLayout layout)
        {
            layout.AlignContent = FlexAlignContent.Stretch;
            return layout;
        }

        public static FlexLayout AsColumn(this FlexLayout layout)
        {
            layout.Direction = FlexDirection.Column;
            return layout;
        }

        public static T FillHorizontal<T>(this T view) where T : View
        {
            view.HorizontalOptions = LayoutOptions.FillAndExpand;
            return view;
        }

        public static T Fill<T>(this T view) where T : View
        {
            view.HorizontalOptions = LayoutOptions.Fill;
            return view;
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

        public static T With<T>(this T layout, params View[] views) where T : Layout<View>
        {
            layout.Add(views);
            return layout;
        }

        public static T With<T, V>(this T layout, Action<V> action, params V[] views) where T : Layout<View> where V : View
        {
            views.ForEach(v => action(v));
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

        public static T Margin<T>(this T view, int horizontal, int vertical) where T : View
        {
            view.Margin = new Thickness(horizontal, vertical);
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

        public static T Padding<T>(this T layout, int horizontal, int vertical) where T : Layout
        {
            layout.Padding = new Thickness(horizontal, vertical);
            return layout;
        }
    }
}

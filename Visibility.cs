using Xamarin.Forms;

namespace InterfaceBuilder
{
    public static class Visibility
    {
        public static T Hidden<T>(this T view) where T : View
        {
            view.IsVisible = false;

            return view;
        }

        public static T HiddenUnless<T>(this T view, bool condition) where T : View
        {
            if (!condition)
                view.IsVisible = false;

            return view;
        }
    }
}

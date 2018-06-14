using System;
using Xamarin.Forms;

namespace InterfaceBuilder
{
    public static class Conversions
    {
        public static ContentPage InPage(this View view)
        {
            return UI.Page("", view);
        }

        public static NavigationPage InNavigation(this Page page)
        {
            return new NavigationPage(page);
        }
    }
}

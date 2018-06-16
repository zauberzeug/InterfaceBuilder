using System;
using Xamarin.Forms;

namespace InterfaceBuilder
{
    public static class Conversions
    {
        public static NavigationPage InNavigation(this Page page)
        {
            return new NavigationPage(page);
        }
    }
}

using System;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;

namespace InterfaceBuilder
{
    public static class iOSExtensions
    {

        public static T WithSafeAreas<T>(this T page) where T : Xamarin.Forms.Page
        {
            page.On<Xamarin.Forms.PlatformConfiguration.iOS>().SetLargeTitleDisplay(LargeTitleDisplayMode.Never);
            page.On<Xamarin.Forms.PlatformConfiguration.iOS>().SetUseSafeArea(true);

            return page;
        }
    }
}

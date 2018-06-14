using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;

namespace InterfaceBuilder
{
    public static class ColorizeEverythingExtension
    {
        static readonly List<Color> colors = new List<Color> {
            Color.FromHex("eff3ff"),
            Color.FromHex("bdd7e7"),
            Color.FromHex("6baed6"),
            Color.FromHex("3182bd"),
            Color.FromHex("08519c"),
        };
        // NOTE: from http://colorbrewer2.org/#type=sequential&scheme=Blues&n=5

        public static T ColorizeEverything<T>(this T element, int level = 0) where T : VisualElement
        {
            element.BackgroundColor = colors[level % colors.Count];
            (element as ContentView)?.Content?.ColorizeEverything(level + 1);
            (element as ScrollView)?.Content?.ColorizeEverything(level + 1);
            (element as Layout<View>)?.Children.ToList().ForEach(c => c?.ColorizeEverything(level + 1));
            (element as ContentPage)?.Content?.ColorizeEverything(level + 1);
            (element as NavigationPage)?.CurrentPage?.ColorizeEverything(level + 1);
            (element as MasterDetailPage)?.Master?.ColorizeEverything(level + 1);
            (element as MasterDetailPage)?.Detail?.ColorizeEverything(level + 1);
            (element as MultiPage<Page>)?.Children.ToList().ForEach(p => p?.ColorizeEverything(level + 1));
            return element;
        }
    }
}


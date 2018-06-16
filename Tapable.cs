using System;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Internals;
using System.Linq;

namespace InterfaceBuilder
{
    public static class Tapable
    {
        public static T OnTap<T>(this T view, Action action) where T : View
        {
            view.GestureRecognizers.Add(new TapGestureRecognizer() { Command = new Command(action) });
            return view;
        }

        public static T OnTap<T>(this T view, Func<Task> func) where T : View
        {
            view.GestureRecognizers.Add(new TapGestureRecognizer()
            {
                Command = new Command(async () =>
                {
                    view.Opacity = 0.5;
                    var gestureRecognizers = view.GestureRecognizers.ToList();
                    view.GestureRecognizers.Clear(); // NOTE: disable other gestures while we execute this action
                    await func.Invoke();
                    gestureRecognizers.ForEach(g => view.GestureRecognizers.Add(g));
                    view.Opacity = 1;
                })
            });
            return view;
        }
    }
}

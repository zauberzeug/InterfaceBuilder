using System;
using Xamarin.Forms;

namespace InterfaceBuilder
{
    public static class Tapable
    {
        public static T OnTap<T>(this T view, Action action) where T : View
        {
            view.GestureRecognizers.Add(new TapGestureRecognizer() { Command = new Command(action) });
            return view;
        }
    }
}

using System;
using Xamarin.Forms;

namespace InterfaceBuilder
{
    public static class Assignable
    {
        public static T AssignTo<T>(this T view, ref T reference) where T : View
        {
            reference = view;
            return view;
        }
    }
}

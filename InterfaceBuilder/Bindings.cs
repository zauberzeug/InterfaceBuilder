using System;
using Xamarin.Forms;

namespace InterfaceBuilder
{
    public static class Bindings
    {
        public static T BindFrom<T>(this T target, BindableObject source,
                                  BindableProperty sourceProperty, BindableProperty targetProperty,
                                  BindingMode mode = BindingMode.Default, IValueConverter converter = null, string stringFormat = null)
            where T : BindableObject
        {
            if (target.BindingContext != null && target.BindingContext != source)
                Console.WriteLine($"Incompatible binding source!(from source {source} to target {target.BindingContext})");

            target.BindingContext = source;
            target.SetBinding(targetProperty, sourceProperty.PropertyName, mode, converter, stringFormat);
            return target;
        }

        public static T BindTo<T>(this T source, BindableObject target,
                                  BindableProperty sourceProperty, BindableProperty targetProperty,
                                  BindingMode mode = BindingMode.Default, IValueConverter converter = null, string stringFormat = null)
            where T : BindableObject
        {
            if (target.BindingContext != null && target?.BindingContext != source)
                Console.WriteLine($"Incompatible binding source!(from source {source} to target {target.BindingContext})");

            target.BindingContext = source;
            target.SetBinding(targetProperty, sourceProperty.PropertyName, mode, converter, stringFormat);
            return source;
        }
    }
}

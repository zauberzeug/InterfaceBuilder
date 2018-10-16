using System;
using System.Linq;
using System.Threading.Tasks;
using Xamarin.Forms;
using XFormsTouch;

namespace InterfaceBuilder
{
    public static class Events
    {
        public static T OnTap<T>(this T view, Action action) where T : View
        {
            view.GestureRecognizers.Add(new TapGestureRecognizer() { Command = new Command(action) });
            return view;
        }

        public static T OnTap<T>(this T view, Func<Task> func) where T : View
        {
            view.GestureRecognizers.Add(new TapGestureRecognizer() {
                Command = new Command(async () => {
                    view.Opacity = 0.5;
                    view.IsEnabled = false;
                    var gestureRecognizers = view.GestureRecognizers.ToList();
                    view.GestureRecognizers.Clear(); // NOTE: disable other gestures while we execute this action
                    await func.Invoke();
                    gestureRecognizers.ForEach(g => view.GestureRecognizers.Add(g));
                    view.Opacity = 1;
                    view.IsEnabled = true;
                })
            });
            return view;
        }

        public static T OnTap<T>(this T view, Action onPressed, Action onReleased) where T : View
        {
            return view.OnTap(async () => { onPressed.Invoke(); await Task.FromResult(0); },
                              async () => { onReleased.Invoke(); await Task.FromResult(0); });
        }

        public static T OnTap<T>(this T view, Func<Task> onPressed, Func<Task> onReleased) where T : View
        {
            var touchEffect = new TouchEffect();
            touchEffect.TouchAction += (s, e) => {
                if (e.Type == TouchActionType.Pressed)
                    onPressed();
                if (e.Type == TouchActionType.Released)
                    onReleased();
            };
            view.Effects.Add(touchEffect);

            return view;
        }

        public static Button OnPressed(this Button button, Action action)
        {
            button.Command = new Command(action);
            return button;
        }

        public static Entry OnChange(this Entry entry, EventHandler<TextChangedEventArgs> action)
        {
            entry.TextChanged += action;
            return entry;
        }

        public static Slider OnChange(this Slider slider, Action action)
        {
            slider.ValueChanged += (s, e) => action();
            return slider;
        }

        public static Slider OnChange(this Slider slider, EventHandler<ValueChangedEventArgs> action)
        {
            slider.ValueChanged += (s, e) => action(s, e);
            return slider;
        }

        public static Entry OnCompleted(this Entry entry, EventHandler action)
        {
            entry.Completed += action;
            return entry;
        }
    }
}

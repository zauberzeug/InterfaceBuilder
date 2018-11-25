using InterfaceBuilder;
using Xamarin.Forms;

namespace Demo
{
    public class App : Application
    {
        public App()
        {
            var ui = new UI();
            MainPage = ui.Page("mainpage", ui.Label("test"));
        }
    }
}

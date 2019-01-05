using System;
using InterfaceBuilder;
using Xamarin.Forms;

namespace Demo
{
    public class WebModule : Module
    {
        UI ui;

        public WebModule(UI ui) : base(ui)
        {
            this.ui = ui;
            Icon = IconName.Globe;

            Page = ui.NavigationPage(UI.ScrollPage("Html & Web", ui.Stack().With(

                ui.Headline("From EmbeddedResource"),
                ui.Html("demo.html"),

                ui.Headline("HTML snippets"),
                ui.Html(@"<p>You can also pass just some html code as string.<br/><br/>
                    The interface builder will wrap it with head/body acording 
                    to your theme if none is provided.</p>"),

                ui.Headline("Mixing with other Emelents"),
                ui.Label("As you can see, UI.Html behaves similar to normal Xamarin.Forms Elements. " +
                    "It's not scrollable by itself and only takes the hight it requires for it's content. " +
                    "All interaction in HTML is disabled by default to make it work seamlesly inside a scroll view.")
            )));
        }
    }
}
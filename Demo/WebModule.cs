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
                ui.Html(@"<p>You can also pass just some html code <strong>as string.</strong></p>"),

                ui.Headline("Mixing with other Emelents"),
                ui.Label("As you can see, UI.Html behaves similar to a normal Xamarin.Forms Label."),
                ui.Html(@"It's not scrollable by itself and only takes the hight it requires for it's content.
                    This can be done thanks to the awesome NuGet Package 
                    <a href='https://github.com/matteobortolazzo/HtmlLabelPlugin'>Xam.Plugin.HtmlLabel</a>.
                    because it uses native Label implementations its verry quick and well - behaving.")
            )));
        }
    }
}
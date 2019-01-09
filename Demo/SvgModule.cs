using System;
using InterfaceBuilder;
using Xamarin.Forms;

namespace Demo
{
    public class SvgModule : Module
    {
        UI ui;

        public SvgModule(UI ui) : base(ui)
        {
            this.ui = ui;
            Icon = IconName.Brush;

            Page = ui.NavigationPage(UI.Page("SVG Graphics", ui.Stack().With(

                ui.Headline("From EmbeddedResource"),
                ui.Svg("logo.svg").Height(200),

                ui.Headline("Remarks"),
                ui.Label("To load svg grapics you need to initialize the renderer wit SvgImageRenderer.Init(); " +
                         "after calling Xamarin.Forms.Init(); on each plattform."),
                ui.Label("Also note that the svg library is a bit picky with the size definition inside the svg. " +
                         "make sure the size parameters are definded in px not mm or someting else.")
            )));
        }
    }
}
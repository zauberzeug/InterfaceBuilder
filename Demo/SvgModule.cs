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
                ui.Label("To load svg grapics you need to initialize the renderer with " +
                         "FFImageLoading.Forms.Platform.CachedImageRenderer.Init(); " +
                         "after calling Xamarin.Forms.Init(); on each plattform. "),
                ui.Label("Sometimes svg's are not well formed and need to be cleand " +
                         "(for example with console tool svgo: https://github.com/svg/svgo)")
            )));
        }
    }
}
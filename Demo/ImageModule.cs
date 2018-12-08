using System;
using InterfaceBuilder;
using Xamarin.Forms;

namespace Demo
{
    public class ImageModule : Module
    {
        UI ui;

        public ImageModule(UI ui) : base(ui)
        {
            this.ui = ui;

            Page = ui.NavigationPage(
                ui.Page("Images",
                    ui.Stack().With(
                        ui.Box().FillVertical(),
                        ui.Label("Designed by Starline / Freepik:"),
                        ui.Image("loremipsum.jpg")
                    ).Background(Color.FromRgb(250, 250, 248))
               ).WithoutSafeAreas()
            );
        }
    }
}
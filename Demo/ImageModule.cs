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
            Icon = IconName.Picture;

            Page = ui.NavigationPage(
                ui.ScrollPage("Images",
                    ui.Stack().With(
                        ui.Label("Add the images to your shared project and set 'Build Action' to EmbeddedRessource." +
                                 "\n\n" +
                                 "Also provide a 'Ressource ID' which you can then reference in UI.Image(string ressourceId)").
                                  FontSize(18).Margin(ui.Theme.Sizes.PageMargin),
                        ui.Box().FillVertical(),
                        ui.Label("Designed by Starline / Freepik:"),
                        ui.Image("loremipsum.jpg")
                    )
               ).Padding(0).Background(Color.FromRgb(250, 250, 248)).WithoutSafeAreas()
            );
        }
    }
}
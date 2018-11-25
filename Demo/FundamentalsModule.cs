using System;
using InterfaceBuilder;
using System.Linq;
using Xamarin.Forms;

namespace Demo
{
    public class FundamentalsModule : Module
    {
        UI ui;

        public FundamentalsModule(UI ui) : base(ui)
        {
            this.ui = ui;

            Page = ui.NavigationPage("Basic Demo", ui.Stack().With(

                ui.Headline("Some items in a StackLayout"),
                ui.Stack().With(
                    ui.Label("Item A"),
                    ui.Label("Item B"),
                    ui.Label("Item C")
                ),

                ui.Headline("FlexLayout with Boxes"),
                ui.Flex().Wrap().Margin(10, 0).JustifyFromStart().AlignFromStart().With(
                    new int[] { 1, 2, 3, 4, 5, 6 }.Select(CreateBox).ToArray()
                ),

                ui.Headline("Icons from www.elusiveicons.com"),
                ui.Flex().Margin(20).With(
                    new string[] {
                        IconName.AddressBook, IconName.Bookmark, IconName.Bulb,
                        IconName.Compass, IconName.Dashboard, IconName.Download
                    }.Select(ui.Icon).ToArray()
                ),
                ui.Label("Note: you need to add the Elusive-Icons.ttf font from the Demo to your App projects to activate them in your code").FontSize(10)
            ));
        }

        View CreateBox(int number)
        {
            var text = number.ToString();
            return ui.Frame(ui.Label(text).FontSize(20).Centered()).SquareByWidth().Width(70).Margin(5);
        }
    }
}

using System;
using InterfaceBuilder;
using System.Linq;
using Xamarin.Forms;
using System.Xml;

namespace Demo
{
    public class FundamentalsModule : Module
    {
        UI ui;
        private Label messageLabel;

        public FundamentalsModule(UI ui) : base(ui)
        {
            this.ui = ui;
            Icon = IconName.EyeOpen;

            var toolbarItem = new ToolbarItem("Demo", null, () => { });

            Page = ui.NavigationPage("Fundamentals", ui.Stack().With(

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
                ui.Label("Note: Add the Elusive-Icons.ttf from the Demo to your App").FontSize(10),

                ui.Headline("Tapable Views"),
                ui.Flex().Margin(20).With(
                    ui.Frame(ui.Label("Show Alert").Color(Color.GhostWhite)).NoBorder().Background(Color.DarkGray).
                        OnTap(() => Page.DisplayAlert("Alert", "A standard alert from Xamarin.Forms", "OK")),
                    ui.Label("Write Message").OnTap(() => Write("You can release now"), () => Write("press and hold"))
                ),

                ui.Headline("Messages"),
                messageLabel = ui.Label("the last tapable view changes this label"),
                ui.Entry("modify toolbar item").BindTo(toolbarItem, Entry.TextProperty, MenuItem.TextProperty)
            ));

            Page.ToolbarItems.Add(toolbarItem);
        }

        View CreateBox(int number)
        {
            var text = number.ToString();
            return ui.Frame(ui.Label(text).FontSize(20).Centered()).SquareByWidth().Width(70).Margin(5);
        }

        void Write(string msg) => messageLabel.Text(msg);
    }
}

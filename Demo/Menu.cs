using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InterfaceBuilder;
using Xamarin.Forms;

namespace Demo
{
    public class Menu
    {
        MasterDetailPage masterDetail;
        UI ui;

        public Page Page { get; private set; }

        public Menu(UI ui, MasterDetailPage masterDetail, IReadOnlyList<Module> modules)
        {
            this.ui = ui;
            this.masterDetail = masterDetail;

            Page = ui.Page("Menu", ui.Stack().Margin(0, 30).With(
                ui.Headline("InterfaceBuilder Demos"),
                ui.Stack().With(
                    modules.Select(m => CreateMenuItem(m)).ToArray()
                )
            ));

            masterDetail.Detail = modules[0].Page;
        }

        View CreateMenuItem(Module modul)
        {
            return ui.Action(GetTitle(modul.Page), modul.Icon).Margin(0, 10).
                     OnTap(async () => {
                         masterDetail.Detail = modul.Page;
                         masterDetail.IsPresented = false;
                         await Task.Delay(TimeSpan.FromMilliseconds(500));
                     });
        }

        string GetTitle(Page page)
        {
            if (page is NavigationPage)
                return (page as NavigationPage).CurrentPage.Title;
            return page.Title;
        }
    }
}

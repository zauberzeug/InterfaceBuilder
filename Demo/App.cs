using System.Collections.Generic;
using InterfaceBuilder;
using Xamarin.Forms;

namespace Demo
{
    public class App : Application
    {
        public App()
        {
            var ui = new UI();

            var modules = new List<Module> {
                new FundamentalsModule(ui),
                new ImageModule(ui),
                new WebModule(ui),
                new SvgModule(ui),
            };

            var masterDetail = new MasterDetailPage();
            masterDetail.Master = new Menu(ui, masterDetail, modules).Page;
            MainPage = masterDetail;
        }
    }
}

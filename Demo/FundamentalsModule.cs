using System;
using InterfaceBuilder;

namespace Demo
{
    public class FundamentalsModule : Module
    {
        public FundamentalsModule(UI ui) : base(ui)
        {
            Page = ui.NavigationPage("Basic Demo", ui.Label("test"));
        }
    }
}

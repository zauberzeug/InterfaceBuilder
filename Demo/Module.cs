using System;
using InterfaceBuilder;
using Xamarin.Forms;

namespace Demo
{
    public abstract class Module
    {
        public Page Page { get; protected set; }

        public UI UI { get; private set; }

        public string Icon = IconName.InfoCircle; // default icon

        protected Module(UI ui) => UI = ui;
    }
}

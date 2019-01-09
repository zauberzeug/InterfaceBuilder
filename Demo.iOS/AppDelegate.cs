using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using UIKit;

namespace Demo.iOS
{
    // The UIApplicationDelegate for the application. This class is responsible for launching the 
    // User Interface of the application, as well as listening (and optionally responding) to 
    // application events from iOS.
    [Register("AppDelegate")]
    public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
    {
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            global::Xamarin.Forms.Forms.Init();
            SVG.Forms.Plugin.iOS.SvgImageRenderer.Init();

            LoadApplication(new App());

            // https://stackoverflow.com/a/17665159/364388
            foreach (var family in UIFont.FamilyNames)
                foreach (var name in UIFont.FontNamesForFamilyName(family))
                    Console.WriteLine(family + ": " + name);

            return base.FinishedLaunching(app, options);
        }
    }
}

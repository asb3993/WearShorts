// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace WearShorts
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel infoLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIImageView outcomeImage { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel outcomeLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton settingsButton { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (infoLabel != null) {
                infoLabel.Dispose ();
                infoLabel = null;
            }

            if (outcomeImage != null) {
                outcomeImage.Dispose ();
                outcomeImage = null;
            }

            if (outcomeLabel != null) {
                outcomeLabel.Dispose ();
                outcomeLabel = null;
            }

            if (settingsButton != null) {
                settingsButton.Dispose ();
                settingsButton = null;
            }
        }
    }
}
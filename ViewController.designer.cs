// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
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
        UIKit.UIButton decideButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIImageView outcomeImage { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel outcomeLabel { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (decideButton != null) {
                decideButton.Dispose ();
                decideButton = null;
            }

            if (outcomeImage != null) {
                outcomeImage.Dispose ();
                outcomeImage = null;
            }

            if (outcomeLabel != null) {
                outcomeLabel.Dispose ();
                outcomeLabel = null;
            }
        }
    }
}
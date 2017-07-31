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
    [Register ("SettingsViewController")]
    partial class SettingsViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UISlider thresholdControl { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel thresholdLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UISegmentedControl unitControl { get; set; }

        [Action ("ThresholdChanged:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void ThresholdChanged (UIKit.UISlider sender);

        [Action ("UnitChanged:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void UnitChanged (UIKit.UISegmentedControl sender);

        void ReleaseDesignerOutlets ()
        {
            if (thresholdControl != null) {
                thresholdControl.Dispose ();
                thresholdControl = null;
            }

            if (thresholdLabel != null) {
                thresholdLabel.Dispose ();
                thresholdLabel = null;
            }

            if (unitControl != null) {
                unitControl.Dispose ();
                unitControl = null;
            }
        }
    }
}
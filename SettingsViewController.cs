using Foundation;
using System;
using UIKit;

namespace WearShorts
{
    public partial class SettingsViewController : UIViewController
    {

        public SettingsViewController (IntPtr handle) : base (handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            SetThresholdValues();

            var currentUnit = Settings.TempUnit;

            unitControl.SelectedSegment = (nint)((int)currentUnit);

			thresholdControl.Value = Settings.ThresholdTemp;
			thresholdLabel.Text = Settings.ThresholdTemp.ToString() + "°";
        }

        partial void UnitChanged(UISegmentedControl sender)
        {
            SetThresholdValues();

            var index = unitControl.SelectedSegment;
            Settings.TempUnit = (Settings.Unit)((int)index);

        }

        partial void ThresholdChanged(UISlider sender)
        {
            thresholdLabel.Text = ((int)(thresholdControl.Value)).ToString() + "°";

            Settings.ThresholdTemp = (int)thresholdControl.Value;

        }

        void SetThresholdValues()
        {

			if (Settings.TempUnit == Settings.Unit.Celcius)
			{
                thresholdControl.MaxValue = 50f;
				thresholdControl.MinValue = 0f;
			}
			else if (Settings.TempUnit == Settings.Unit.Fahrenheit)
			{
				thresholdControl.MaxValue = 125f;
				thresholdControl.MinValue = 32f;
			}



            thresholdLabel.Text = ((int)(thresholdControl.Value)).ToString() + "°";
        }
		
    }
}
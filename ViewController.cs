using System;

using UIKit;
using ForecastIOPortable;
using ForecastIOPortable.Models;

namespace WearShorts
{
	public partial class ViewController : UIViewController
	{
		protected ViewController (IntPtr handle) : base (handle)
		{
			// Note: this .ctor should not contain any initialization logic.
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			// Perform any additional setup after loading the view, typically from a nib.

			decideButton.TouchUpInside += (object sender, EventArgs args) => {
				LocationHelper.StartLocationManager ();
				GetForcast ();
			};
		}

		public override void DidReceiveMemoryWarning ()
		{
			base.DidReceiveMemoryWarning ();
			// Release any cached data, images, etc that aren't in use.
		}

		async System.Threading.Tasks.Task<Forecast> GetForcast ()
		{

			var client = new ForecastApi ("3564a52abf36be15146ffd6536810fc0");
			Forecast result = await client.GetWeatherDataAsync (41.3851, 2.1734);
			var temp = result.Currently.Temperature;

			if (temp < 65) {
				outcomeLabel.Text = $"Not today, it's a cool {temp.ToString ()}\u2109 right now";
				outcomeImage.Image = UIImage.FromFile ("women-scarf.jpg");
			} else if (temp >= 65) {
				outcomeLabel.Text = $"Totes! It's a sweaty {temp.ToString ()}\u2109 right now";
				outcomeImage.Image = UIImage.FromFile ("women-shorts.jpg");
			}



			return result;
		}
	}
}


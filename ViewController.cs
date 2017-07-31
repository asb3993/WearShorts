using System;

using UIKit;
using DarkSky;
using DarkSky.Models;
using DarkSky.Services;
using DarkSky.Extensions;
using System.Threading.Tasks;
using Foundation;

namespace WearShorts
{
	public partial class ViewController : UIViewController
	{
        DarkSkyService darkSkyService = new DarkSkyService("3564a52abf36be15146ffd6536810fc0");

        protected ViewController (IntPtr handle) : base (handle)
		{
			// Note: this .ctor should not contain any initialization logic.
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

            GetForcast(Settings.TempUnit);
		}

        async Task<DarkSkyResponse> GetForcast(Settings.Unit unit) 
		{
			//find location
			var location = LocationHelper.StartLocationManager();

			var lat = Convert.ToDouble(location.Coordinate.Latitude);
			var lon = Convert.ToDouble(location.Coordinate.Longitude);

			//setting forecast to Current Location
            var forecast = await darkSkyService.GetForecast(lat, lon);

            //Threshold as set by the slider in settings
            nint threshold = Settings.ThresholdTemp;

            var unitMarker = "F";

            if (unit == Settings.Unit.Celcius){
                forecast = await darkSkyService.GetForecast(lat, lon, new DarkSkyService.OptionalParameters { 
                MeasurementUnits = "si"
                });
                unitMarker = "C";
            } else if (unit == Settings.Unit.Fahrenheit){
                forecast = await darkSkyService.GetForecast(lat, lon);
            }

			var currentTemp = forecast.Response.Currently.ApparentTemperature;

            Settings.CurrentTemp = (int)currentTemp;

			var forecastSummary = forecast.Response.Currently.Summary;

            if (currentTemp >= threshold)
			{
                View.BackgroundColor = UIColor.FromRGB(0.91f, 0.59f, 0.44f);
                outcomeLabel.Text = "Yes! It's warm today.";
                infoLabel.Text = $"Right now it is {currentTemp.ToString()}" + unitMarker + " and today's forcast is: " + forecastSummary;
				outcomeImage.Image = UIImage.FromBundle("shorts");
			}
            else if (currentTemp < threshold)
			{
                View.BackgroundColor = UIColor.FromRGB(0.44f, 0.73f, 0.91f);
				outcomeLabel.Text = "No, It's too cold for shorts.";
                infoLabel.Text = $"Right now it is {currentTemp.ToString()}" + unitMarker + " and today's forcast is: " + forecastSummary;
				outcomeImage.Image = UIImage.FromBundle("pants");
			}
			return forecast;
		}

        public override void DidReceiveMemoryWarning ()
		{
			base.DidReceiveMemoryWarning ();
			// Release any cached data, images, etc that aren't in use.
		}

        [Action("UnwindToMainViewController:")]
        public void UnwindToMainViewController(UIStoryboardSegue segue)
        {
            GetForcast(Settings.TempUnit);
        }

	}
}


using System;
using CoreLocation;
using UIKit;

namespace WearShorts
{
	public class LocationHelper
	{
		public static CLLocationManager LocationManager { get; private set; }

		public LocationHelper ()
		{
		}

		public static void StartLocationManager ()
		{

			LocationManager = new CLLocationManager ();

			if (UIDevice.CurrentDevice.CheckSystemVersion (8, 0)) {
				LocationManager.RequestWhenInUseAuthorization ();
			}

			LocationManager.DesiredAccuracy = 1000;

			LocationManager.LocationsUpdated += delegate (object sender, CLLocationsUpdatedEventArgs e) {
				foreach (CLLocation l in e.Locations) {
					Console.WriteLine (l.Coordinate.Latitude.ToString () + ", " + l.Coordinate.Longitude.ToString ());
				}
			};

			LocationManager.StartUpdatingLocation ();

			var lat = LocationManager.Location.Coordinate.Latitude.ToString ();
			var lon = LocationManager.Location.Coordinate.Longitude.ToString ();

			Console.WriteLine (lat, lon);
		}

	}
}


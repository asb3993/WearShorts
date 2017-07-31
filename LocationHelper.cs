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

        public static CLLocation StartLocationManager ()
		{

			LocationManager = new CLLocationManager ();

			if (UIDevice.CurrentDevice.CheckSystemVersion (8, 0)) {
				LocationManager.RequestWhenInUseAuthorization ();
			}

			LocationManager.DesiredAccuracy = 1000;

            return LocationManager.Location;
		}

	}
}


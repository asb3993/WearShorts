using System;
namespace WearShorts
{
    public static class Settings
    {

        public static Unit TempUnit { get; set; } = Unit.Celcius;

        public static int ThresholdTemp { get; set; }

        public static int CurrentTemp { get; set; }

        public enum Unit
		{
			Celcius = 0,
			Fahrenheit = 1
		}

        static Settings(){
            if (TempUnit == Settings.Unit.Celcius)
			{
                ThresholdTemp = 20;
			}
			else if (TempUnit == Settings.Unit.Fahrenheit)
			{
                ThresholdTemp = 70;
			}
        }

    }
}

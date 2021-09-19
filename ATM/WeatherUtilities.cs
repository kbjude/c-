using System;

namespace WeatherUtilities
    {

        class WeatherUtilities
        {
            static float FahrenheightToCelsius(float temperatureFahrenheight)
            {
                //infering
                var temperatureCelsius = (temperatureFahrenheight - 32) / 1.8f;
                return temperatureCelsius;
                //here 
            }

            static float CelsiusToFahrenheight(float temperatureCelcius)
            {
                //infering
                var temperatureFahrenheight = temperatureCelcius * 1.8f + 32;
                return temperatureFahrenheight;
                //here 
            }

            static float ComfortIndex(float temperatureFahrenheight, float humidityPercent)
            {
                //Need a to improve this formula
                //var comfortIndex = (temperatureFahrenheight * humidityPercent) / 4;
                //We could actually return the result straight away like it have refacted to the code below
                return (temperatureFahrenheight * humidityPercent) / 4;
                //here 
            }

            static void Report(string location, float temperatureCelicius, float humidity)
            {
            //infering
            var temperatureFahrenheight = CelsiusToFahrenheight(temperatureCelicius);
            Console.WriteLine("Comfort Index for " + location + ": " + ComfortIndex(temperatureFahrenheight, humidity));
                //here 
            }

    }
}
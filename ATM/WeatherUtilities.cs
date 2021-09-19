using System;

namespace WeatherUtilities
    {

        class WeatherUtilities
        {
            static public float FahrenheightToCelsius(float temperatureFahrenheight)
            {
            //infering
            return (temperatureFahrenheight - 32) / 1.8f;
                //here 
            }

            static public float CelsiusToFahrenheight(float temperatureCelcius)
            {
            //infering
            return temperatureCelcius * 1.8f + 32;
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

            static public void Report(string location, float temperatureCelicius, float humidity)
            {
            //infering
            var temperatureFahrenheight = CelsiusToFahrenheight(temperatureCelicius);
            Console.WriteLine($"Comfort Index for {location}: {ComfortIndex(temperatureFahrenheight, humidity)}");
                //here 
            }

    }
}
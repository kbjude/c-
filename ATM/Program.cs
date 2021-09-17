using System;

namespace ATM
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        static float FahrenheightToCelsius(float temperatureFahrenheight)
        {
            float temperatureCelsius = (temperatureFahrenheight - 32) / 1.8f;

                return temperatureCelsius;

        }
    }
}

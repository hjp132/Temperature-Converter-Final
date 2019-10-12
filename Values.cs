using System;
using System.Collections.Generic;


namespace temperature_remaster
{
    public class Values
    {
        public static void CelsiusConverterValues()
        {
            string message = "\nYou've entered the value: " + menu.userInput + "°C.\n";
			Console.WriteLine(message);
            CelsuisToKelvin();
            CelsuisToFahrenheit();


     
        }
        public static void CelsuisToKelvin()
		{
			// the formula used to convert Celsius to kelvin
			Program.kelvin = (menu.userInput + 273.15);
			string message = "In Kelvin thats: " + Program.kelvin + "K";
			// writes the converted amount to console
			Console.WriteLine(message);
		}
        public static void CelsuisToFahrenheit()
		{
			// the formula used to convert Celsius to Fahrenheit
			Program.fahrenheit = (menu.userInput * 9) / 5 + 32;
			string message = "In Fahrenheit thats: " + Program.fahrenheit + "°F";
			// writes the converted amount to the console
			Console.WriteLine(message);
		}

        

        public static void FahrenheitConverterValues()
		{
			// prints what the user inputted to the console
			string message = "\nYou've entered the value: " + menu.userInput + "°F.\n";
			Console.WriteLine(message);
			// runs the FahrenheitToCelsius, FahrenheitToKelvin methods
			FahrenheitToCelsius();
			FahrenheitToKelvin();
		}
		public static void FahrenheitToCelsius()
		{
			//the formula used to convert fahrenheit to celsius
			Program.celsius = (menu.userInput - 32) * 5 / 9;
			string message = "In Celsius thats: " + Program.celsius + "°C";
			// writes the converted amount to the console
			Console.WriteLine(message);
		}
		public static void FahrenheitToKelvin()
		{
			// the formula used to conver fahrenheit to kelvin
			Program.kelvin = (menu.userInput - 32) * 5 / 9 + 273.15;
			string message = "In Kelvin thats: " + Program.kelvin + "°K";
			// writes the converted amount to the console
			Console.WriteLine(message);
		}

        public static void KelvinConverterValues()
        {
            string message = "\nYou've entered the value: " + menu.userInput + "K.\n";
			Console.WriteLine(message);
            KelvinToCelsius();
            KelvinToFahrenheit();
        }

        public static void KelvinToCelsius()
		{
			// the formula for converting to celsius
			Program.celsius = (menu.userInput - 273.15);
			string message = "In Celsius thats: " + Program.celsius + "°C";
			// writes the converted amount to the console
			Console.WriteLine(message);
		}
		public static void KelvinToFahrenheit()
		{
			// the formula for converting to fahrenheit
			Program.fahrenheit = (menu.userInput - 273.15) * 9 / 5 + 32;
			string message = "In Fahrenheit thats: " + Program.fahrenheit + "°F";
			// writes the converted amount to the console
			Console.WriteLine(message);
		}



    }
}

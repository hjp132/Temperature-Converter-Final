using System;

namespace temperature_remaster
{
    class Program
    {
        public static double fahrenheit, kelvin, celsius;
        static void Main(string[] args)
        {
            menu.Menu();
        }
    }

    public class methodLib
    {
        public static int GetUserInputByte(string message)
		{
			Console.Write(message);
			return Convert.ToInt32(Console.ReadLine());
		}

        public static void Quit()
		{
			Console.WriteLine("\nThank you for using the temperature conversion application.\n");
			// quits the application
			System.Environment.Exit(1);
		}
        public static void valueInput()
		{
			// takes the pre-existing userInput as well as the GetuserInputByte, as this line is used at multiple points I decided to make a method for it
			menu.userInput = GetUserInputByte("\nPlease enter a value to convert:\n");
		}
    }
}

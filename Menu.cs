using System;
using System.Collections.Generic;

namespace temperature_remaster
{
    public class menu
    {
        public static double userInput;
        public static void Menu()
        {
           
        
            Console.WriteLine("\n/-/ Temperature Converter\n");


            Dictionary<int, string> dict = new Dictionary<int, string>()
                                            {
                                                {1,"Fahrenhiet"},
                                                {2,"Celsius"},
                                                {3,"Kelvin"},
                                                {4,"Quit"}
                                            };

            foreach (KeyValuePair<int, string> item in dict)
            {
                Console.WriteLine("Key: {0}, Type: {1}", item.Key, item.Value);
            }

            userInput = MethodLib.GetUserInputByte("Please choose an item to convert\n");

            do
            {
                switch (userInput)
                {
                    case 1:
                        Converter.FahrenheitConverter();
                    

                        break;
                    
                    case 2:
                        Converter.CelsiusConverter();

                        break;

                    case 3:
                        Converter.KelvinConverter();

                        break;

                    case 4:
                        MethodLib.Quit();
                        break;
                }
                
                Console.ReadKey();
                menu.Menu();
                

            } while (userInput != 4);



        
 

       
        }
        
    }
}

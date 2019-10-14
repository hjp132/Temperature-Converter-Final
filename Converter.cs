using System;
using System.Collections.Generic;


namespace temperature_remaster
{
    public class Converter
    {
        
        public static void CelsiusConverter()
        {
            MethodLib.valueInput();
            Celsius.ConverterValues();
            
        }

        public static void FahrenheitConverter()
        {
            MethodLib.valueInput();
            Fahrenheit.ConverterValues();

        }

        public static void KelvinConverter()
        {
            MethodLib.valueInput();
            Kelvin.ConverterValues();
        }


        

    }
}

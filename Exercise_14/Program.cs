using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Exercise14
{
    /* 
     * 14. Write a C# program to convert from celsius degrees to Celsius and Fahrenheit. 
     */
    internal class TempratureConverter
    {
        public static float ToCelsius(float fahrenheit)
        {
            return (fahrenheit - 32) / 1.8f;
        }
        public static float ToFahrenheit(float celsius)
        {
            return celsius * 1.8f + 32;
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Temprature Converter\n");
            
            
            while (true)
            {
                Console.Write("°F ");
                float.TryParse(Console.ReadLine(), out float inputFahrenheit);
                Console.WriteLine("°C " + ToCelsius(inputFahrenheit));

                Console.ReadKey();
                Console.Clear();

                Console.Write("°C ");
                float.TryParse(Console.ReadLine(), out float inputCelsius);
                Console.WriteLine("°F " + ToFahrenheit(inputCelsius));

                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
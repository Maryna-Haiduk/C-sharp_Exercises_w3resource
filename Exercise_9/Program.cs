using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace array
{
    /* 
     * 9. Write a C# Sharp program that takes four numbers as input to calculate and print the average.
     */
    internal class Program
    {
        public static int AverageValue(int num1, int num2, int num3, int num4)
        {
            return (num1 + num2 + num3 + num4) / 4;
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Write first number: ");
            int.TryParse(Console.ReadLine(), out int num1);

            Console.WriteLine("Write second number: ");
            int.TryParse(Console.ReadLine(), out int num2);

            Console.WriteLine("Write third number: ");
            int.TryParse(Console.ReadLine(), out int num3);

            Console.WriteLine("Write fourth number: ");
            int.TryParse(Console.ReadLine(), out int num4);

            
            Console.WriteLine($"\nAvarage value of {num1}, {num2}, {num3}, {num3} is: {AverageValue(num1, num2, num3, num4)}");

        }
    }
}
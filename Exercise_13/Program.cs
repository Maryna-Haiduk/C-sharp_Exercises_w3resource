using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Exercise13
{
    /* 
     * 13. Write a C# program that takes a number as input 
     * and then displays a rectangle of 3 columns wide and 5 rows tall using that digit. 
     */
    internal class Program
    {
        public static void Rectangle(string x)
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"{x}{x}{x}");
            }
        }

        public static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Write any symbol: ");

                string inputSymbol = Console.ReadLine();
                Rectangle(inputSymbol);

                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
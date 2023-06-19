using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_20
{
    /* 
     * 20. Write a C# program to get 
     * the absolute value of the difference between two given numbers. 
     * Return double the absolute value of the difference
     * if the first number is greater than second number.
     */
    internal class Program
    {
        public static void Main(string[] args)
        {
            Int32.TryParse(Console.ReadLine(), out int num1);
            Int32.TryParse(Console.ReadLine(), out int num2);

            Console.WriteLine(TwoNumCompare(num1, num2));
        }

        public static int TwoNumCompare(int x, int y)
        {
            if (x > y)
            {
                return (x - y) * 2;
            }

            else
            {
                return y - x;
            }
        }
    }
}
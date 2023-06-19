using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace array
{
    /* 
     * 7. Write a C# Sharp program to print on screen the output of 
     * adding
     * subtracting
     * multiplying
     * dividing 
     * of two numbers which will be entered by the user
     */
    internal class Program
    {
        public static void Calculate(double a, double b)
        {
            Console.WriteLine($"{a} + {b} = {a + b}");
            Console.WriteLine($"{a} - {b} = {a - b}");
            Console.WriteLine($"{a} * {b} = {a * b}");
            Console.WriteLine($"{a} / {b} = {a / b}");
            Console.WriteLine($"{a} % {b} = {a % b}");

        }
        public static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter first number: ");
                double num1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter second number: ");
                double num2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine();

                Calculate(num1, num2);

                Console.ReadLine();
                Console.Clear();
            }
        }
    }
}
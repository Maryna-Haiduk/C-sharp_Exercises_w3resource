using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace array
{
    /* 
     * 8. Write a C# Sharp program that takes a number as input and print its multiplication table
     */
    internal class Program
    {
        public static void MultiplicationTable(int x)
        {
            Console.WriteLine($"{x} * {1} = {x * 1}");
            Console.WriteLine($"{x} * {2} = {x * 2}");
            Console.WriteLine($"{x} * {3} = {x * 3}");
            Console.WriteLine($"{x} * {4} = {x * 4}");
            Console.WriteLine($"{x} * {5} = {x * 5}");
            Console.WriteLine($"{x} * {6} = {x * 6}");
            Console.WriteLine($"{x} * {7} = {x * 7}");
            Console.WriteLine($"{x} * {8} = {x * 8}");
            Console.WriteLine($"{x} * {9} = {x * 9}");
            Console.WriteLine($"{x} * {10} = {x * 10}");
    
        }
        public static void Main(string[] args)
        {
            while(true)
            {
                Console.WriteLine("Write your number (from 1 to 999) for multiplication table: ");

                int.TryParse(Console.ReadLine(), out int inputNumber);

                if (inputNumber == 0 || inputNumber > 999)
                {
                    Console.WriteLine("\nPlease, press 'Enter' and after write another number: ");
                }

                else
                {
                    Console.WriteLine();

                    MultiplicationTable(inputNumber);

                    Console.WriteLine();
                    Console.WriteLine("\nPlease, press 'Enter': ");
                }
                
                Console.ReadLine();
                Console.Clear();
            }
        }
    }
}
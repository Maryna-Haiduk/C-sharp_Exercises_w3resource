using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Exercise12
{
    /* 
     * 12. Write a C# program to that takes a number as input 
     * and display it four times in a row (separated by blank spaces), 
     * and then four times in the next row, with no separation. 
     * You should do it two times: Use Console. Write and then use {0}.
     */
    internal class Program
    {        
        public static int InputNumber()
        {
            Console.Write("Enter a digit: ");
            int.TryParse(Console.ReadLine(), out int inputNum);
            return inputNum;
        }

        public static void Main(string[] args)
        {
            while (true)
            {
                int x = InputNumber();
                Console.WriteLine("\n{0} {0} {0} {0}\n{0}{0}{0}{0}\n{0} {0} {0} {0}\n{0}{0}{0}{0}", x);

                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
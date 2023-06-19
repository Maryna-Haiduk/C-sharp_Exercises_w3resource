using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_25
{
    /* 
     * 25. Write a C# program to print the 
     * odd numbers from 1 to 99. 
     * Prints one number per line.
     */
    internal class Program
    {
        public static void Main(string[] args)
        {
            GetOddNumbers(1, 10);
            Console.WriteLine();
            GetEvenNumbers(555, 2876);
        }

        public static void GetOddNumbers (int start, int finish)
        {
            for (int i = start; i <= finish; i++)
            {
                if ( i % 2 == 0)
                { continue; }

                Console.WriteLine(i);
            }
        }

        public static void GetEvenNumbers(int start, int finish)
        {
            for (int i = start; i <= finish; i++)
            {
                if (i % 2 != 0) 
                { continue; }

                Console.WriteLine(i);
            }
        }
    }
}
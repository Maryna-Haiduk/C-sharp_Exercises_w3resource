using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_19
{
    /* 
     * Write a C# program to compute 
     * the sum of two given integers, 
     * if two values are equal then return the triple of their sum. 
     */
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(SumIf(3, 4));
        }

        public static int SumIf(int x, int y)
        {
            if (x == y)
            {
                return x * 3;
            }
            else
            {
                return x + y;
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_21
{
    /* 
     * 21. Write a C# program to check the sum of the 
     * two given integers and return 
     * true if one of the integer is 20 or if their sum is 20.
     */
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(CheckSum(11, 9));
        }

        public static bool CheckSum(int x, int y)
        {
            if (x == 20 || y == 20) return true;
            else if (x + y == 20) return true;
            else return false;
        }
    }
}
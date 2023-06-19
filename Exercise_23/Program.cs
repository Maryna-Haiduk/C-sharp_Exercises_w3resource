using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_23
{
    /* 
     * 23. Write a C# program to convert a given string into lowercase.
     */
    internal class Program
    {
        public static void Main(string[] args)
        {
            string s = Console.ReadLine();
            Console.WriteLine(Lowercase(s));
            Console.WriteLine(Uppercase(s));

        }

        public static string Lowercase(string str)
        {
            return str.ToLower();
        }
        public static string Uppercase(string str)
        {
            return str.ToUpper();
        }
    }
}
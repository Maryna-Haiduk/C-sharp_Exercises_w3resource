using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_16
{
    /* 16. Write a C# program to create a new string 
     * from a given string where the first and last characters 
     * will change their positions.
     */
    public class Program
    {
        public static void Main(string[] arg)
        {
            string str = Console.ReadLine();
            Console.WriteLine(FirstLastReverse(str));
        }

        public static string FirstLastReverse(string s)
        {
            //string firstChar = s.Substring(0, 1);
            //string lastChar = s.Substring(s.Length - 1);
            //string midleChars = s.Substring(1, s.Length - 2);
            //string reverseResult = lastChar + midleChars + firstChar;
            //return reverseResult;

            s = s.Substring(s.Length - 1) + s.Substring(1, s.Length - 2) + s.Substring(0, 1);

            return s;
        }
    }
}
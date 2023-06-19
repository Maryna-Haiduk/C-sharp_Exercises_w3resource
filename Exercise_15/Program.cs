using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Exercise15
{
    /* 
     * 15.  Write a C# program remove specified a character from a non-empty string using index of a character. 
     */
    public class Exercise15
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write your text: ");
            
            string inputString = Console.ReadLine();

            Console.WriteLine(RemoveChar(inputString, 1));
            Console.WriteLine(RemoveChar(inputString, 3));
            Console.WriteLine(RemoveChar(inputString, 0));
            
        }

        public static string RemoveChar(string str, int x)
        {
            return str.Remove(x, 1);
        }
        
    }
}
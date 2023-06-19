using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_22
{
    /* 
     * 22. Write a C# program to check if an given integer 
     * is within 20 of 100 or 200.
     */
    internal class Program
    {
        public static void Main(string[] args)
        {
        }

        public static bool ResultCheck(int x)
        {
            if (Math.Abs(x - 100) <= 20 || Math.Abs(x - 200) <= 20)
                return true;
            return false;
        }
    }
}
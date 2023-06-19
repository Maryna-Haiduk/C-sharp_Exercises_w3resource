using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_18
{
    // 18. Write a C# program to check
    // two given integers and
    // return true if one is negative and one is positive.
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(TwoNum(0, -7));
        }   
        
        public static bool TwoNum (int x, int y)
        {
            bool check = false;
            
            if (x < 0 && y >= 0 || x >= 0 && y < 0)
            { 
                check = true; 
            }
            
            return check;
        }
  
    }

}
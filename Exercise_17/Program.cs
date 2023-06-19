using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Text;


namespace Exercise_17
{
    // 17. Write a C# program to create a new string
    // from a given string (length 1 or more )
    // with the first character
    // added at the front and back. 
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            Console.WriteLine(FirstChAdded(str));
        }
        public static string FirstChAdded(string s)
        {
            s = s.Substring(0, 1) + s + s.Substring(0, 1);
            return s;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_24
{
    /* 
     * 24. Write a C# program to find the longest word in a string.
     */
    internal class Program
    {
        public static void Main(string[] args)
        {
            string mainString = "I love Oleksyii";
            string inputStirg = Console.ReadLine();
            Console.WriteLine(LongestWord(inputStirg));
        }

        public static string LongestWord(string str)
        {
            string[] s = str.Split(' ');

            int count = 0;
            string word = null;

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i].Length > count)
                {
                    word = s[i];
                    count = s[i].Length;
                }
            }
            return word;
        }
    }
}
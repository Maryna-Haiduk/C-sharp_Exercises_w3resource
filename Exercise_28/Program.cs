using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_28
{
    /* 
     * 28. Write a C# program to reverse the words of a sentence. Go to the editor
     * Sample Output:
     * Original String: Display the pattern like pyramid using the alphabet.
     * Reverse String: alphabet. the using pyramid like pattern the Display
     */
    internal class Program
    {
        public static void Main(string[] args)
        {
            string myText = "I Love Alex";
            string reverxe = ReverseSentence(myText);
            Console.WriteLine(reverxe);
        }

        public static string ReverseSentence(string s)
        {
            string[] str = s.Split(" ");
            var newsString = "";

            for (int i = str.Length - 1; i >= 0; i--)
            {
                newsString += str[i] + " ";
            }
            return newsString;
        }
    }
}
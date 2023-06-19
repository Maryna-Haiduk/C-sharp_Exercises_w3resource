using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Exercise11
{
    /* 
     * 11. Write a C# Sharp program that takes an age (for example 20) as input 
     * and prints something as "You look older than 20". 
     * Test Data:
     * Enter your age - 25
     * Expected Output:
     * You look older than 25
     */
    internal class Program
    {
        public static void AgeAsker()
        {
            Console.Write("Write your age: ");
            int.TryParse(Console.ReadLine(), out int age);
            
            if (age <= 0)
            {
                Console.WriteLine("Dude, according to the entered data, it turns out that you were not born yet, \nso stop pretending to be a fool and write your real age again))");
            }
            else if (age == 1 || age == 2 || age == 3 || age == 4 || age == 5 || age == 6 || age == 7 || age == 8 || age == 9 || age == 10 || age == 11)
            {
                Console.WriteLine("You are such a baby, you still need to grow up, you need to...");
            }
            else if (age == 12 || age == 13 || age == 14 || age == 15 || age == 16 || age == 17 || age == 18 || age == 19)
            {
                Console.WriteLine("And you are a teenager, everything is clear with you. Hi-Hi))");
            }
            
            else if (age == 100)
            {
                Console.WriteLine("Wow! That's cool! You are so old, but you are sitting in gadgets! Cool, cool!");
            }
            else if (age > 130)
            {
                Console.WriteLine("Not correct age!");
            }
            else 
            {
                Console.WriteLine("Sorry, but you look older :(");
            }
        }
        public static void Main(string[] args)
        {
            AgeAsker();
        }
    }
}
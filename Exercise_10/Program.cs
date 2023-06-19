using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Exercise10
{
    /* 
     * 10. Write a C# Sharp program to that takes
     * three numbers(x,y,z) as input 
     * and print the output of (x+y).z and x.y + y.z.
     */
    internal class Program
    {
        public static int MathOperation1(int x, int y, int z)
        {
            return (x + y) * z;
        }
        public static int MathOperation2(int x, int y, int z)
        {
            return (x * y) + (y * z);
        }

        public static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Input first number: ");
                int.TryParse(Console.ReadLine(), out int num1);

                Console.Write("Input second number: ");
                int.TryParse(Console.ReadLine(), out int num2);

                Console.Write("Input third number: ");
                int.TryParse(Console.ReadLine(), out int num3);

                Console.WriteLine($"\n(" +
                    $"{num1} + {num2}).{num3} = {MathOperation1(num1, num2, num3)}");
                Console.WriteLine($"" +
                    $"{num1}.{num2} + {num2}.{num3} = {MathOperation2(num1, num2, num3)}");

                Console.ReadLine();
                Console.Clear();
            }
        }
    }
}
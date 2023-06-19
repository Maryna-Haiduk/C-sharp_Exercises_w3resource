using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace for13
{
    
    public class Exercise_11
    {
     /* 11. Write a program in C# Sharp to make such a pattern like right angle triangle 
        with a number which will repeat a number in a row. Go to the editor
     */
        public static void Main(string[] arg)

        {
             Console.Write("Write number: ");
            int.TryParse(Console.ReadLine(), out int inputNum);
            Console.WriteLine();

            for (int i = 1; i <= inputNum; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }
             Console.ReadLine();
        }
    }
}

    /* 
     * FOR LOOPS
     */

        /* 10. Write a program in C# Sharp to display the pattern like right angle triangle with a number. Go to the editor
            The pattern like :
                1
                12
                123
                1234


        public static void Main(string[] arg)
        {
            Console.Write("Write number: ");
            int.TryParse(Console.ReadLine(), out int inputNum);

            Console.WriteLine();

            for (int i = 1; i <= inputNum; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }
        }
        */

        /*9. Write a program in C# Sharp to display the pattern like right angle triangle using an asterisk. 
        *
        **
        ***
        ****
        */

        /*
         * 
        public static void Main(string[] arg)
        {
            Console.Write("Write number: ");
            int.TryParse(Console.ReadLine(), out int inputNum);

            Console.WriteLine();

            for (int i = 0; i < inputNum; i++)
            {
                Console.Write("#");
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("+");
                }
                Console.WriteLine();
            }
        }
        */



        // 7. Write a program in C# Sharp to display the multiplication table vertically from 1 to n.
        /*public static void Main(string[] args)
        {
            Console.Write("Write number: ");
            int.TryParse(Console.ReadLine(), out int inputNum);

            Console.WriteLine();

            for (int i = 1; i <=10; i++)
            {
                Console.WriteLine();
                for (int j = 1; j <= inputNum; j++)
                {
                    Console.Write($"{i} * {j} = {i * j}, ");
                    
                }
                Console.WriteLine();
            }
        }

        */

        // 6. Write a program in C# Sharp to display the multiplication table of a given integer.
        /*  public static void Main(string[] args)
         {
             Console.Write("Write your input number: ");
             int.TryParse(Console.ReadLine(), out int inputNum);

             Console.WriteLine();

             for (int i = 1; i <= 10; i++)
             {
                 Console.WriteLine($"{inputNum} * {i} = {inputNum * i}");
             }
         }
        */




        //5. Write a program in C# Sharp to display the cube of the number up to given an integer. 
        /*
         * public static void Main(string[] args)
        {
            Console.Write("Write any ten numbers: ");
            int.TryParse(Console.ReadLine(), out int num);
            Console.WriteLine();

            int cub = 1;

            for (int i = 1; i <= num; i++)
            {
                Console.Write($"{i} input number: ");
                cub = i * i * i;
                Console.WriteLine($"Cub of = {cub}");
                     
            }
           
        }
        */















        /* 
         * public static void Main(string[] args)
        {
            Console.WriteLine("Write any ten numbers: ");

            int cub = 1;

            for (int i = 1; i <= 3; i++)
            {
                Console.Write($"\n{i} input number: ");
                int.TryParse(Console.ReadLine(), out int num);
                
                for (int j = 1; j <=1; j++)
                {
                    cub = num * num * num;
                    Console.WriteLine($"Cub of = {cub}");
                }        
            }
           
        }

         * public static void Main(string[] args)
        {
            Console.WriteLine("Write any ten numbers: ");

            

            for (int i = 1; i <= 10; i++)
            {
                Console.Write($"\n{i} input number: ");
                int.TryParse(Console.ReadLine(), out int num);
                int cub = num * num * num;
                Console.WriteLine($"Cub of {num} = {cub}");
            }
        }
         * 
         * 
         * 
         * public static void Main(string[] args)
         {

             Console.Write($"The 7 natural numbers is: ");

             for (int i = 1; i <= 7; i++)
             {
                 Console.Write($"{i} ");
             }


             int sum = 0;

             for (int i = 1; i <= 10; i++)
             {
                 sum += i;
             }
             Console.WriteLine($"\nThe sum of 7 natural numbers is: {sum}");
         }

          public static void Main(string[] args)
         {
             Console.WriteLine("Input the 10 numbers: \n");

             float sum = 0;
             for (int i = 1; i <=10; i++)
             {
                 Console.Write($"{i} number: ");
                 float.TryParse(Console.ReadLine(), out float num);
                 sum += num;
             }

             Console.WriteLine($"\nSum of your numbers is {sum}");
             Console.WriteLine($"The avarage of your numbers is {sum/10}");
         }
        */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_26
{
    /* 
     * 26. Write a C# program to compute the sum of the first 500 prime numbers.
     * NOT SOLVE
     */
    internal class Program
    {
        public static void Main(string[] args)
        {
            int result = SumPrimeNumbers(500);
            Console.WriteLine(result);

        }

        public static int SumPrimeNumbers(int primeCount)
        {
            int sum = 0;
            for (int i = 2; i < primeCount; i++)
            {
                if(isPrime(i))
                {
                    sum += i;
                }
                  

            }

            return sum;
        }
        public static bool isPrime(int n)
        {
            int x = (int)Math.Floor(Math.Sqrt(n));

            if (n == 1) return false;
            if (n == 2) return true;

            for (int i = 2; i <= x; ++i)
            {
                if (n % i == 0) return false;
            }

            return true;
        }
    }
}
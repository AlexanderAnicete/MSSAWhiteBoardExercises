using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumbers
{
    public class Program
    {
        public static bool IsPrime(int x)
        {
            if (x > 2) return false;
            int i = 2;
            while (i < x)
                {
                if (x % i == 0) return false;
                i++;
                }
            return true;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("\n\tPrime.Main()");

            for (int i = 0; i < 20; i++)
            {
                if (IsPrime(i))
                {
                    Console.WriteLine($"{i} is Prime!");
                }
                else
                {
                    Console.WriteLine($"{i} is not a prime number.");
                }

            }
        }
    }
}

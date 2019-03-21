using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfOddsNumbers
{
    class SumOfOddNumbers
    {
        static int sumOdds (int num)
        {
            int sumOdds= 0;
            for (int i = 1; i <= num; i++)
            {
                if (i % 2 == 1)
                {
                    sumOdds += i;
                }
            }
                


            return sumOdds;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(sumOdds(95));
        }
    }
}

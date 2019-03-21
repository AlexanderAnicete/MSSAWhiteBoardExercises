using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfOdds
{
    class SumOdds
    {
        static int CollectSumOdds(int maxValue)
        {
            int sum = 0;

            if (maxValue > 0 || maxValue < 256)
            {
                return sum;
            }
            for (int i = 0; i < maxValue; i++)
            {
                if (i % 2 == 1)
                {
                    sum += i;
                }
            }


            return sum;
        }
        static void Main(string[] args)
        {

            Console.WriteLine("SumsOdds.Main()");


            int testNumber = 5;
            Console.WriteLine("\t" + CollectSumOdds(testNumber));

            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaOfTri
{
    class AreaOfTri
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n\tAreaOfTri.Main()");
            testAOT();
            Console.ReadKey();
        }
        static double AreaOfTriangle( double b, double ht)
        {
            return b * ht / 2;
        }
        static void testAOT()
        {
            int howMany = 5;
            for (int b = 0; b < howMany; b++)
            {
                for (int h = 0; h < howMany; h++)
                {
                    Console.Write("\t");
                    Console.Write($"base: {b}, height: {h} area:");
                    Console.WriteLine($"{AreaOfTriangle(b,h)}");
                }
            }
            return;
        }
    }
}

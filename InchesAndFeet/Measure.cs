using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InchesAndFeet
{
    public class Measure
    {
        public static int FeetToInches(int feet)
        {
            return feet * 12;
        }
        public static double InchesToFeet(int inches)
        {
            return (double)inches / 12.0;
        }
        static void Main(string[] args)
        {

            Console.WriteLine("Measure Main()");

            Console.WriteLine(InchesToFeet(12));
            Console.WriteLine(InchesToFeet(48));
            Console.WriteLine(InchesToFeet(6));
            Console.ReadKey();
        }
    }
}

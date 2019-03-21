using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountOfVowels
{
    class Program
    {
        public static int countVowels(string input)
        {
            
            int vowels = 0;
            input = input.ToLower();
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == 'a' || input[i] == 'e' || input[i] == 'i' || input[i] == 'o' || input[i] == 'u')
                
                    vowels++;
                
                    
            }
            return vowels;
        }

        static void Main(string[] args)
        {
            Console.WriteLine($"the number of vowels  {countVowels("mississipi")} ");
        }
    }
}

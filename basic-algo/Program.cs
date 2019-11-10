using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basic_algo
{
    /*
     * data_types
        Write a C# Sharp program that takes a character as input and check the input (lowercase) is a vowel, a digit, or any other symbol.
    */

    public class Program
    {
        private static void Main(string[] args)
        {
            char symbol;
            List<char> vowels = new List<char>() { 'a', 'e', 'i', 'o', 'u' };
            Console.Write("Input a symbol: ");
            symbol = Convert.ToChar(Console.ReadLine());

            if (vowels.Contains(symbol))
                Console.WriteLine("It's a lowercase vowel.");
            else if ((symbol >= '0') && (symbol <= '9'))
                Console.WriteLine("It's a digit.");
            else
                Console.Write("It's another symbol.");
            Console.ReadKey();
        }
    }
}
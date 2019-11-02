using System;

namespace basic_algo
{
    /*
        Write a C# Sharp program to check whether two given integer values are in the range 20..50 inclusive.
        Return true if 1 or other is in the said range otherwise false.
    */

    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(test(20, 84));
            Console.WriteLine(test(14, 50));
            Console.WriteLine(test(11, 45));
            Console.WriteLine(test(25, 40));

            Console.ReadKey();
        }

        private static bool test(int x, int y)
        {
            return !(
                        (x >= 20 && x <= 50)
                            &
                        (y >= 20 && y <= 50)
                    );
        }
    }
}
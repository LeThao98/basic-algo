using System;

namespace basic_algo
{
    /*
         Write a C# Sharp program to count the string "aa" in a given string and assume "aaa" contains two "aa".
    */

    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(test("bbaaccaag"));
            Console.WriteLine(test("jjkiaaasew"));
            Console.WriteLine(test("JSaaakoiaa"));

            Console.ReadKey();
        }

        private static int test(string str)
        {
            int count = 0;
            for (int i = 1; i < str.Length - 1; i++)
            //{
            //    if (str[i] == 'a' && str[i - 1] == 'a')
            //        count++;
            //}
            {
                if (str.Substring(i, 2) == "aa")
                    count++;
            }
            return count;
        }
    }
}
using System;

namespace basic_algo
{
    /*
         Write a C# Sharp program to count a substring of length 2 appears in a given string and
         also as the last 2 characters of the string. Do not count the end substring.
    */

    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(test("abcdsab"));
            Console.WriteLine(test("abcdabab"));
            Console.WriteLine(test("abcabdabab"));
            Console.WriteLine(test("abcabd"));

            Console.ReadKey();
        }

        private static int test(string s)
        {
            int result = 0;
            string last2Chars = s.Substring(s.Length - 2);
            for (int i = 0; i < s.Length - 3; i++)
            {
                if (s.Substring(i, 2).Equals(last2Chars))
                    result++;
            }
            return result;
        }
    }
}
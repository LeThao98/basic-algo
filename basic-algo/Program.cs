using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basic_algo
{
    /*
        searching-and-sorting-algorithm: Permutation Sort
        Write a C# Sharp program to sort a list of elements using Permutation sort.
    */

    public class Program
    {
        private static void Main(string[] args)
        {
            //string str = "ABC";
            //char[] arr = str.ToCharArray();
            //GetPer(arr);

            int a = 4; int b = 5;
            a ^= b;
            b ^= a;
            a ^= b;
            Console.WriteLine("{0} {1}", a, b);

            Console.ReadKey();
        }

        private static void Swap(ref char a, ref char b)
        {
            if (a == b) return;

            a ^= b;
            b ^= a;
            a ^= b;
        }

        public static void GetPer(char[] list)
        {
            int x = list.Length - 1;
            GetPer(list, 0, x);
        }

        private static void GetPer(char[] list, int k, int m)
        {
            if (k == m)
            {
                {
                    Console.WriteLine(list);
                }
            }
            else
                for (int i = k; i <= m; i++)
                {
                    Swap(ref list[k], ref list[i]);
                    GetPer(list, k + 1, m);
                    Swap(ref list[k], ref list[i]);
                }
        }
    }
}
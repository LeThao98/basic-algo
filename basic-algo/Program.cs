using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basic_algo
{
    /*
        searching-and-sorting-algorithm: Merge Sort
        Write a C# Sharp program to sort a list of elements using Merge sort.
        O(nlogn)
    */

    public class Program
    {
        private static void Main(string[] args)
        {
            List<int> unsorted = new List<int>();
            List<int> sorted = new List<int>();

            Random random = new Random();
            Console.Write("Unsorted Array: ");
            for (int i = 0; i < 10; i++)
            {
                unsorted.Add(random.Next(0, 100));
                Console.Write("{0} ", unsorted[i]);
            }
            sorted = MergeSort(unsorted);
            Console.Write("\nSorted Array  : ");
            foreach (int item in sorted)
            {
                Console.Write("{0} ", item);
            }

            Console.ReadKey();
        }

        private static List<int> MergeSort(List<int> unsorted)
        {
            List<int> left = new List<int>();
            List<int> right = new List<int>();

            if (unsorted.Count == 1)
            {
                return unsorted;
            }

            int middle = unsorted.Count / 2;
            for (int i = 0; i < middle; i++)
            {
                left.Add(unsorted[i]);
            }
            for (int i = middle; i < unsorted.Count; i++)
            {
                right.Add(unsorted[i]);
            }

            left = MergeSort(left);
            right = MergeSort(right);
            return Merge(left, right);
        }

        private static List<int> Merge(List<int> left, List<int> right)
        {
            List<int> merged = new List<int>();
            while (left.Count > 0 || right.Count > 0)
            {
                if (left.Count > 0 && right.Count > 0)
                {
                    if (left.First() < right.First())
                    {
                        merged.Add(left.First());
                        left.RemoveAt(0);
                    }
                    else
                    {
                        merged.Add(right.First());
                        right.RemoveAt(0);
                    }
                }
                else if (left.Count > 0)
                {
                    merged.Add(left.First());
                    left.RemoveAt(0);
                }
                else if (right.Count > 0)
                {
                    merged.Add(right.First());
                    right.RemoveAt(0);
                }
                else return merged;
            }
            return merged;
        }
    }
}
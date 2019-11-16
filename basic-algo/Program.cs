using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basic_algo
{
    /*
        structure
        Write a program in C# Sharp to show what happen when a struct and a class instance is passed to a method.     */

    // crate a class
    internal class newClass
    {
        public int n;
    }

    internal struct newStruct
    {
        public int n;
    }

    public class Program
    {
        private static void trackStruct(newStruct st)
        {
            st.n = 1;
        }

        private static void trackClass(newClass cl)
        {
            cl.n = 1;
        }

        private static void Main(string[] args)
        {
            Console.Write("\n\nWhen a struct and a class instance is passed to a method :\n");
            Console.Write("--------------------------------------------------------------\n");
            newStruct ns = new newStruct();
            newClass nc = new newClass();
            ns.n = 5;
            nc.n = 5;
            //value of the struct field did not changed by passing its instance
            //because a copy of the struct was passed to the trackStruct method
            trackStruct(ns);
            //value of the class field changed by passing its instance
            //because a reference to the class was passed to the tracClass method
            trackClass(nc);
            Console.WriteLine("\nns.n = {0}", ns.n);
            Console.WriteLine("nc.n = {0}\n", nc.n);
            Console.ReadKey();
        }
    }
}
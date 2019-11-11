using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basic_algo
{
    /*
        conditional-statement
        Write a program in C# Sharp to calculate and print the Electricity bill of a given customer.
        The customer id., name and unit consumed by the user should be taken from the keyboard and display the total amount to pay to the customer. The charge are as follow:

                  Unit	                            Charge/unit
          upto 199	                             @1.20
          200 and above but less than 400	     @1.50
          400 and above but less than 600	     @1.80
          600 and above                      	 @2.00
         If bill exceeds Rs. 400 then a surcharge of 15% will be charged and the minimum bill should be of Rs. 100/-
    */

    public class Program
    {
        private static void Main(string[] args)
        {
            int custid, conu;
            double chg, surchg = 0, gramt, netamt;
            string connm;

            Console.Write("\n\n");
            Console.Write("Calculate Electricity Bill:\n");
            Console.Write("----------------------------");
            Console.Write("\n\n");

            Console.Write("Input Customer ID :");
            custid = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the name of the customer :");
            connm = Console.ReadLine();
            Console.Write("Input the unit consumed by the customer : ");
            conu = Convert.ToInt32(Console.ReadLine());
            if (conu < 200)
                chg = 1.20;
            else if (conu >= 200 && conu < 400)
                chg = 1.50;
            else if (conu >= 400 && conu < 600)
                chg = 1.80;
            else
                chg = 2.00;
            gramt = conu * chg;
            if (gramt > 300)
                surchg = gramt * 15 / 100.0;
            netamt = gramt + surchg;
            if (netamt < 100)
                netamt = 100;
            Console.Write("\nElectricity Bill\n");
            Console.Write("Customer IDNO                       :{0}\n", custid);
            Console.Write("Customer Name                       :{0}\n", connm);
            Console.Write("unit Consumed                       :{0}\n", conu);
            Console.Write("Amount Charges @Rs. {0}  per unit :{1}\n", chg, gramt);
            Console.Write("Surchage Amount                     :{0}\n", surchg);
            Console.Write("Net Amount Paid By the Customer     :{0}\n", netamt);
            Console.ReadKey();
        }
    }
}
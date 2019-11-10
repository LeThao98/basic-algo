using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basic_algo
{
    /*
     * data_types
        Write a C# Sharp program that takes userid and password as input (type string). After 3 wrong attempts, user will be rejected.
    */

    public class Program
    {
        private static void Main(string[] args)
        {
            int count = 1;          
            string right_username = "admin", right_password = "1234";
            bool result = false;
            do
            {
                Console.Write("Input a username: ");
                string username = Console.ReadLine();
                Console.Write("Input a password: ");
                string password = Console.ReadLine();
                count ++;
                if(username == right_username && password == right_password)
                    result = true;
            }
            while(count <= 3 && result != true);
            if(result == true){
                Console.Write("\nPassword entered successfull!\n\n");
            }
            else if(count > 3){
                Console.Write("\nLogin attemp more than three times. Try later!\n\n");
            }
            Console.ReadKey();
        }
    }
}
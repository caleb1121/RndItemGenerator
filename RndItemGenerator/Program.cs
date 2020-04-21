using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RndItemGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Sally's Store Of Random Apparatus v.0.11");
            Console.WriteLine("");

            // Main Menu
            Console.WriteLine("1. Generate Item");
            Console.WriteLine("2. Place Holder");
            Console.WriteLine("3. Leave The Store");

            String UserInput = Console.ReadLine(); // Save User input

            if (UserInput == "1") // Generate single item if user selects option 1
            {


            }

            else if(UserInput == "2") // Not finished
            {
                Console.WriteLine("Not finished fuck off!");
                

            }

            else // Quit the application
            {
                Environment.Exit(0);
            }


        }
    }
}

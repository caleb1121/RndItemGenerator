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
                Random rndNumber = new Random(); // random number
                int test = 0;


                while(test < 100)
                {
                    int rarityNumber = rndNumber.Next(0, 101); // Generate new random number between 0 and 100

                    if (rarityNumber >= 0 && rarityNumber <= 30) // Trash item
                    {
                        Console.WriteLine("T");
                    }

                    if (rarityNumber >= 30 && rarityNumber <= 55) // Regular Item
                    {
                        Console.WriteLine("Re");
                    }

                    if (rarityNumber >= 55 && rarityNumber <= 75) // Mediocre Item
                    {
                        Console.WriteLine("Med");
                    }

                    if (rarityNumber >= 75 && rarityNumber <= 90) // Beefy Item
                    {
                        Console.WriteLine("Beef");
                    }

                    if (rarityNumber >= 90 && rarityNumber <= 100) // Extravigant Item
                    {
                        Console.WriteLine("Extra");
                    }

                    test++;
                }

               



                
               



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

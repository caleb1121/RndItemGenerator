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



            String[] TrashCondition_List = new string[11]; // Trash Condition List 
                TrashCondition_List[0] = "Terrible";
                TrashCondition_List[1] = "Garbage";
                TrashCondition_List[2] = "Broken";
                TrashCondition_List[3] = "Flimsy";
                TrashCondition_List[4] = "Cracked";
                TrashCondition_List[5] = "Rusty";
                TrashCondition_List[6] = "Bad";
                TrashCondition_List[7] = "Disfunctional";
                TrashCondition_List[8] = "Shit";
                TrashCondition_List[9] = "Weirdly Small";
                TrashCondition_List[10] = "Brittle";


            String[] OffensiveItems_List = new string[13]; // Offensive Items List
                OffensiveItems_List[0] = "Sword";
                OffensiveItems_List[1] = "Mace";
                OffensiveItems_List[2] = "Axe";
                OffensiveItems_List[3] = "Club";
                OffensiveItems_List[4] = "Fork";
                OffensiveItems_List[5] = "Dagger";
                OffensiveItems_List[6] = "Plastic Fork";
                OffensiveItems_List[7] = "Bottle";
                OffensiveItems_List[8] = "Pitchfork";
                OffensiveItems_List[9] = "Brick";
                OffensiveItems_List[10] = "Spoon";
                OffensiveItems_List[11] = "Shoelace";
                OffensiveItems_List[12] = "Baby";


            String[] DefensiveItems_List = new string[13]; // Defensive Items List
                DefensiveItems_List[0] = "Shield";
                DefensiveItems_List[1] = "Hairband";
                DefensiveItems_List[2] = "Boots";
                DefensiveItems_List[3] = "Pants";
                DefensiveItems_List[4] = "G-String";
                DefensiveItems_List[5] = "Shirt";
                DefensiveItems_List[6] = "Mask";
                DefensiveItems_List[7] = "Glasses";
                DefensiveItems_List[8] = "Bracers";
                DefensiveItems_List[9] = "Gloves";
                DefensiveItems_List[10] = "Earings";
                DefensiveItems_List[11] = "Sandals";
                DefensiveItems_List[12] = "Bracelet";

            String[] OffensiveSkills_List = new string[6]; // Offensive Skills List
                OffensiveSkills_List[0] = "Attack";
                OffensiveSkills_List[1] = "Speed";
                OffensiveSkills_List[2] = "Range";
                OffensiveSkills_List[3] = "Durability";
                OffensiveSkills_List[4] = "Critical Hit Chance";
                OffensiveSkills_List[5] = "Weight";

            String[] DefensiveSkills_List = new string[3]; // Defensive Skills List
                DefensiveSkills_List[0] = "Armor";
                DefensiveSkills_List[1] = "Durability";
                DefensiveSkills_List[2] = "Weight";













            Again:

            Console.WriteLine("Welcome To Sally's Store Of Random Apparatus v.0.11");
            Console.WriteLine("");

            // Main Menu
            Console.WriteLine("1. Generate Item");
            Console.WriteLine("2. Place Holder");
            Console.WriteLine("3. Leave The Store");

            String UserInput = Console.ReadLine(); // Save User input


            Console.Clear(); // clears the console


            if (UserInput == "1") // Generate single item if user selects option 1
            {

                Random rndNumber = new Random(); // random number
              
              
                int rarityNumber = rndNumber.Next(0, 101); // Generate new random number between 0 and 100

                 if (rarityNumber >= 0 && rarityNumber <= 100) // Trash item (normally between 0 and 30)
                 {

                        string ItemCondition; // store item condition
                        string ItemName; // store item name
                        string ItemRarity = "Trash"; // item rarity

                        ItemCondition = TrashCondition_List[rndNumber.Next(0, 11)]; // choose item condition using random array item

                        int itemTypeChoice = rndNumber.Next(0,2); // generate a number between 0 - 1 and store inside "itemTypeChoice"
                        
                        if(itemTypeChoice == 0) // Offensive items
                        {
                             ItemName = OffensiveItems_List[rndNumber.Next(0, 13)];
                        }

                        else // Defensive items
                        {
                            ItemName = DefensiveItems_List[rndNumber.Next(0, 13)];
                        }





                    Console.WriteLine("Item Generated Succesfully!");
                    Console.WriteLine("Item Name: " + ItemCondition + " " + ItemName);
                    Console.WriteLine("Rarity: " + ItemRarity);

                    Console.WriteLine("Press Any Key To Continue");
                    Console.ReadKey();
                    Console.Clear();
                    goto Again;

                 }

                 if (rarityNumber >= 30 && rarityNumber <= 55) // Regular Item
                 {
                        
                 }

                 if (rarityNumber >= 55 && rarityNumber <= 75) // Mediocre Item
                 {
                        
                 }

                if (rarityNumber >= 75 && rarityNumber <= 90) // Beefy Item
                {
                        
                }

                if (rarityNumber >= 90 && rarityNumber <= 100) // Extravigant Item
                {
                        
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

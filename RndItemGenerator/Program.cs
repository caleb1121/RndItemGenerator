﻿using System;
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



            String[] TrashCondition_List = new string[10]; // Trash Condition List 
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


             String[] Item_list = new string[27]; // Item List
                Item_list[0] = "Sword";
                Item_list[1] = "Shield";
                Item_list[2] = "Hairband";
                Item_list[3] = "Mace";
                Item_list[4] = "Axe";
                Item_list[5] = "Boots";
                Item_list[6] = "Pants";
                Item_list[7] = "G-String";
                Item_list[8] = "Shirt";
                Item_list[9] = "Mask";
                Item_list[10] = "Club";
                Item_list[11] = "Fork";
                Item_list[12] = "Dagger";
                Item_list[13] = "Plastic Fork";
                Item_list[14] = "Bottle";
                Item_list[15] = "Glasses";
                Item_list[16] = "Bracers";
                Item_list[17] = "Gloves";
                Item_list[18] = "Earings";
                Item_list[19] = "Pitchfork ";
                Item_list[20] = "Shovel";
                Item_list[21] = "Toothbrush";
                Item_list[22] = "Brick";
                Item_list[23] = "Sandals";
                Item_list[24] = "Spoon";
                Item_list[25] = "Baby";
                Item_list[26] = "Shoelace";
                Item_list[27] = "Bracelet";


            String[] OffensiveItems_List = new string[12]; // Offensive Items List
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


            String[] DefensiveItems_List = new string[12]; // Defensive Items List
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
              
              
                    int rarityNumber = rndNumber.Next(0, 101); // Generate new random number between 0 and 100

                    if (rarityNumber >= 0 && rarityNumber <= 30) // Trash item
                    {
                        
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

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
            // this is a test push!


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

            String[] OffensiveSkills_List = new string[8]; // Offensive Skills List
                OffensiveSkills_List[0] = "Attack";
                OffensiveSkills_List[1] = "Speed";
                OffensiveSkills_List[2] = "Range";
                OffensiveSkills_List[3] = "Attack Speed";
                OffensiveSkills_List[4] = "Critical Hit Chance";
                OffensiveSkills_List[5] = "Weight";
                OffensiveSkills_List[6] = "Throw";
                OffensiveSkills_List[7] = "Balance";

            String[] DefensiveSkills_List = new string[6]; // Defensive Skills List
                DefensiveSkills_List[0] = "Armor";
                DefensiveSkills_List[1] = "Durability";
                DefensiveSkills_List[2] = "Weight";
                DefensiveSkills_List[3] = "Jump Height";
                DefensiveSkills_List[4] = "Health Regen";
                DefensiveSkills_List[5] = "Mana Regen";













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
                    string Skill1 = "";
                    string Skill2 = "";
                    int Skillnum1 = rndNumber.Next(-3, 4); // skill modify amount
                    int Skillnum2 = rndNumber.Next(-3, 4); // skill modify amount


                    ItemCondition = TrashCondition_List[rndNumber.Next(0, 11)]; // choose item condition using random array item

                    int itemTypeChoice = rndNumber.Next(0, 2); // generate a number between 0 - 1 and store inside "itemTypeChoice"


                    int modifiedSkills = rndNumber.Next(0, 2); // How many skills are modified 


                    if (itemTypeChoice == 0) // Offensive items
                    {
                        ItemName = OffensiveItems_List[rndNumber.Next(0, 13)]; // choose an item from offensive item list

                        if (modifiedSkills == 0) // if 0 then item only has one skill modifier
                        {
                            Skill1 = OffensiveSkills_List[rndNumber.Next(0,8)]; // choose random offensive skill 1
                        }

                        else // else item has two skill modifiers
                        {
                            Skill1 = OffensiveSkills_List[rndNumber.Next(0, 8)]; // choose random offensive skill 1
                            Skill2 = OffensiveSkills_List[rndNumber.Next(0, 8)]; // choose random offensive skill 2
                        }
                    }




                    else // Defensive items
                    {
                        ItemName = DefensiveItems_List[rndNumber.Next(0, 13)]; // choose random defensive item

                        if (modifiedSkills == 0) // if 0 then item only has one skill modifier
                        {
                            Skill1 = DefensiveSkills_List[rndNumber.Next(0, 5)]; //choose random defensive skill 1
                        }

                        else // else item has two skill modifiers
                        {
                            Skill1 = DefensiveSkills_List[rndNumber.Next(0, 5)]; //choose random defensive skill 1
                            Skill2 = DefensiveSkills_List[rndNumber.Next(0, 5)]; //choose random defensive skill 2
                        }
                    }


                    


                            
                        




                    // Item printer below!
                    Console.WriteLine("Item Generated Succesfully!");
                    Console.WriteLine("Item Name: " + ItemCondition + " " + ItemName);
                    Console.WriteLine("Rarity: " + ItemRarity);
                    Console.WriteLine(Skill1 + " " + Skillnum1);
                    if (Skill2 != "") // check if the second skill is empty if it's not then print second skill
                    { Console.WriteLine(Skill2 + " " + Skillnum2); }

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

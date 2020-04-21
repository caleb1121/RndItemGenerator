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
            Console.WriteLine("Generated item: Fighting Wasp");
            Console.Write("Rarity level: " );
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Rare");
            Console.ResetColor();
            Console.WriteLine("");

            Console.WriteLine("Stat one: + 5 attack");
            Console.WriteLine("Stat two: +2 speed");
            Console.WriteLine("Special ability: Wasp explosion!");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using TeaPartyHorror_Game;
using static TeaPartyHorror_Game.Rooms.Inventory;

namespace TeaPartyHorror_Game.Rooms
{

    internal class Inventory
    {

        public static List<GameItem> items = new List<GameItem>();

        public void AddItem(GameItem item)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            items.Add(item);
            Console.WriteLine($"{item} has been added to your inventory.");
            Console.ForegroundColor = ConsoleColor.White;
        }

        public void ListItems()
        {
           Console.ForegroundColor = ConsoleColor.Magenta;
            if (items.Count == 0)
            {
                Console.WriteLine("Your inventory is empty. Press enter to continue.");
                return;
            }
            
            Console.WriteLine("Inventory Items:");
            foreach (var item in items)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Press enter to continue.");
            Console.ForegroundColor = ConsoleColor.White;
        }
        public bool UseItem(GameItem item)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            if (items.Contains(item))
            {
                items.Remove(item);
                Console.WriteLine($"{item} has been used.");
                Console.ForegroundColor = ConsoleColor.White;
                return true; 
            }
            else
            {
                Console.WriteLine("Item not found in inventory.");
                Console.ForegroundColor = ConsoleColor.White;
                return false;
            }

        }
    }
}
//steph girlie write this in order to call an item in this method for the game xD
//game.UseItem(GameItem.Amulet);
//i made some changes if you have any questions call or text me 
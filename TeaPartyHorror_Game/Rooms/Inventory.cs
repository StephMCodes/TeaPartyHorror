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

        private List<GameItem> items = new List<GameItem>();

        public void AddItem(GameItem item)
        {
            items.Add(item);
            Console.WriteLine($"{item} has been added to your inventory.");
        }

        public void ListItems()
        {
            if (items.Count == 0)
            {
                Console.WriteLine("Your inventory is empty.");
                return;
            }

            Console.WriteLine("Inventory Items:");
            foreach (var item in items)
            {
                Console.WriteLine(item);
            }
        }
        public bool UseItem(GameItem item)
        {
            if (items.Contains(item))
            {
                items.Remove(item);
                Console.WriteLine($"{item} has been used.");
                return true; 
            }
            else
            {
                Console.WriteLine("Item not found in inventory.");
                return false;
            }
        }
    }
}
//steph girlie write this in order to call an item in this method for the game xD
//game.UseItem(GameItem.Amulet);
//i made some changes if you have any questions call or text me 
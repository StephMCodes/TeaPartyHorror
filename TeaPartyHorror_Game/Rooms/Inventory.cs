using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeaPartyHorror_Game.Rooms;

namespace TeaPartyHorror_Game
{

    internal static class Inventory
    {

        public static List<GameItem> items = new List<GameItem>();

        public static void AddItem(GameItem item)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            items.Add(item);
            Console.WriteLine($"{item} has been added to your inventory.  [Press enter to continue.]");
            Console.ForegroundColor = ConsoleColor.White;
        }

        public static void ListItems()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            if (items.Count == 0)
            {
                Console.WriteLine("Your inventory is empty. [Press enter to continue.]");
                return;
            }

            Console.WriteLine("Inventory Items:");
            foreach (var item in items)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("[Press enter to continue.]");
            Console.ForegroundColor = ConsoleColor.White;
        }
        public static bool UseItem(GameItem item)
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
        //public void UseItem(GameItem item)
        //{
        //    // Check if the inventory has the item before using it
        //    if (Inventory.HasItem(item)) // Assuming you have a HasItem method in Inventory
        //    {
        //        switch (item)
        //        {
        //            case GameItem.Amulet:
        //                DecreaseFear();
        //                Console.WriteLine("The amulet glows powerfully, and you feel your fear diminish. Mr Bunny-Rabbit puts his paw out and destroys it with his magic, sending shards everywhere.");
        //                Inventory.RemoveItem(GameItem.Amulet); // Use Inventory's method to remove the item
        //                break;
        //            case GameItem.Snack:
        //                Console.WriteLine("You eat the snack, feeling a bit better and less fearful.");
        //                DecreaseFear();
        //                Inventory.RemoveItem(GameItem.Snack); // Use Inventory's method to remove the item
        //                break;
        //            case GameItem.Flowers:
        //                Console.WriteLine("You admire the flowers, feeling a moment of peace.");
        //                Inventory.RemoveItem(GameItem.Flowers);
        //                break;
        //            case GameItem.MrBunnyRabbit:
        //                Console.WriteLine("He has been with you a long time, but only began to move and speak recently. You smile at your plushie friend, and he smiles back.");
        //                // No need to remove the item if it's not consumable
        //                break;
        //            case GameItem.Invitation:
        //                Console.WriteLine("You ponder the invitation. There must be a use for this somewhere.");
        //                // No need to remove the item if it's not consumable
        //                break;
        //            default:
        //                Console.WriteLine("Invalid command.");
        //                break;
        //        }
        //    }
        //    else
        //    {
        //        Console.WriteLine("You don't have that item in your inventory.");
        //    }

        //}
    }
}
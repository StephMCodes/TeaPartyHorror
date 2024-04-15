using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
<<<<<<< HEAD
using static TeaPartyHorror_Game.Rooms.Inventory;

namespace TeaPartyHorror_Game.Rooms
{
    internal class Inventory
    {

        public abstract class Item
        {
            public abstract string Name { get; protected set; }
            public abstract void Use();
        }
        public class Snack : Item
        {
            private static readonly string[] snackTypes = { "strawberry ", "cookie ", "brownie " };
            private static readonly Random rnd = new Random();

            public Snack()
            {
                Random rnd = new Random();
                Name = snackTypes[rnd.Next(snackTypes.Length)] + "snack ";
            }

            public override string Name { get; protected set; }
            public override void Use()
            {
                Console.WriteLine($"Using{Name}.");
            }
        }
        public class Amulet : Item
        {
            public Amulet()
            {
                Name = "Amulet";
            }
            public override string Name { get; protected set; }
            public override void Use()
            {
                Console.WriteLine("Using Amulet to reduce fear.");
            }
        }
        public class Bouquet : Item
        {
            public Bouquet()
            {
                Name = "Bouquet";
            }
            public override string Name { get; protected set; }
            public override void Use()
            {
                Console.WriteLine(" Item to give the lady ");
            }
        }
        public class MrBunnyRabbit : Item
        {
            public MrBunnyRabbit()
            {
                Name = "Bunny-Rabbit";
            }
            public override string Name { get; protected set; }
            public override void Use()
            {
                Console.WriteLine("Mr.Bunny-Rabbit says, 'You are uninvited to my birthday party you mere mortal!' ");
            }
        }

        public class Inventory
        {
            private List<Item> items = new List<Item>();
        }
        public void AddItem(Item item)
        {
            items.Add(item);
            Console.WriteLine($"{item.Name} has been added to your inventory. ");
        }
        public void UseItem(string itemName)
        {
            var item = items.FirstOrDefault(item => item.Name.Equals(itemName, StringComparison.OrdinalIgnoreCase));

            if (item != null)
            {
                items.Use();
                items.Remove(item);
            }
            else
            {
                Console.WriteLine("Item not found in inventory.");
            }             
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
                Console.WriteLine(item.Name);
            }

        }

    }
}
=======
//using static TeaPartyHorror_Game.Rooms.Inventory;

//namespace TeaPartyHorror_Game.Rooms
//{
//    internal class Inventory
//    {

//        public abstract class Item
//        {
//            public abstract string Name { get; protected set; }
//            public abstract void Use();
//        }
//        public class Snack : Item
//        {
//            private static readonly string[] snackTypes = { "strawberry ", "cookie ", "brownie " };
//            private static readonly Random rnd = new Random();

//            public Snack()
//            {
//                Random rnd = new Random();
//                Name = snackTypes[rnd.Next(snackTypes.Length)] + "snack ";
//            }

//            public override string Name { get; protected set; }
//            public override void Use()
//            {
//                Console.WriteLine($"Using{Name}.");
//            }
//        }
//        public class Amulet : Item
//        {
//            public Amulet()
//            {
//                Name = "Amulet";
//            }
//            public override string Name { get; protected set; }
//            public override void Use()
//            {
//                Console.WriteLine("Using Amulet to reduce fear.");
//            }
//        }
//        public class Bouquet : Item
//        {
//            public Bouquet()
//            {
//                Name = "Bouquet";
//            }
//            public override string Name { get; protected set; }
//            public override void Use()
//            {
//                Console.WriteLine(" Item to give the lady ");
//            }
//        }
//        public class MrBunnyRabbit : Item
//        {
//            public MrBunnyRabbit()
//            {
//                Name = "Bunny-Rabbit";
//            }
//            public override string Name { get; protected set; }
//            public override void Use()
//            {
//                Console.WriteLine("Mr.Bunny-Rabbit says, 'You are uninvited to my birthday party you mere mortal!' ");
//            }
//        }

//        public class Inventory
//        {
//            private List<Item> items = new List<Item>();
//        }
//        public void AddItem(Item item)
//        {
//            items.Add(item);
//            Console.WriteLine($"{item.Name} has been added to your inventory. ");
//        }
//        public void UseItem(string itemName)
//        {
//            var item = items.FirstOrDefault(item => item.Name.Equals(itemName, StringComparison.OrdinalIgnoreCase));

//            if (item != null)
//            {
//                items.Use();
//                items.Remove(item);
//            }
//            else
//            {
//                Console.WriteLine("Item not found in inventory.");
//            }             
//        }
//        public void ListItems()
//        {
//            if (items.Count == 0)
//            {
//                Console.WriteLine("Your inventory is empty.");
//                return;
//            }

//            Console.WriteLine("Inventory Items:");
//            foreach (var item in items)
//            {
//                Console.WriteLine(item.Name);
//            }

//        }

//    }
//}
>>>>>>> 27fc3eef11d467108d4db07f65269c531b379bad

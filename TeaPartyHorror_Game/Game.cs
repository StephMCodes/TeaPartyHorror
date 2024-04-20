using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeaPartyHorror_Game.Rooms;

namespace TeaPartyHorror_Game
{
    public enum GameItem
    {
        MrBunnyRabbit,
        Snack,
        Flowers,
        Amulet,
        Invitation
    }

    internal class Game
    {
        List<Room> rooms = new List<Room>();
        public Inventory Inventory { get; private set; } = new Inventory();
        Room currentRoom;
        internal bool IsGameOver() => isFinished;
        static bool isFinished;
        static string nextRoom = "";

        internal Game()
        {

        }
        internal static int fearLevel = 0; 

        internal void Add(Room room)
        {
            rooms.Add(room);
            if (currentRoom == null)
            {
                currentRoom = room;
            }
        }

        internal static void Transition<T>() where T : Room
        {
            nextRoom = typeof(T).Name;
        }


        internal string CurrentRoomDescription => currentRoom?.CreateDescription() ??
        "You are nowhere yet sifting through what you picked up on the way";

        internal void ReceiveChoice(string choice)
        {
            if (choice == "inventory")
            {
                Inventory.ListItems();
            }
            else
            {
                currentRoom?.ReceiveChoice(choice);
                CheckTransition();
            }
        }

        internal static void IncreaseFear(int num)
        {
            Console.ForegroundColor = ConsoleColor.Red; 
            fearLevel += num;
            Console.WriteLine($"Fear increases. Current fear level: {fearLevel}/10");
            if (fearLevel >= 10)
            {
                Console.WriteLine("The fear overwhelms you, leading to a game over.");
                Console.WriteLine("*");
                Console.WriteLine("BAD ENDING - [Press enter to quit.]");
                Game.Finish();

            }
            Console.ForegroundColor = ConsoleColor.White;
        }

        internal static void DecreaseFear()
        {
            Console.ForegroundColor= ConsoleColor.Red;
            if (fearLevel > 0) fearLevel--;
            Console.WriteLine($"Fear decreases. Current fear level: {fearLevel}.");
            Console.ForegroundColor = ConsoleColor.White;
        }

        internal void CheckTransition()
        {
            foreach (var room in rooms)
            {
                if (room.GetType().Name == nextRoom)
                {
                    nextRoom = "";
                    currentRoom = room;
                    break;
                }
            }
        }

        public void UseItem(GameItem item)
        {
            if (Inventory.UseItem(item))
            {
                switch (item)
                {
                    case GameItem.Amulet:
                        DecreaseFear();
                        Console.WriteLine("The amulet glows powerfully, and you feel your fear diminish. Mr Bunny-Rabbit puts his paw out and destroys it with his magic, sending shards everywhere.");
                        Inventory.items.Remove(GameItem.Amulet);
                        break;
                    case GameItem.Snack:
                        Console.WriteLine("You eat the snack, feeling a bit better and less fearful.");
                        DecreaseFear();
                        Inventory.items.Remove(GameItem.Snack);
                        break;
                    case GameItem.Flowers:
                        Console.WriteLine("You admire the flowers, feeling a moment of peace.");
                        //DecreaseFear();
                        break;
                    case GameItem.MrBunnyRabbit:
                        Console.WriteLine("He has been with you a long time, but only began to move and speak recently. You smile at your plushie friend, and he smiles back.");
                        //Console.WriteLine("Mr. Bunny-Rabbit doesn't seem to do much. Maybe someone else wants it?");
                        break;
                    case GameItem.Invitation:
                        Console.WriteLine("You ponder the invitation. There must be a use for this somewhere.");
                        //ADD RANDOM CODE!
                        break;
                    default:
                        Console.WriteLine("Invalid command.");
                        //Console.WriteLine("This item doesn't seem to do anything...");
                        break;
                }
            }
        }

        internal static void Finish()
        {
            isFinished = true;
        }
    }
}
//public enum GameItem //we need 5 values for the grade
//{
//    MrBunnyRabbit, //If i write the dash and space it gets confused so I smushed his name
//    Snack,
//    Flowers,
//    Amulet,
//    Invitation
//}
//internal class Game
//{

//    internal static int fearLevel = 0; //or public?

//    List<Room> rooms = new List<Room>();
//    public static List<GameItem> Inventory = new List<GameItem>();
//    Room currentRoom;
//    internal bool IsGameOver() => isFinished;
//    static bool isFinished;
//    static string nextRoom = "";

//    internal void Add(Room room)
//    {
//        rooms.Add(room);
//        if (currentRoom == null)
//        {
//            currentRoom = room;
//        }
//    }

//    internal string CurrentRoomDescription => currentRoom.CreateDescription();

//    //internal void ReceiveChoice(string choice)
//    //{
//    //    currentRoom.ReceiveChoice(choice);
//    //    CheckTransition();
//    //}
//    internal void ReceiveChoice(string choice) 
//    {
//        if(choice == "inventory")
//        {
//            Console.WriteLine("You have: (...)");
//            foreach (GameItem Item in Inventory)
//            {
//                Console.WriteLine(Item);
//            }
//        }
//        else
//        {
//            currentRoom.ReceiveChoice(choice);
//            CheckTransition();
//        }
//    }
//    internal static void IncreaseFear(int num)
//    {
//        fearLevel+= num;
//        Console.WriteLine($"Fear increases. Current fear level: {fearLevel}.");
//        if (fearLevel >= 5)
//        {
//            Console.WriteLine("The fear overwhelms you, leading to a game over.");
//            Finish();
//        }
//    }
//   internal static void DecreaseFear()
//    {
//        if (fearLevel > 0) fearLevel--;
//        Console.WriteLine($"Fear decreases. Current fear level: {fearLevel}.");
//    }

//    internal static void Transition<T>() where T : Room
//    {
//        nextRoom = typeof(T).Name;
//    }

//    internal static void Finish()
//    {
//        isFinished = true;
//    }

//    internal void CheckTransition()
//    {
//        foreach (var room in rooms)
//        {
//            if (room.GetType().Name == nextRoom)
//            {
//                nextRoom = "";
//                currentRoom = room;
//                break;
//            }
//        }
//    //    }
//    }



//}


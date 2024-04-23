using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using TeaPartyHorror_Game.Rooms;
using static TeaPartyHorror_Game.Program;

namespace TeaPartyHorror_Game
{
    public enum GameItem
    {
        MrBunnyRabbit = 0,
        Snack,
        Flowers,
        Amulet,
        Invitation
    }
    
    internal class Game
    {
        List<Room> rooms = new List<Room>(); 
  public Room currentRoom; //static?
        internal bool IsGameOver() => isFinished;
        static bool isFinished;
        static string nextRoom = "";

        internal Game()
        {

        }
        internal static int fearLevel; 

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
          var bf = new BinaryFormatter();
          FileStream stream = File.OpenWrite(Program.SaveFile);
          savedata.saveRoom = typeof(T).Name;
          nextRoom = typeof(T).Name;
          bf.Serialize(stream, savedata);
          stream.Close();
            
            
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
                var bf = new BinaryFormatter();
                FileStream stream = File.OpenWrite(Program.SaveFile);
                savedata.saveRoom = choice.ToLower();
                bf.Serialize(stream, savedata);
                stream.Close();
                currentRoom?.ReceiveChoice(choice.ToLower());
                CheckTransition();
            }
        }

        internal static void IncreaseFear(int num)
        {
            fearLevel += num;
            Console.ForegroundColor = ConsoleColor.Red; 
          var bf = new BinaryFormatter();
            FileStream stream = File.OpenWrite(Program.SaveFile);
            savedata.fearLevel += num;
            fearLevel=savedata.fearLevel;
            bf.Serialize(stream, savedata);
            stream.Close();
            Console.WriteLine($"\nFear increases. Current fear level: {fearLevel}/10");
            
            Console.ForegroundColor = ConsoleColor.White;
        }

        internal static void DecreaseFear()
        {
            Console.ForegroundColor= ConsoleColor.Red;
            if (fearLevel > 0) fearLevel--;
            Console.ForegroundColor = ConsoleColor.Red;
            var bf = new BinaryFormatter();
            FileStream stream = File.OpenWrite(Program.SaveFile);
            if (savedata.fearLevel > 0) savedata.fearLevel--;
            fearLevel = savedata.fearLevel;
            bf.Serialize(stream, savedata);
            stream.Close();
            Console.WriteLine($"\nFear decreases. Current fear level: {fearLevel}.");
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


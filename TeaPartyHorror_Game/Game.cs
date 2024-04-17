using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeaPartyHorror_Game
{
    public enum GameItem //we need 5 values for the grade
    {
        MrBunnyRabbit, //If i write the dash and space it gets confused so I smushed his name
        Snack,
        Flowers,
        Amulet,
        Invitation
    }
    internal class Game
    {

        internal static int fearLevel = 0; //or public?
        
        List<Room> rooms = new List<Room>();
        public static List<GameItem> Inventory = new List<GameItem>();
        Room currentRoom;
        internal bool IsGameOver() => isFinished;
        static bool isFinished;
        static string nextRoom = "";

        internal void Add(Room room)
        {
            rooms.Add(room);
            if (currentRoom == null)
            {
                currentRoom = room;
            }
        }

        internal string CurrentRoomDescription => currentRoom.CreateDescription();

        //internal void ReceiveChoice(string choice)
        //{
        //    currentRoom.ReceiveChoice(choice);
        //    CheckTransition();
        //}
        internal void ReceiveChoice(string choice) 
        {
            if(choice == "inventory")
            {
                Console.WriteLine("You have: (...)");
                foreach (GameItem Item in Inventory)
                {
                    Console.WriteLine(Item);
                }
            }
            else
            {
                currentRoom.ReceiveChoice(choice);
                CheckTransition();
            }
        }
        internal static void IncreaseFear(int num)
        {
            fearLevel+= num;
            Console.WriteLine($"Fear increases. Current fear level: {fearLevel}.");
            if (fearLevel >= 5)
            {
                Console.WriteLine("The fear overwhelms you, leading to a game over.");
                Finish();
            }
        }
       internal static void DecreaseFear()
        {
            if (fearLevel > 0) fearLevel--;
            Console.WriteLine($"Fear decreases. Current fear level: {fearLevel}.");
        }

        internal static void Transition<T>() where T : Room
        {
            nextRoom = typeof(T).Name;
        }

        internal static void Finish()
        {
            isFinished = true;
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
    }



}


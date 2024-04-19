using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeaPartyHorror_Game.Rooms.MinigameQuestions;

namespace TeaPartyHorror_Game.Rooms
{
    internal class DiningRoomComplete : Room
    {
        
        internal override string CreateDescription() =>
       @"There is a smell of sweet treats, waiting to be eaten by hungry children. From the dining room, you can leave to the    [hallway].";

        internal override void ReceiveChoice(string choice)
        {
            switch (choice.ToLower())
            {
                case "hallway":
                    Game.Transition<Hallway>();
                    break;

                //case "1":
                //    Console.WriteLine("The cook will feed you gross stuff that initially looks good, that you have to pretend to like when you bite into it and realise its gross");
                //    Console.ForegroundColor = ConsoleColor.Magenta;
                //    Console.WriteLine("Press 1 to pretend to like\t\tPress 2 to spit it out");
                //    Console.ForegroundColor = ConsoleColor.White;
                //    Game.Transition<DiningRoomQu1>();
                //    break;

                //default:
                    //Console.WriteLine("Invalid command.");
                    //Console.ForegroundColor = ConsoleColor.Magenta;
                    //Console.WriteLine("Press 1 to sit down ");
                    //Console.ForegroundColor = ConsoleColor.White;
                    //Console.WriteLine("There is a smell of sweet treats, waiting to be eaten by hungry children. From the dining room, you can leave to the [hallway].");
                    //break;
            }
        }
    }
}

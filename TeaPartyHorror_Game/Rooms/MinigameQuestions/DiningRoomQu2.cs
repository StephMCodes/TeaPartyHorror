using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeaPartyHorror_Game.Rooms.MinigameQuestions
{
    internal class DiningRoomQu2 : Room
    {
        internal override string CreateDescription() => @"";
        internal override void ReceiveChoice(string choice)
        {
            //Console.WriteLine("Question text");
            switch (choice.ToLower())
            {
                case "1":
                    Console.WriteLine("The ghost does NOT approve");
                    Game.IncreaseFear(1);
                    Game.Transition<DiningRoomQu3>();
                    Console.WriteLine("Then you don't forget the two magic words.");
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("Press 1 to say thank you\t\tPress 2 to say screw you");
                    //CHANGE TO A CONSOLE READLINE I DONT HAVE THE TIME FOR...
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                case "2":
                    Console.WriteLine("The ghost approves");
                    Game.Transition<DiningRoomQu3>();
                    Console.WriteLine("Then you don't forget the two magic words.");
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("Press 1 to say thank you\t\tPress 2 to say screw you");
                    //CHANGE TO A CONSOLE READLINE I DONT HAVE THE TIME FOR...
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                default:
                    Console.WriteLine("Invalid command.");
                    Console.WriteLine("The knife should be in the right hand and the fork in the left");
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("Press 1 to do it wrong\t\tPress 2 to do it right");
                    Console.ForegroundColor = ConsoleColor.White;
                    break;

            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeaPartyHorror_Game.Rooms.MinigameQuestions
{
    internal class BallroomQu2 : Room
    {
        internal override string CreateDescription() => @"";
        internal override void ReceiveChoice(string choice)
        {

            switch (choice.ToLower())
            {
                case "1":
                    Console.WriteLine("The ghost does NOT approve");
                    Game.IncreaseFear(1);
                    Game.Transition<BallroomQu3>();
                    Console.WriteLine("You can look around");
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("Press 1 to look at her dress\t\tPress 2 to check out the other dancers\t\tPress 3 to look her in the eyes\t\tPress 4 to catch glimpses of the room");
                    Console.ForegroundColor = ConsoleColor.White;
                   
                    break;
                case "2":
                    Console.WriteLine("The ghost approves");
                    Game.Transition<BallroomQu3>();
                    Console.WriteLine("You can look around");
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("Press 1 to look at her dress\t\tPress 2 to check out the other dancers\t\tPress 3 to look her in the eyes\t\tPress 4 to catch glimpses of the room");
                    Console.ForegroundColor = ConsoleColor.White;
                    break;

                default:
                    Console.WriteLine("First, you need the right position of the hands.");
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("Press 1 to do it wrong\t\tPress 2 to do it right");
                    Console.ForegroundColor = ConsoleColor.White;
                    break;

            }
        }
    }
}

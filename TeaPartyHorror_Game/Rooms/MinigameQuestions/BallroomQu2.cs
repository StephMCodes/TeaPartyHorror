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
                    Console.WriteLine("\nYou see dissapointment flare in the older woman's eyes as she corrects you, and shame mixes with fear in your stomach.");
                    Console.WriteLine("\nBut she softens at the sight of your embarassment.");
                    Game.IncreaseFear(1);
                    Game.Transition<BallroomQu3>();
                    Console.WriteLine("\nYou find yourself becoming distracted from your dance partner, distracted by all the sounds and sights around you...");
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("Press 1 to look at her dress\t\tPress 2 to check out the other dancers");
                    Console.WriteLine("Press 3 to look her in the eyes\t\tPress 4 to catch glimpses of the room");
                    Console.ForegroundColor = ConsoleColor.White;
                   
                    break;
                case "2":
                    Console.WriteLine("\nThe ghost approves, smiling at you.");
                    Game.Transition<BallroomQu3>();
                    Console.WriteLine("\nYou find yourself becoming distracted from your dance partner, distracted by all the sounds and sights around you...");
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("Press 1 to look at her dress\t\tPress 2 to check out the other dancers");
                    Console.WriteLine("Press 3 to look her in the eyes\t\tPress 4 to catch glimpses of the room");
                    Console.ForegroundColor = ConsoleColor.White;
                    break;

                default:
                    Console.WriteLine("\nFirst, you need the right position of the hands.");
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("Press 1 to do it wrong\t\tPress 2 to do it right");
                    Console.ForegroundColor = ConsoleColor.White;
                    break;

            }
        }
    }
}

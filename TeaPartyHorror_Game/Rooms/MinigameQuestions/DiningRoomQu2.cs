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
                    Console.WriteLine("\nThe ghost decidedly is not impressed by your manners. ");
                    Console.WriteLine("\nYou swear you can see an angry, red glint in her eyes that makes you shiver.");
                    Game.IncreaseFear(1);
                    Game.Transition<DiningRoomQu3>();
                    Console.WriteLine("\n'Now,' she begins once you have finished your meal, 'The two magic words?' ");
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("Press 1 to say 'thank you'\t\tPress 2 to say 'screw you'");
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                case "2":
                    Console.WriteLine("\nThe cook joins her hands and regards you happily as you continue forcing yourself to eat.");
                    Game.Transition<DiningRoomQu3>();
                    Console.WriteLine("\n'Now,' she begins once you have finished your meal, 'The two magic words?'");
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("Press 1 to say 'thank you'\t\tPress 2 to say 'screw you'");
                    //CHANGE TO A CONSOLE READLINE I DONT HAVE THE TIME FOR...
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                default:

                    Console.WriteLine("\nYou are sleepy and cant remember your table etiquette in front of all that cutlery...");
                    Console.WriteLine("\nThe knife should be in the right hand and the fork in the left");
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("Press 1 to pick up your fork with your right hand and your knife with your left");
                    Console.WriteLine("Press 2 to pick up your fork with your left hand and your knife with the right.");
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
            }
        }
    }
}

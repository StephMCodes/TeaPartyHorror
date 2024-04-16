using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeaPartyHorror_Game.Rooms.MinigameQuestions
{
    internal class DiningRoomQu1 : Room
    {
        internal override string CreateDescription() => @"";
        internal override void ReceiveChoice(string choice)
        {
            
            switch (choice.ToLower())
            {
                case "1":
                    
                    Console.WriteLine("The ghost approves");
                    Game.Transition<DiningRoomQu2>();
                    Console.WriteLine("The knife should be in the right hand and the fork in the left");
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("Press 1 to do it wrong\t\tPress 2 to do it right");
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                case "2":
                    Console.WriteLine("The ghost does NOT approve");
                    Game.IncreaseFear(1);
                    Game.Transition<DiningRoomQu2>();
                    Console.WriteLine("The knife should be in the right hand and the fork in the left");
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("Press 1 to do it wrong\t\tPress 2 to do it right");
                    Console.ForegroundColor = ConsoleColor.White;
                    break;

                default:
                    Console.WriteLine("Invalid command.");
                    Console.WriteLine("The cook will feed you gross stuff that initially looks good, that you have to pretend to like when you bite into it and realise its gross");
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("Press 1 to pretend to like\t\tPress 2 to spit it out");
                    Console.ForegroundColor = ConsoleColor.White;
                    break;

            }
        }
        
    }
}
    


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
                    
                    Console.WriteLine("The cook smiles at you. It's somewhere between sweet old granny and creepy.");
                    Game.Transition<DiningRoomQu2>();
                    Console.WriteLine("You are sleepy and cant remember your table etiquette in front of all that cutlery...");
                    Console.WriteLine("The knife should be in the right hand and the fork in the left");
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("Press 1 to pick up your fork with your right hand and your knife with your left");
                    Console.WriteLine("Press 2 to pick up your fork with your left hand and your knife with the right.");
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                case "2":
                    Console.WriteLine("The ghost glares at you for your bad manners.");
                    Game.IncreaseFear(1);
                    Game.Transition<DiningRoomQu2>();
                    Console.WriteLine("You are sleepy and cant remember your table etiquette in front of all that cutlery...");
                    Console.WriteLine("The knife should be in the right hand and the fork in the left");
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("Press 1 to pick up your fork with your right hand and your knife with your left");
                    Console.WriteLine("Press 2 to pick up your fork with your left hand and your knife with the right.");
                    Console.ForegroundColor = ConsoleColor.White;
                    break;

                default:
                    Console.WriteLine("The cook waves a hand and a porcelain plate, and cutlery float over to your place at the table! It smells divine...");
                    Console.WriteLine("But when you bite into it... It tastes like bugs and dirt!");
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("Press 1 to pretend to like\t\tPress 2 to spit it out");
                    Console.ForegroundColor = ConsoleColor.White;
                    break;

            }
        }
        
    }
}
    


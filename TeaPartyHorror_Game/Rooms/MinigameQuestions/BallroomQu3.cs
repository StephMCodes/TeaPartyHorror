using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeaPartyHorror_Game.Rooms.MinigameQuestions
{
    internal class BallroomQu3 : Room
    {
        
        internal override string CreateDescription() => @"";
        internal override void ReceiveChoice(string choice)
        {
            
            switch (choice.ToLower())
            {
                case "1":

                    Console.WriteLine("The ghost does NOT approve");
                    Game.IncreaseFear(1);
                    Console.WriteLine("The dance is about to end, how do you finish it?");
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("Press 1 to spin dramatically\t\tPress 2 to exageratedly bow down\t\tPress 3 to try and pick her up\t\tPress 4 to hold out your hand for her");
                    Console.ForegroundColor = ConsoleColor.White;
                    Game.Transition<BallroomQu4>();

                    break;

                case "2":

                    Console.WriteLine("The ghost does NOT approve");
                    Game.IncreaseFear(1);
                    Console.WriteLine("The dance is about to end, how do you finish it?");
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("Press 1 to spin dramatically\t\tPress 2 to exageratedly bow down\t\tPress 3 to try and pick her up\t\tPress 4 to hold out your hand for her");
                    Console.ForegroundColor = ConsoleColor.White;
                    Game.Transition<BallroomQu4>();
                    break;

                    case "3":

                    Console.WriteLine("The ghost does indeed approve");
                    Console.WriteLine("The dance is about to end, how do you finish it?");
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("Press 1 to spin dramatically\t\tPress 2 to exageratedly bow down\t\tPress 3 to try and pick her up\t\tPress 4 to hold out your hand for her");
                    Console.ForegroundColor = ConsoleColor.White;
                    Game.Transition<BallroomQu4>();

                    break;

                case "4":

                    Console.WriteLine("The ghost does NOT approve");
                    Game.IncreaseFear(1);
                    Console.WriteLine("The dance is about to end, how do you finish it?");
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("Press 1 to spin dramatically\t\tPress 2 to exageratedly bow down\t\tPress 3 to try and pick her up\t\tPress 4 to hold out your hand for her");
                    Console.ForegroundColor = ConsoleColor.White;
                    Game.Transition<BallroomQu4>();

                    break;

                  
                default:
                    
                    Console.WriteLine("You can look around"); //maybe keep these now to remind them the description
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("Press 1 to look at her dress\t\tPress 2 to check out the other dancers\t\tPress 3 to look her in the eyes\t\tPress 4 to catch glimpses of the room");
                    Console.ForegroundColor = ConsoleColor.White;
                    break;

            }
        }

    }
}

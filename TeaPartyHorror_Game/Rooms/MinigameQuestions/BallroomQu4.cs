using System;
using System.Collections.Generic;
using System.Deployment.Internal;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeaPartyHorror_Game.Rooms.MinigameQuestions
{
    internal class BallroomQu4 : Room
    {

        internal static bool hasDanced;
        internal override string CreateDescription() => @"";
        internal override void ReceiveChoice(string choice)
        {
            
            switch (choice.ToLower())
            {
                case "1":

                    Console.WriteLine("The ghost does NOT approve");
                    Game.IncreaseFear(1);
                    Console.WriteLine("The dance is about to end, how do you finish it?");
                    Inventory.items.Add(GameItem.Amulet);
                    hasDanced = true;
                    Game.Transition<Ballroom>();

                    break;

                case "2":

                    Console.WriteLine("The ghost does NOT approve");
                    Game.IncreaseFear(1);
                    Console.WriteLine("The dance is about to end, how do you finish it?");
                    hasDanced = true;
                    Game.Transition<Ballroom>();
                    break;

                case "3":

                    Console.WriteLine("The ghost does NOT approve");
                    Game.IncreaseFear(1);
                    Console.WriteLine("The dance is about to end, how do you finish it?");
                    Inventory.items.Add(GameItem.Amulet);
                    hasDanced = true;
                    Game.Transition<Ballroom>();

                    break;

                case "4":

                    Console.WriteLine("The ghost does indeed approve");
                    Console.WriteLine("You are nice and warm now. Thanks for the dance. Here is an amulet."); //GET AMULET
                    Inventory.items.Add(GameItem.Amulet);
                    hasDanced = true;
                    Game.Transition<Ballroom>();
                    break;


                default:
                    
                    Console.WriteLine("The dance is about to end, how do you finish it?");
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("Press 1 to spin dramatically\t\tPress 2 to exageratedly bow down");
                    Console.WriteLine("Press 3 to try and pick her up\t\tPress 4 to hold out your hand for her");
                    Console.ForegroundColor = ConsoleColor.White;
                    break;

            }
        }
    }
}

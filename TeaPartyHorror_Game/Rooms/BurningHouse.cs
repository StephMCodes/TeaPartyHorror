using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeaPartyHorror_Game.Rooms
{
    internal class BurningHouse : Room
    {
        internal override string CreateDescription() =>
       @"You are in your old bedroom, cluttered and familiar.";

        internal override void ReceiveChoice(string choice)
        {
             
            
            switch (choice.ToLower())
                {
                    case "1":
                        {

                        Console.WriteLine("\nYou feel your skin tingle as fire starts to catch on your flesh. ");
                        Console.WriteLine("\n'AHHHHH!'you scream in horror, scared of your awaiting fate! ");
                            Game.IncreaseFear(2);
                        Console.WriteLine("\n[Press enter to continue.]");
                        Console.ForegroundColor = ConsoleColor.White;
                        Game.Transition<Bedroom>(); break;
                            
                        }
                    case "2":
                        {

                        Console.WriteLine("\nYou crawl out your window, hurting yourself on the way down.");
                        Console.WriteLine("\nBut Papa and Mama are nowhere to be seen! ");
                        Game.IncreaseFear(1);
                        Console.WriteLine("\n[Press enter to continue.]");
                        Console.ForegroundColor = ConsoleColor.White;
                        Game.Transition<Bedroom>(); break;
                        }
                

                default:
                    Console.WriteLine("\nYou jump out your bed, startled by the smell of smoke.");
                    Console.WriteLine("\nThe door handle is warm to the touch, but you need to warn your parents.");
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("Press 1 to run inside and look for your parents\t\tPress 2 to climb out your window");
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                }
            }
        }
}

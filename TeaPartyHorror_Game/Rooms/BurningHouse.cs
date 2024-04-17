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
                            
                            Console.WriteLine("You feel your skin tingle as fire starts to catch on your flesh. 'AHHHHH!', " + "you scream in horror scared about you're awa-iting fate. Scary!");
                            Game.IncreaseFear(2);
                        Console.WriteLine("Press enter to continue.");
                        Console.ForegroundColor = ConsoleColor.White;
                        Game.Transition<Bedroom>(); break;
                            
                        }
                    case "2":
                        {
                            
                            Console.WriteLine("You escape. Scary!");
                            Game.IncreaseFear(1);
                        Console.WriteLine("Press enter to continue.");
                        Console.ForegroundColor = ConsoleColor.White;
                        Game.Transition<Bedroom>(); break;
                        }
                }
            }
        }
}

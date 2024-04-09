using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeaPartyHorror_Game.Rooms
{
    internal class Hallway : Room
    {
        public static bool ownsInvitation;
        internal override string CreateDescription() =>
       @"The dim hallway is long and filled with many picture frames of rich fellows.
It leads to a dining room, ballroom, and tea room. You can also return to your bedroom.
You see a ghostly butler at the end of the hall who seems to be guarding a door.
";

        internal override void ReceiveChoice(string choice)
        {
            switch (choice.ToLower())
            {
                case "bedroom":
                    Console.WriteLine("You return to your bedroom.");
                    Game.Transition<Bedroom>();
                    break;
                case "kitchen":
                    Console.WriteLine("You wander to the kitchen.");
                    Game.Transition<DiningRoom>();
                    break;
                case "ballroom":
                    Console.WriteLine("You make your way to the ballroom.");
                    Game.Transition<Ballroom>();
                    break;
                case "tearoom":
                    
                        if (ownsInvitation == true)
                        {
                            Console.WriteLine("The butler lets you in.");
                            Game.Transition<Tearoom>();
                            break;
                        }
                    Console.WriteLine("The butler stops you.");
                    break;

                case "fear":
                    Console.WriteLine($"Current fear level: {Game.fearLevel}.");

                    break;
                default:
                    Console.WriteLine("Invalid command.");
                    break;
            }
        }

    }

}


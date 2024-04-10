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
       @"The dim hallway is long and filled with many picture frames of rich fellows,
and you see a ghostly butler at the end of the hall who seems to be guarding a door.
It leads to a [dining room], [ballroom], and [tea room]. You can also return to your [bedroom].";

        internal override void ReceiveChoice(string choice)
        {
            switch (choice.ToLower())
            {
                case "bedroom":
                    Console.WriteLine("You return to the bedroom your aunt and uncle gave you.");
                    Game.Transition<BedroomAwake>();
                    break;
                case "dining room":
                    Console.WriteLine("You wander to the dining room, following the smell of sweets wafting in the air.");
                    Game.Transition<DiningRoom>();
                    break;
                case "ballroom":
                    Console.WriteLine("You make your way to the ballroom, following the sound of classical music.");
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


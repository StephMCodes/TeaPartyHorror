using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeaPartyHorror_Game.Rooms
{
    internal class Hallway : Room
    {
        internal override string CreateDescription() =>
       @"You enter the hallway. Write FEAR to check fear level.";

        internal override void ReceiveChoice(string choice)
        {
            switch (choice)
            {
                case "bedroom":
                    Console.WriteLine("You return to your bedroom.");
                    Game.Transition<Bedroom>();
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


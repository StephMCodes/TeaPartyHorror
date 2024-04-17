using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeaPartyHorror_Game.Rooms
{
    internal class GardenComplete : Room
    {
        internal override string CreateDescription() =>
      @"You cant see the gardener ghost, but you do hear him happily humming a waltz somewhere in the shrubbery. You can go back to the [ballroom] from here.";

        internal override void ReceiveChoice(string choice)
        {
            
            switch (choice)
            {
                case "ballroom":
                    Console.WriteLine("You make your way to the ballroom, the one-two-three rhythm still playing in your head.");
                    Game.Transition<Ballroom>();
                    break;
                default:
                    Console.WriteLine("Invalid command.");
                    break;
            }
        }
    }
}

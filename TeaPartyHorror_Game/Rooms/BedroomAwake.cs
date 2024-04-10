using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeaPartyHorror_Game.Rooms
{
    internal class BedroomAwake : Room
    {
        private bool isMonsterFriend = false; //encapsulate with method
        internal override string CreateDescription() =>
       @"From your new bedroom, there is the [hallway] that leads to the rest of the mansion, and you hear strange noises under  your [bed].";
        internal override void ReceiveChoice(string choice)
        {
            switch (choice.ToLower())
            {
                case "hallway":
                    Game.Transition<Hallway>(); break;

                case "bed":
                    //if no treat
                    Console.WriteLine("Ahh! When you peek underneath, long, shadowy hands swipe at you!");
                    Console.WriteLine("Mr Bunny-Rabbit frowns. 'A monster under the bed! He's probably been eating your good dreams! Don't trust him.");
                    Console.WriteLine("You back away. The monster wails, swiping at you some more, 'Soooooo hungry.......'");
                    break;
            }


        }
    }
}


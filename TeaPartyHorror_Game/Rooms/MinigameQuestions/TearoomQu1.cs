using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeaPartyHorror_Game.Rooms
{
    internal class TearoomQu1 : Room
    {
        internal override string CreateDescription() =>
       @"";

        internal override void ReceiveChoice(string choice)
        {
            Console.WriteLine("AHHH HE IS EVIL");
            switch (choice)
            {
                
                case "bedroom":
                    Console.WriteLine("You return to your bedroom.");
                    Game.Transition<Bedroom>();
                    break;
                case "2314":
                    Console.WriteLine("The chest opens and you get a key.");
                    //isKeyCollected = true;
                    break;
                default:
                    Console.WriteLine("Invalid command.");
                    break;
            }
        }

    }

}


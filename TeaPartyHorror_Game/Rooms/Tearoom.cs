﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeaPartyHorror_Game.Rooms
{
    internal class Tearoom : Room
    {
        internal override string CreateDescription() =>
       @"In the attic, it's dark and cold.
        A chest is locked with the code [????].
        You can return to your [bedroom].";

        internal override void ReceiveChoice(string choice)
        {
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


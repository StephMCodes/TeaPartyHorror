﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeaPartyHorror_Game.Rooms
{
    internal class Start : Room
    {
        internal override string CreateDescription() =>
        @"
You are a young girl, adopted recently by your wealthy aunt and uncle.
They have no other children in the mansion, so you must make your own entertainment and play by yourself.
Thankfully, the house is full of spirits only you seem to notice…

WELCOME TO

TEA PARTY HORROR

ENTER START OR QUIT";

        internal override void ReceiveChoice(string choice)
        {
            switch (choice.ToUpper())
            {
                case "START":
                    Console.WriteLine("You begin in your new bedroom.");
                    Game.Transition<Bedroom>();
                    break;
                case "QUIT":
                    //bella help

                    break;
                default:
                    Console.WriteLine("Invalid command.");
                    break;
            }
        }
    }
}
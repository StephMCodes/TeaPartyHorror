﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeaPartyHorror_Game.Rooms
{
    internal class Ballroom : Room
    {
        internal override string CreateDescription() =>
        @"You can go to [hallway] or the [garden] from this luxurious ballroom, where spirits chat after a lovely dance.";

        internal override void ReceiveChoice(string choice)
        {
            switch (choice)
            {
                case "hallway":
                    Game.Transition<Hallway>();
                    break;
                case "garden":
                    Console.WriteLine("\nYou go to the garden. ");
                    Game.Transition<GardenComplete>();
                    break;
                default:
                    Console.WriteLine("Invalid command. ");
                    break;
            }
        }

    }
}



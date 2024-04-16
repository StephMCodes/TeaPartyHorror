using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeaPartyHorror_Game.Rooms
{
    internal class Ballroom : Room
    {
        internal override string CreateDescription() =>
        @"You can go to [hallway] or the [garden].";

        internal override void ReceiveChoice(string choice)
        {
            switch (choice)
            {
                case "hallway":
                    Console.WriteLine("You return to your bedroom.");
                    Game.Transition<Hallway>();
                    break;
                case "garden":
                    Console.WriteLine("You go to the garden.");
                    Game.Transition<Garden>();
                    break;
                default:
                    Console.WriteLine("Invalid command.");
                    break;
            }
        }

    }
    }



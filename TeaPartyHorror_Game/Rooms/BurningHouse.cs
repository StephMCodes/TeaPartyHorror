﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeaPartyHorror_Game.Rooms
{
    internal class BurningHouse : Room
    {
        internal override string CreateDescription() =>
       @"You are in your old bedroom, cluttered and familiar.";

        internal override void ReceiveChoice(string choice)
        {
             
            
            switch (choice.ToLower())
                {
                    case "1":
                        {
                            
                            Console.WriteLine("You burn. AHHHHH! Scary!");
                            Game.IncreaseFear(2);
                            Game.Transition<Bedroom>(); break;
                            
                        }
                    case "2":
                        {
                            
                            Console.WriteLine("You escape. Scary!");
                            Game.IncreaseFear(1);
                            Game.Transition<Bedroom>(); break;
                        }
                }
            }
        }
}

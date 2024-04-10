using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeaPartyHorror_Game.Rooms
{
    internal class BurningHouse : Room
    {
        internal override string CreateDescription() =>
       @"You are in your old bedroom that is on fire. Your house is on fire. Out or in? ";

        internal override void ReceiveChoice(string choice)
        {
            
                switch (choice.ToLower())
                {
                    case "in":
                        {
                            
                            Console.WriteLine("You burn. AHHHHH! Scary!");
                            Game.IncreaseFear(2);
                            Game.Transition<Bedroom>(); break;
                            
                        }
                    case "out":
                        {
                            
                            Console.WriteLine("You escape. Scary!");
                            Game.IncreaseFear(1);
                            Game.Transition<Bedroom>(); break;
                        }
                }
            }
        }
}

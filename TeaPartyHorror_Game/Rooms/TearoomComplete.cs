using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeaPartyHorror_Game.Rooms
{
    internal class TearoomComplete : Room
    {
        internal override string CreateDescription() =>
@"You are in the tearoom";
        internal override void ReceiveChoice(string choice)
        {
            switch (choice)
            {
                case "1":
                    Console.WriteLine("You violently rip up your plushie, tears in your eyes. The plushie yells something and stops moving.");
                    break;
                case "2":
                    Console.WriteLine("Happy ending we have to write");
                    break;
                default:
                    Console.WriteLine("Invalid command.");
                    Console.WriteLine("The plushie is laughing a lot, he is not paying attention. Now is your chance!");
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("Press 1 to tear your plushie up \t\tPress 2 to hug him and tell him everything is going to be okay");
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
            }
        }
    }
}

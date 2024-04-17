﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeaPartyHorror_Game.Rooms
{
    internal class MUTBSnackInteraction : Room
    {
        internal static bool isMonsterFriend;
        internal override string CreateDescription() =>
       @"From your new bedroom, there is the [hallway] that leads to the rest of the mansion, and you hear strange noises under  your [bed].";

        internal override void ReceiveChoice(string choice)
        {
            Console.WriteLine("Question text");
            switch (choice.ToLower())
            {
                case "1":
                    Console.WriteLine("You carefully approach your snack towards the bed, and the monster immediately swipes it with surprising speed. You hear chewing noises, grumbling, and finally, a loud belch.");
                    Console.WriteLine("Mr Bunny-Rabbit makes a face. 'And now what do we say..?'");
                    Console.WriteLine("'Excuse me.' The monster pokes his head from under his hiding place, and you can discern a smile from the darkness. 'Thaaaaank youuuuu... I promise only to eat your bad dreams from now on.");
                    isMonsterFriend = true;
                    break;
                case "2":
                    Console.WriteLine("You back away, clutching your snack close to your chest. No one shall take it from you!");
                    Game.Transition<BedroomAwake>();
                    break;
                default:
                    Console.WriteLine("Invalid command.");
                    Console.WriteLine("Ahh! When you peek underneath, long, shadowy hands swipe at you!");
                    Console.WriteLine("Mr Bunny-Rabbit frowns. 'Stay away from the monster,' he warns.");
                    Console.WriteLine("You back away. The monster wails, swiping at you some more, 'Im soooooo huuungryyy.......'");
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("Press 1 to feed him your snack\t\tPress 2 to stay away");
                    Console.ForegroundColor = ConsoleColor.White;
                    Game.Transition<MUTBSnackInteraction>(); 
                    break;
            }
        }
    }
}
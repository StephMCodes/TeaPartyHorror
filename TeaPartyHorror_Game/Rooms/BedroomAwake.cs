﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeaPartyHorror_Game.Rooms.MinigameQuestions;

namespace TeaPartyHorror_Game.Rooms
{
    internal class BedroomAwake : Room
    {

        internal override string CreateDescription() =>
       @"From your new bedroom, there is the [hallway] that leads to the rest of the mansion, and you hear strange noises under  your [bed]. This location is your safe space.";
        internal override void ReceiveChoice(string choice)
        {
            switch (choice.ToLower())
            {
                case "hallway":
                    Game.Transition<Hallway>(); break;

                case "bed":
                    if (!DiningRoomQu3.snackReceived)
                    {
                        Console.WriteLine("\nAhh! When you peek underneath, long, shadowy hands swipe at you!");
                        Console.WriteLine("\nMr Bunny-Rabbit frowns. 'A monster under the bed!");
                        Console.WriteLine("\nHe's probably been eating your good dreams! Don't trust him.");
                        Console.WriteLine("\nYou back away. The monster wails, swiping at you some more, 'Im soooooo huuungryyy.......'");
                    }
                    else if (MUTBSnackInteraction.isMonsterFriend == false)
                    {
                        Console.WriteLine("\nAhh! When you peek underneath, long, shadowy hands swipe at you!");
                        Console.WriteLine("\nMr Bunny-Rabbit frowns. 'Stay away from the monster,' he warns.");
                        Console.WriteLine("\nYou back away. The monster wails, swiping at you some more, 'Im soooooo huuungryyy.......'");
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine("Press 1 to feed him your snack\t\tPress 2 to stay away");
                        Console.ForegroundColor = ConsoleColor.White;
                        Game.Transition<MUTBSnackInteraction>();
                    }
                    else { Console.WriteLine("\nYou see a shy, shadowy hand wave hello from under the bed."); }
                    break;
            }
        }
    }
}



﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace TeaPartyHorror_Game.Rooms
{
    internal class TearoomQu1 : Room
    {
        internal override string CreateDescription() =>
       @"You enter a room, and there is a table perfecly set with small dainty teacups.
There are only two seats empty, the rest are occupied by teddy bears, dolls, etc 
that all turn to look at you and invite you.";

        internal override void ReceiveChoice(string choice)
        {
            Console.WriteLine("AHHH HE IS EVIL");
            switch (choice)
            {
                //Room 5: Tearoom/Final boss: When you enter the room, the table is set for you. There are only two seats empty, the rest are occupied by teddy bears, dolls, etc that all turn to look at you and invite you. You must place the bunny rabbit down and sit down for the encounter to begin. You get access to this room by completing all the quests, because you receive an invitation from a crow with a letter. The letter contains a random code.
                //The final boss is her small bunny plushie that looks seemingly innocent. At the end the bunny interacts with something and triggers the final boss event. If the conditions aren’t met a message displays you are missing a key piece.  

                //PHASE 1
                //He casts a nightmare on you, if you helped the MUTB this phase is partially skipped. If not, you suffer fear and must wake up again. 

                //PHASE 2 
                //He casts a spell on you with a red light that gives you a headache. He wants to feed off of your memories, fear, etc. You get a bad headache without the amulet.

                //PHASE 3
                //He casts a spell on you with red tendrils that seem to attach to you like puppet strings. If you ate the oleander, you become sick and more Afraid.
    

                 case "1":
                    Console.WriteLine("The ghost does NOT approve");
                    Game.IncreaseFear(1);
                    //Game.Transition<DiningRoomQu3>();
                    Console.WriteLine("Then you don't forget the two magic words.");
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("Press 1 to say thank you\t\tPress 2 to say screw you");
                    //CHANGE TO A CONSOLE READLINE I DONT HAVE THE TIME FOR...
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                case "2":
                    Console.WriteLine("The ghost approves");
                    //Game.Transition<DiningRoomQu3>();
                    Console.WriteLine("Then you don't forget the two magic words.");
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("Press 1 to say thank you\t\tPress 2 to say screw you");
                    //CHANGE TO A CONSOLE READLINE I DONT HAVE THE TIME FOR...
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                default:
                    Console.WriteLine("Invalid command.");
                    Console.WriteLine("The knife should be in the right hand and the fork in the left");
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("Press 1 to do it wrong\t\tPress 2 to do it right");
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
            }
        }

    }

}

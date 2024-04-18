using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace TeaPartyHorror_Game.Rooms.MinigameQuestions
{
    internal class TearoomQu1 : Room
    {
        public static bool HasInvitaion;
        internal override string CreateDescription() =>
       @"You are in the tearoom.";

        internal override void ReceiveChoice(string choice)
        {
            Console.WriteLine("");
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
                   
                 
                    Console.WriteLine("You set your plush down and he begins floating and being evil. He casts a nightmare on you.");
                    if (MUTBSnackInteraction.isMonsterFriend==true)
                    {
                        Console.WriteLine("You are safe, Monster helps");
                    }
                    else
                    {
                        Console.WriteLine("You are sent into a nightmare.");
                        Game.IncreaseFear(1);
                    }
                    Game.Transition<TearoomQu2>();
                    //Console.WriteLine("");
                    //Console.ForegroundColor = ConsoleColor.Magenta;
                    //Console.WriteLine("Press 1 to do it wrong\t\tPress 2 to do it right");
                    //Console.ForegroundColor = ConsoleColor.White;


                    break;


                default:
                    Console.WriteLine("Invalid command.");
                    Console.WriteLine("");
                    Console.WriteLine("When you enter the room, the table is set for you." +
                            "There are only two seats empty, the rest are occupied by teddy bears and dolls " +
                            "that all turn to look at you and invite you. ");
                    Console.ForegroundColor = ConsoleColor.Magenta;

                    Console.WriteLine("Press 1 to place Mr Bunny-Rabbit down on a seat and sit down yourself");
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
            }
        }
    }
}


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
                    Console.WriteLine("Once you are both seated, a chill spreads into the room, Mr Bunny-Rabbit's bead eyes gaining a malevolent glint.");
                    Console.WriteLine("'Finally...' he begins, the ghost butler locking the door behind you. 'This family will know the price of replacing me!'");
                    Console.WriteLine("You cannot move! Forced to watch your plush float into the stale air, weaving a nightmare upon you by force...");
                    Console.WriteLine("The world becomes dark, you feel yourself losing consciousness... ");
                    if (MUTBSnackInteraction.isMonsterFriend==true)
                    {
                        Console.WriteLine("As the throes of the nightmare begin to take hold, you feel a cold, little hand with long fingers grab onto your wrist and pull you to safety.");
                        Console.WriteLine("'Not to worry, friend! You are safe, Mr.Monster will eat the bad dreams for you!'");
                    }
                    else
                    {
                        
                        Random randomValueForNightmare = new Random();
                        int nightmareValue = randomValueForNightmare.Next(1, 4);
                        if (nightmareValue == 1)
                        {
                            Console.WriteLine("You're falling, falling in thick darkness, terrified of when you will hit the ground - if there even is one.");
                            Console.WriteLine("Just as you plummet to your death, you are forced back into reality.");
                        }
                        else if (nightmareValue == 2)
                        {
                            Console.WriteLine("Your teeth fall out of your mouth, your fingers elongate and crack: you are becoming a monster.");
                            Console.WriteLine("Your peers all turn to laugh at your shame, and in the crowd you see your parents, terrified.");
                            Console.WriteLine("You run away, only to be forced back into the real world.");
                        }
                        else
                        {
                            Console.WriteLine("Shadowy hands grab onto you from every direction, and it feels like they are about to pull you apart.");
                            Console.WriteLine("Just as you are torn into pieces, you are forced back into reality.");
                        }
                        Game.IncreaseFear(1);
                        Console.WriteLine();
                        Console.WriteLine("[Press enter to continue.]");
                    }
                    Game.Transition<TearoomQu2>();
                    

                    break;


                default:

                    Console.WriteLine("When you enter the room, the table is set for you. " +
                            "There are only two seats empty, the rest occupied by teddy bears and dolls " +
                            "that all turn to look at you in sync and invite you. ");
                    Console.ForegroundColor = ConsoleColor.Magenta;

                    Console.WriteLine("Press 1 to place Mr Bunny-Rabbit down on a seat and sit down yourself");
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
            }
        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeaPartyHorror_Game.Rooms.MinigameQuestions
{
    internal class TearoomQu3: Room
    {
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
                    Console.WriteLine("You try to push and tear through the strings while the tea guests laugh at you.");
                    if (GardenRabbitInteraction.Poisoned == true)
                    {
                        Console.WriteLine("You feel as if you're about to faint...");
                        Console.WriteLine("Your plush laughs and tells you you got poisoned");
                        Game.IncreaseFear(2);
                    }
                    else
                    {
                        Console.WriteLine("You succeed, finding strength within.");
                    }
                    Console.WriteLine("The plushie is laughing a lot, he is not paying attention. Now is your chance!");
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("Press 1 to tear your plushie up \t\tPress 2 to hug him and tell him everything is going to be okay");
                    Console.ForegroundColor = ConsoleColor.White;
                    Game.Transition<TearoomComplete>();
                    break;
               
                default:
                    Console.WriteLine("The rabbit attempts to puppet you with evil strings.");
                    
                    if (GardenRabbitInteraction.Poisoned == true) { Console.WriteLine("But you feel weak... Your stomach hurts."); }
                    
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("Press 1 to fight back");
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
            }
        }
    }
}
  

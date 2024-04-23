using System;
using System.Collections.Generic;
using System.Diagnostics;
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
                    Console.WriteLine("\nYou try to push and tear through the strings while the teatime guests all laugh at you in sync.");
                    if (GardenRabbitInteraction.Poisoned == true)
                    {
                        Console.WriteLine("\nYou feel as if though you are about to faint...");
                        Console.WriteLine("\nYour plushie laughs maniacally, but there is a hint of bitterness.");
                        Console.WriteLine("\n'Oleanders! Poisonous! I did not know, either. Else I would reduced to this!'");
                        Game.IncreaseFear(2);
                    }
                    else
                    {
                        Console.WriteLine("\nYou succeed, finding strength within.");
                        Console.WriteLine("\nYour plushie laughs maniacally, but there is a hint of bitterness. ");
                        Console.WriteLine("\n'Oleanders! Poisonous! Shame you did not fall for it like I did. Reduced to this..!'");
                        
                    }
                    Console.WriteLine("\nYou recall a past child of this family that died of sickness... Ophelia. ");
                    Console.WriteLine("\nWhen you call her by that name, the spirit loses focus. Now is your chance! ");
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("Press 1 to tear your plushie up \t\tPress 2 to hug her and tell her everything is going to be okay");
                    Console.ForegroundColor = ConsoleColor.White;
                    Game.Transition<TearoomComplete>();
                    break;

                default:
                    Console.WriteLine("\nThe voice of your rabbit distorts, beginning to sound almost like a fellow little girl, her accent reminding you of youraunt and uncle.");
                    Console.WriteLine("\n'That necklace they gave you! It belongs to ME!' ");
                    Console.WriteLine("\nThe possessed plush casts a vicious red light that gives you a headache.");
                    Console.WriteLine("\nThe rabbit attempts to puppet you with red strings that appear from its paws.");
                    Console.WriteLine("\nYou feel as though you are about to become only a guest in your body. ");
                    Console.WriteLine("\nThe plushie continues its barrage: 'You are in MY PLACE!' ");


                    if (GardenRabbitInteraction.Poisoned == true) { Console.WriteLine("\nYou feel weak... Your stomach..."); }

                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("Press 1 to fight for control");
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
            }
        }
    }
}
  

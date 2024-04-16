using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeaPartyHorror_Game.Rooms.MinigameQuestions;

namespace TeaPartyHorror_Game.Rooms
{
    
    internal class Hallway : Room
    {
        public static bool ownsInvitation;
        private bool SnackReceived, HasDanced; //fix it why is it just here it should instantiate in game

        internal override string CreateDescription() =>
       @"The dim hallway is long and filled with many picture frames of rich fellows.
It leads to a [dining room], [ballroom], and [tea room],
who's door is guarded by a ghostly butler.
 You can also return to your [bedroom].";

        internal override void ReceiveChoice(string choice)
        {
            switch (choice.ToLower())
            {
                case "bedroom":
                    Console.WriteLine("You return to the bedroom your aunt and uncle gave you.");
                    Game.Transition<BedroomAwake>();
                    break;
                case "dining room":
                    if (SnackReceived == false)
                    {
                        Console.WriteLine("You wander to the dining room, following the smell of sweets wafting in the air." +
                        "You are impressed by the very long table that takes up most of the room, and the table already seems to be set for two." +
                        "A woman in an apron with a strict face looks you up and down. 'There's always food for hungry children here! Even at midnight.'" +
                        "Her form glistens and fades... A ghost!"); //text to fix by stephanie later
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine("Press 1 to sit down");
                        Console.ForegroundColor = ConsoleColor.White;
                        Game.Transition<DiningRoom>();
                    }
                    else 
                    {
                        Console.WriteLine("You wander to the dining room.");
                        Game.Transition<DiningRoomComplete>();

                    }
                 
                    break;
                case "ballroom":
                    if (HasDanced == false)
                    {
                        Console.WriteLine("You make your way to the ballroom, following the sound of classical music. A pathway down it's balcony leads to the [garden].");
                        Console.WriteLine("Ghostly figures danced together in the grandiose, open ballroom. The curtains hung low as the ghosts frolicked in pairs except for one older woman." +
                            "Her face was sullen as loneliness befell her.");
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine("Press 1 to invite her to dance");
                        Console.ForegroundColor = ConsoleColor.White;
                        Game.Transition<BallroomQu1>();
                    } else { Console.WriteLine("You make your way to the ballroom, the one-two-three rhythm still in your head."); 
                        Game.Transition<Ballroom>(); }
                    break;
                case "tearoom":
                    
                        if (ownsInvitation == true)
                        {
                            Console.WriteLine("The butler lets you in.");
                            Game.Transition<Tearoom>();
                            break;
                        }
                    Console.WriteLine("The butler stops you.");
                    break;

                case "fear":
                    Console.WriteLine($"Current fear level: {Game.fearLevel}.");

                    break;
                default:
                    Console.WriteLine("Invalid command.");
                    break;
            }
        }

    }

}


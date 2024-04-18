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
        internal static bool OwnsInvitation;
        

        internal override string CreateDescription() =>
       @"The dim hallway is long and filled with many picture frames of rich fellows.
It leads to a [dining room], [ballroom], and [tea room],
who's door is guarded by a ghostly butler.
 You can also return to your [bedroom].";

        internal override void ReceiveChoice(string choice)
        {
            if (BallroomQu4.HasDanced == true && DiningRoomQu3.SnackReceived == true)
            {
                Console.WriteLine("'CAW, CAW!'");
                Console.WriteLine("You are about to scream when a crow appears out of nowhere, heading straight for you.");
                Console.WriteLine("Your plushie jumps to hug you and calms you down. 'Dont worry, he is a friend!'");
                Console.WriteLine("The bird gently alights on your shoulders, claws careful not to poke you. There is a letter in his beak!");
                Console.WriteLine("INVITATION RECEIVED");
                OwnsInvitation = true;

            }

            switch (choice.ToLower())
            {
                
                case "bedroom":
                    Console.WriteLine("You return to the bedroom your aunt and uncle gave you.");
                    Game.Transition<BedroomAwake>();

                    break;
                case "dining room":
                    if (DiningRoomQu3.SnackReceived == false)
                    {
                        Console.ForegroundColor = ConsoleColor.White;
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
                    if (BallroomQu4.HasDanced == false)
                    {
                        Console.WriteLine("You make your way to the ballroom, following the sound of classical music. A pathway down it's balcony leads to the [garden].");
                        Console.WriteLine("Ghostly figures danced together in the grandiose, open ballroom.");
                        Console.WriteLine("The curtains hung low as the ghosts frolicked in pairs except for one older woman.");
                        Console.WriteLine("Her face was sullen as loneliness befell her.");
                        Console.ForegroundColor = ConsoleColor.Magenta;

                        Console.WriteLine("Press 1 to invite her to dance");
                        Console.ForegroundColor = ConsoleColor.White;
                        Game.Transition<BallroomQu1>();
                    }
                    else
                    {
                        Console.WriteLine("You make your way to the ballroom, the one-two-three rhythm still playing in your head.");
                        Game.Transition<Ballroom>();
                    }
                    break;

                case "tearoom":

                    if (OwnsInvitation == true)
                    {
                        Console.WriteLine("The butler lets you in.");
                        Console.WriteLine("When you enter the room, the table is set for you." +
                            "There are only two seats empty, the rest are occupied by teddy bears and dolls " +
                            "that all turn to look at you and invite you. ");
                        Console.ForegroundColor = ConsoleColor.Magenta;

                        Console.WriteLine("Press 1 to place Mr Bunny-Rabbit down on a seat and sit down yourself");
                        Console.ForegroundColor = ConsoleColor.White;
                        Game.Transition<TearoomQu1>();
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



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
        internal static bool ownsInvitation;
        

        internal override string CreateDescription() =>
       @"The dim hallway is long and filled with many picture frames of rich fellows.
It leads to a [dining room], [ballroom], and [tearoom],
who's door is guarded by a ghostly butler.
You can also return to your [bedroom].";

        internal override void ReceiveChoice(string choice)
        {
            if (ownsInvitation == false && BallroomQu4.hasDanced == true && DiningRoomQu3.snackReceived == true)
            {
                Console.WriteLine("'CAW, CAW!'");
                Console.WriteLine("You are about to scream when a crow appears out of nowhere, heading straight for you.");
                Console.WriteLine("Your plushie jumps to hug you and calms you down. 'Dont worry, he is a friend!'");
                Console.WriteLine("The bird gently alights on your shoulder, claws careful not to poke you. There is a letter in his beak!");
                Inventory.items.Add(GameItem.Invitation);
                ownsInvitation = true;

            }

            switch (choice.ToLower())
            {
                
                case "bedroom":
                    Console.WriteLine("You return to the bedroom your aunt and uncle gave you.");
                    Game.Transition<BedroomAwake>();

                    break;
                case "dining room":
                    if (DiningRoomQu3.snackReceived == false)
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("You wander to the dining room, following the smell of sweets wafting in the air. " +
                        "You are impressed by the very long     table that takes up most of the room, already set for two. " +
                        "A woman in an apron with a strict face looks you up and down.'There's always food for hungry children here! Even at midnight.'" +
                        "Her form glistens and fades... A ghost!"); //text fixed, do not change
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
                    if (BallroomQu4.hasDanced == false)
                    {
                        Console.WriteLine("You make your way to the ballroom, following the sound of classical music.");
                        Console.Write("Ghostly figures dance together in the grandiose, open ballroom. ");
                        Console.Write("The curtains hung low as the ghosts frolicked in pairs, except for one older woman.");
                        Console.WriteLine(" Her face was sullen as loneliness befell her."); //text fixed, do not change
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

                    if (ownsInvitation == true)
                    {
                        Console.WriteLine("The butler lets you in.");
                        Console.WriteLine("When you enter the room, the table is set for you. " +
                            "There are only two seats empty, the rest occupied by teddy bears and dolls " +
                            "that all turn to look at you in sync and invite you. ");
                        Console.ForegroundColor = ConsoleColor.Magenta;

                        Console.WriteLine("Press 1 to place Mr Bunny-Rabbit down on a seat and sit down yourself");
                        Console.ForegroundColor = ConsoleColor.White;
                        Game.Transition<TearoomQu1>();
                        break;
                    }
                    else { Console.WriteLine("The butler stops you. It seems an invitation is necessary..."); }
                    break;

                //case "fear":
                //    Console.WriteLine($"Current fear level: {Game.fearLevel}.");

                //    break;
                //default:
                //    Console.WriteLine("Invalid command.");
                //    break;
            }
        }

    }

}



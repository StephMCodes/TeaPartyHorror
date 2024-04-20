﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeaPartyHorror_Game.Rooms.MinigameQuestions
{
    internal class BallroomQu1 : Room
    {
        public static bool HasFlowers;
        internal override string CreateDescription() => @"A pathway down it's balcony leads to the [garden] and you can also return to the [hallway].";
        internal override void ReceiveChoice(string choice)
        {

            switch (choice.ToLower())
            {
                case "1":
                    if (Garden.HasFlowers == true)
                    {
                        Console.WriteLine("The ghost happily takes your hand along with the flowers. 'How I love these oleanders, as deadly as they are beautiful!'");
                        Console.WriteLine("You take your places on the dance floor. 'You lead, little one. I trust you know how?'");
                        Game.Transition<BallroomQu2>();
                        Console.WriteLine("You remember your strict dance instructors words, but not what you were supposed to do...");
                        Console.WriteLine("First, you need the right position of the hands... But which one?");
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine("Press 1 to place your left hand on her shoulder\t\tPress 2 to place your left hand on her back");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else
                    {
                        Console.WriteLine("A lady needs flowers first");
                        
                    }
                    break;
                case "hallway":
                    Game.Transition<Hallway>();
                    break;
                case "garden": //no changing text
                    Console.WriteLine("You enjoy the view as you descend the marble stairs to the garden that remains colourful even in moonbathed darkness.");
                    Console.WriteLine("There is a gardener ghost, a sullen man tending to pink flowers that smell of peaches. You approach him, and he grumblesat you to back away from his oleanders. ");

                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("Press 1 to explain the problem and ask for flowers\t\tPress 2 to steal some when he is not looking");
                    Console.ForegroundColor = ConsoleColor.White;
                        Game.Transition<Garden>();
                    break;
                default:
                    Console.WriteLine("You make your way to the ballroom, following the sound of classical music.");
                    Console.Write("Ghostly figures dance together in the grandiose, open ballroom. ");
                    Console.Write("The curtains hung low as the ghosts frolicked in pairs, except for one older woman.");
                    Console.WriteLine(" Her face was sullen as loneliness befell her.");
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("Press 1 to invite her to dance");
                    Console.ForegroundColor = ConsoleColor.White;
                    break;

            }
        }

    }
}

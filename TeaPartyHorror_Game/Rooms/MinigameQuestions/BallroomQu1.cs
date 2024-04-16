using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeaPartyHorror_Game.Rooms.MinigameQuestions
{
    internal class BallroomQu1 : Room
    {
        public static bool HasFlowers;
        internal override string CreateDescription() => @"A pathway down it's balcony leads to the [garden].";
        internal override void ReceiveChoice(string choice)
        {

            switch (choice.ToLower())
            {
                case "1":
                    if (HasFlowers == true)
                    {
                        Console.WriteLine("The ghost happily takes your hand along with the flowers");
                        Game.Transition<BallroomQu2>();
                        Console.WriteLine("First, you need the right position of the hands.");
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine("Press 1 to do it wrong\t\tPress 2 to do it right");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else
                    {
                        Console.WriteLine("A lady needs flowers first");
                        Game.Transition<Ballroom>();
                    }
                    break;

                case "garden":
                    Console.WriteLine("You enjoy the view as you descend the marble stairs to the garden that remains colourful even in moonbathed darkness.");
                    Game.Transition<Garden>();
                    break;
                default:
                    Console.WriteLine("Invalid command.");
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("Press 1 to invite her to dance");
                    Console.ForegroundColor = ConsoleColor.White;
                    break;

            }
        }

    }
}

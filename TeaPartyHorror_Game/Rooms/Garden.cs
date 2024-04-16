using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeaPartyHorror_Game.Rooms.MinigameQuestions;

namespace TeaPartyHorror_Game.Rooms
{
    internal class Garden : Room
    {
        public static bool HasFlowers;
        internal override string CreateDescription() =>
       @"You can go back to the [ballroom] from here.";

        internal override void ReceiveChoice(string choice)
        {
            switch (choice)
            {
                case "ballroom":
                        Console.WriteLine("You return to the ballroom, enjoying the sound of classical music. A pathway down it's balcony leads to the [garden].");
                        Console.WriteLine("The older woman is still alone.");
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine("Press 1 to invite her to dance");
                        Console.ForegroundColor = ConsoleColor.White;
                        Game.Transition<BallroomQu1>();
                    break;
                case "1":
                    Console.WriteLine("The older man softens as he hears your story." +
                        "'My sweet, darling Rosalind! I cannot be there with her for I am but a lowly worker, unbefitting to hold a noblewoman's hand..." +
                        "Please, take good care in bringing her these." +
                        "She will know I love her still, even if I am not there.'");
                    HasFlowers = true;
                    break;
                default:
                    Console.WriteLine("Invalid command.");
                    Console.WriteLine("You enjoy the view as you descend the marble stairs to the garden that remains colourful even in moonbathed darkness.");
                    Console.WriteLine("There is a gardener ghost, a sullen man tending to pink flowers that smell of peaches. You approach him, and he tells you to back away from his oleanders. ");

                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("Press 1 to explain the problem and ask for flowers");
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
            }
        }

    }

}


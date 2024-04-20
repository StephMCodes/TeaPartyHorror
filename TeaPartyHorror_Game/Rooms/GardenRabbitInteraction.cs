using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeaPartyHorror_Game.Rooms.MinigameQuestions;

namespace TeaPartyHorror_Game.Rooms
{
    internal class GardenRabbitInteraction : Room
    {
        internal static bool Poisoned;
        internal override string CreateDescription() => @"You are on your way back to the ballroom.";
        internal override void ReceiveChoice(string choice)
        {
            Console.Clear();
            Console.WriteLine("On your way back to the dancers, Mr Bunny-Rabbit comments on how yummy the flowers look.");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Press 1 to take a petal off and eat it\t\tPress 2 to ignore him");
            Console.ForegroundColor = ConsoleColor.White;
            switch (choice.ToLower())
            {
                case "1":
                    Console.Clear();
                    Console.WriteLine("Your bunny friend giggles. 'Mmm, yummy! Hopefully that lady will not notice a few petals missing. Wish I could have some too!");
                    Poisoned = true;
                    Console.Write("You return to the ballroom, you see a piano strike the keys by a seemingly invisible force along with floating violins  being played.");
                    Console.WriteLine(" The lady resembled your late mother. She lowered her gaze, yearning for a waltz.");
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("Press 1 to invite her to dance");
                    Console.ForegroundColor = ConsoleColor.White;
                    Game.Transition<BallroomQu1>();
                    break;
                case "2":
                    Console.Clear();
                    Console.WriteLine("Your bunny friend comments that he wishes he could just have some too! Your loss...");
                    Console.Write("You return to the ballroom, you see a piano strike the keys by a seemingly invisible force along with floating violins  being played.");
                    Console.WriteLine(" The lady resembled your late mother. She lowered her gaze, yearning for a waltz."); ;
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("Press 1 to invite her to dance");
                    Console.ForegroundColor = ConsoleColor.White;
                    Game.Transition<BallroomQu1>();
                    break;
            }
        }
    }
}

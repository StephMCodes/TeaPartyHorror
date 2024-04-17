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
                    Console.WriteLine("Mmm, yummy! Hopefully the lady will not notice a few petals missing. The rabbit comments he wishes he could just have some too!");
                    //ADD IS POISONED BOOL VALUE SECRETLY HERE
                    Console.WriteLine("You return to the ballroom, enjoying the sound of classical music. A pathway down it's balcony leads to the [garden].");
                    Console.WriteLine("Rosalind is still alone.");
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("Press 1 to invite her to dance");
                    Console.ForegroundColor = ConsoleColor.White;
                    Game.Transition<BallroomQu1>();
                    break;
                case "2":
                    Console.Clear();
                    Console.WriteLine("The rabbit comments he wishes he could just have some too! Your loss...");
                    Console.WriteLine("You return to the ballroom, enjoying the sound of classical music. A pathway down it's balcony leads to the [garden].");
                    Console.WriteLine("Rosalind is still alone.");
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("Press 1 to invite her to dance");
                    Console.ForegroundColor = ConsoleColor.White;
                    Game.Transition<BallroomQu1>();
                    break;
            }
        }
    }
}

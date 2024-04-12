using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeaPartyHorror_Game.Rooms
{
    internal class DiningRoom : Room
    {
        private string diningChoice1; //check if private is necessary here
        internal override string CreateDescription() =>
       @"There is a smell of sweet treats, waiting to be eaten by hungry children. From the dining room, you can leave to the [hallway].";

        internal override void ReceiveChoice(string choice)
        {
            if (choice == "1")
            {
                StartMiniGame();
            }
            else if (choice == "hallway")
            {
                Game.Transition<Hallway>();
            }
            else
            {
                Console.WriteLine("Invalid command.");
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("Press 1 to sit down");
                Console.ForegroundColor = ConsoleColor.White;
            }

            //switch (choice)
            //{
            //    case "1": //begin minigame
            //        Console.Clear();
            //        Console.WriteLine("Choice [good1] for good [bad1] for bad");
            //        switch (diningChoice1) //bella says to use if elses etc careful with defaults, make sure they are
            //            //allowed to make spelling mistakes and simply restart the q they were on and not the whole game
            //        {

            //            case "good1":
            //                Console.WriteLine("Ghost is happy. Good!");
            //                break;
            //            case "bad1":
            //                Console.WriteLine("Ghost is mad! EEP!");
            //                Game.IncreaseFear(1);
            //                break;
            //            //default:
            //               // Console.WriteLine("Invalid command.");
            //                //break;
            //        } //end of minigame
            //        Console.WriteLine("Choice 1 for good 2 for bad");
            //        break;
            //    case "hallway":
            //        Game.Transition<Hallway>();
            //        break;
            //    default:
            //        Console.WriteLine("Invalid command.");
            //        Console.ForegroundColor = ConsoleColor.Magenta;
            //        Console.WriteLine("Press 1 to sit down");
            //        Console.ForegroundColor = ConsoleColor.White;
            //        break;
            //}
        }
        private void StartMiniGame()
        {
            Console.Clear();
            Console.WriteLine("Choice [good1] for good [bad1] for bad");
            string miniGameChoice = Console.ReadLine();

            if (miniGameChoice == "good1")
            {
                Console.WriteLine("Ghost is happy. Good! ");
            }
            else if (miniGameChoice == "bad1")

            {
                Console.WriteLine("Ghost is mad! EEP!");
                Game.IncreaseFear(1);
            }
            else
            {
                Console.WriteLine("Invalid command.Try again! ");
            }

        }

    }

}

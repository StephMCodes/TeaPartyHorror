using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeaPartyHorror_Game.Rooms.MinigameQuestions;

namespace TeaPartyHorror_Game.Rooms
{
    internal class DiningRoom : Room
    {
        //private string diningChoice1; //check if private is necessary here
        internal override string CreateDescription() =>
       @"There is a smell of sweet treats, waiting to be eaten by hungry children. From the dining room, you can leave to the    [hallway].";

        internal override void ReceiveChoice(string choice)
        {
            switch (choice.ToLower())
            {
                case "hallway":
                Game.Transition<Hallway>();
                    break;

                case "1":
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("\nThe cook waves a hand and a porcelain plate, and cutlery float over to your place at the table!");
                    Console.WriteLine("\nIt smells divine..."); 
                    Random randomValueForMeal = new Random();
                    int mealValue = randomValueForMeal.Next(1, 4);
                    if (mealValue==1)
                    {
                        Console.WriteLine("\nWow...You are presented with an omelet that seems incredibly delicious.");
                    }
                    else if (mealValue == 2)
                    {
                        Console.WriteLine("\nThe chicken pie before you makes you feel like you're going to float.");
                    }
                    else
                    {
                        Console.WriteLine("\nThe spaghetti seems like the most appetizing thing in the world.");
                    }
                    Console.WriteLine("\nBut when you bite into it... It tastes like bugs and dirt!");
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("Press 1 to pretend to like\t\tPress 2 to spit it out");
                    Console.ForegroundColor = ConsoleColor.White;
                    Game.Transition<DiningRoomQu1>();
                    
                    break;

                default:
                    //Console.WriteLine("Invalid command.");
                    Console.WriteLine("\nYou wander to the dining room, following the smell of sweets wafting in the air. ");
                    Console.WriteLine("\nYou are impressed by the very long table that takes up most of the room, already set for two. ");
                    Console.WriteLine("\nA woman in an apron with a strict face looks you up and down. ");
                    Console.WriteLine("\n'There's always food for hungry children here! Even at midnight.'");
                    Console.WriteLine("\nHer form glistens and fades... A ghost!");
                    
                    Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Press 1 to sit down ");
            Console.ForegroundColor = ConsoleColor.White;
            break;
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
        //private void StartMiniGame()
        //{
        //    Console.Clear();
        //    Console.WriteLine("Choice [good1] for good [bad1] for bad ");
        //    string miniGameChoice = Console.ReadLine();

        //    if (miniGameChoice == "good1")
        //    {
        //        Console.WriteLine("Ghost is happy. Good! ");
        //    }
        //    else if (miniGameChoice == "bad1")

        //    {
        //        Console.WriteLine("Ghost is mad! EEP! ");
        //        Game.IncreaseFear(1);
        //    }
        //    else
        //    {
        //        Console.WriteLine("Invalid command.Try again! ");
        //    }

        //}

    }

}

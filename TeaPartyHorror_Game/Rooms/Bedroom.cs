using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace TeaPartyHorror_Game.Rooms
{
    internal class Bedroom : Room
    {
        private int fearLevel = 0;
        private bool isHungry = true;
        private bool isCold = true;
        private bool isMonsterFriend = false;
        public static bool wokeUp = false;
        
        

        internal override string CreateDescription() =>
       @"You are in your new bedroom.";

        internal override void ReceiveChoice(string choice)
        {
            Console.WriteLine("You jolt awake, shivering under your white duvet set.");
            Console.WriteLine("Your plushie, Mr.Bunny-Rabbit, surprisingly, begins to speak! 'Are you okay? Don't worry, I'm here. Go back to sleep.'");
            Console.WriteLine("But sleep eludes you... You feel fearful in this new environment.");
            Console.WriteLine("-------------------------------------------------------------------");
            Console.WriteLine("Press 1 to clutch onto Mr.Bunny-Rabbit\t Press 2 to force yourself to sleep");
            switch (choice.ToLower())
            {
                case "1":

                    Console.WriteLine("Your friend reassures you: 'Everything will be okay.'");
                    Game.DecreaseFear();
                    break;
                    
                case "2":
                    Console.Clear();
                    Console.WriteLine("This new house is so scary. You can't sleep..");
                   //clear somehow???
                    Console.WriteLine("You're hungry...");
                    
                    Console.WriteLine("You're so cold...");

                    Console.WriteLine("You smell smoke...But you can't move!");

                    Console.WriteLine("The fire inches closer and closer...");

                    Console.Write("WAKE UP"); Console.Write("WAKE UP"); Console.Write("WAKE UP"); Console.Write("WAKE UP"); Console.WriteLine("");
                    
                    //clear somehow

                    Console.WriteLine("You wake up...again. You pinch yourself. OW!");
                    
                    Console.WriteLine("Your plushie friend pats your back. 'Another nightmare? C'mon, cheer up, you must be hungry, let's grab a snack in the  dining room. And maybe a dance in the ballroom will warm you up!");
                    Game.Transition<BedroomAwake>();
                    break;
            }
            
            
        }

        }



    // @"You wake up in your dark, cold new bedroom, shivering under your white duvet set.
    // Your plushie Mr.Bunny - Rabbit, surprisingly, speaks, 'Are you okay? Don't worry, go back to sleep.'
    // But sleep eludes you. You feel fearful.";
    //Console.WriteLine("Press 1 to clutch onto Mr.bunny rabbit\t Press 2 to force yourslef to sleep\t Press 3 to wake up");
    //switch (choice.ToLower())
    //{
    //    case "hallway": { Game.Transition<Hallway>(); } break;
    //    case "1":

    //        Console.WriteLine("Mr. bunny rabbit reassures you, 'Everything will be okay.'");
    //        Game.DecreaseFear();
    //        break;

    //    case "2":
    //        if (isHungry || isCold)
    //        {
    //            Console.WriteLine("You're too uncomfortable to sleep.");
    //            Game.IncreaseFear();
    //        }
    //        else
    //        {
    //            Console.WriteLine("You manage to fall asleep, but the nightmare continues.");
    //            Game.IncreaseFear();
    //        }
    //        break;

    //    case "3":
    //        if (fearLevel < 3)
    //        {
    //            Console.WriteLine("You force your eyes open, waking up from the nightmare.");
    //            if (isMonsterFriend)
    //            {
    //                Console.WriteLine("The monster whispers, 'Thank you for the snack. I'll only eat the bad dreams now.'");
    //            }
    //            else
    //            {
    //                Console.WriteLine("The monster grumbles from under the bed, 'I'm hungry too...'");

    //            }
    //        }
    //        else
    //        {
    //            Console.WriteLine("The fear is too much, keeping you trapped in the nightmare.");
    //        }
    //        break;


    //switch (choice)
    //{
    //    case "bedroom":
    //        Console.WriteLine("You return to your bedroom.");
    //        Game.Transition<Bedroom>();
    //        break;
    //    case "2314":
    //        Console.WriteLine("The chest opens and you get a key.");
    //        //isKeyCollected = true;
    //        break;
    //    default:
    //        Console.WriteLine("Invalid command.");
    //        break;

} 
    
        
    


    


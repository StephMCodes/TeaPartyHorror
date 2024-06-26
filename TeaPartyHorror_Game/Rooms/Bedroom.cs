﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using static TeaPartyHorror_Game.Program;

namespace TeaPartyHorror_Game.Rooms
{
    internal class Bedroom : Room
    {
        
        internal static bool hasMrBunnyRabbit;


        internal override string CreateDescription() =>
       @"You are in your new bedroom. ... It's too clean.";

        internal override void ReceiveChoice(string choice)
        {
            if (hasMrBunnyRabbit == false)
            {
                Inventory.AddItem(GameItem.MrBunnyRabbit);
                hasMrBunnyRabbit = true;
                var bf = new BinaryFormatter();
                FileStream stream = File.OpenWrite(Program.SaveFile);
                savedata.hasMrBunnyRabbit = true;
                bf.Serialize(stream, savedata);
                stream.Close();

            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\nYou jolt awake, shivering under your white duvet set.");
            Console.WriteLine("\nYour plushie, Mr.Bunny-Rabbit, surprisingly, begins to speak! ");
            Console.WriteLine("\n'Are you okay? Don't worry, I'm here. Go back to sleep.' ");
            Console.WriteLine("\nBut sleep eludes you... You feel fearful in this new environment.");
            Console.WriteLine(""); Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Press 1 to clutch onto Mr.Bunny-Rabbit\t\tPress 2 to force yourself to sleep");
            Console.ForegroundColor = ConsoleColor.White;
            switch (choice.ToLower())
            {
                case "1":

                    Console.Clear();
                    Console.WriteLine("\nYour friend reassures you: 'Everything will be okay.'");
                    Game.DecreaseFear();
                    Console.WriteLine(""); Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("Press 1 to clutch onto Mr.Bunny-Rabbit\t\tPress 2 to force yourself to sleep");
                    Console.ForegroundColor = ConsoleColor.White;
                    break;

                case "2":
                    Console.Clear();
                    Console.WriteLine("This new house is so scary. You can't sleep...");
                    Console.WriteLine();
                    Console.ReadLine();
                    Console.WriteLine("You're hungry...");
                    Console.ReadLine();
                    Console.WriteLine();
                    Console.WriteLine("You're so cold...");
                    Console.WriteLine();
                    Console.ReadLine();
                    Console.WriteLine("You smell smoke...But you can't move!");
                    Console.WriteLine();
                    Console.ReadLine();
                    Console.WriteLine("The fire inches closer and closer...");

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("\tWAKE UP");
                    Console.ReadLine(); Console.Write("\t\tWAKE UP");
                    Console.ReadLine(); Console.Write("\t\t\tWAKE UP");
                    Console.ReadLine(); Console.Write("\t\t\t\tWAKE UP");
                    Console.ReadLine();Console.WriteLine("");

                    Console.ForegroundColor = ConsoleColor.White;
                    //clear somehow
                    Console.WriteLine();
                    Console.WriteLine("You wake up...again. You pinch yourself. OW! ");
                    Console.WriteLine();
                    Console.WriteLine("\nYour plushie friend pats your back. 'Another nightmare? ");
                    Console.WriteLine("\nC'mon, cheer up, you must be hungry, let's grab a snack in the  dining room. ");
                    Console.WriteLine("\nAnd maybe a dance in the ballroom will warm you up!'"); 
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








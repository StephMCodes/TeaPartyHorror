using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace TeaPartyHorror_Game.Rooms.MinigameQuestions
{
    internal class TearoomQu2 : Room
    {

        internal override string CreateDescription() =>
       @"You are in the tearoom.";

        internal override void ReceiveChoice(string choice)
        {
            
            Console.WriteLine("Bunny is evil, he casts a red light that gives you a headache.");
            Game.IncreaseFear(2);
            Inventory.UseItem(GameItem.Amulet);
            Console.WriteLine("The rabbit attempts to puppet you with evil strings.");
            Game.Transition<TearoomQu3>();
            if (GardenRabbitInteraction.Poisoned==true) { Console.WriteLine("But you feel weak... Your stomach hurts."); }
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Press 1 to fight back");
            Console.ForegroundColor = ConsoleColor.White;

        }
        }
    }



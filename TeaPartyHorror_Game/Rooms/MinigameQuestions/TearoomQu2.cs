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
            Console.WriteLine("The voice of your rabbit distorts, beginning to sound almost like a fellow little girl, her accent reminding you of youraunt and uncle.'That necklace they gave you! It belongs to ME!'");
            
            Console.WriteLine("The possessed plush casts a vicious red light that gives you a splitting headache.");
            Game.IncreaseFear(2);
            Inventory.UseItem(GameItem.Amulet);
            Console.WriteLine("The amulet's light fights back agaisnt the darkness, glowing powerfully, and you feel your fear diminish. Mr Bunny-Rabbit puts his paw out and destroys it with his magic, sending shards everywhere.");

            Game.DecreaseFear();
            Console.WriteLine("The rabbit attempts to puppet you with red strings that appear from its paws.");
            Console.WriteLine("You feel as though you are about to become only a guest in your body. The plushie continues its barrage: 'You are in MY PLACE!'");
            Game.Transition<TearoomQu3>();
            if (GardenRabbitInteraction.Poisoned==true) { Console.WriteLine("You feel weak... Your stomach..."); }
            
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Press 1 to fight for control");
            Console.ForegroundColor = ConsoleColor.White;

        }
        }
    }



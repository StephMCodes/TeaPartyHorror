using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using TeaPartyHorror_Game.Rooms.MinigameQuestions;
using static TeaPartyHorror_Game.Program;

namespace TeaPartyHorror_Game.Rooms
{
    internal class Garden : Room
    {
        internal static bool hasFlowers;
        
        internal override string CreateDescription() =>
       @"You can go back to the [ballroom] from here.";

        internal override void ReceiveChoice(string choice)
        {
            
            //no change text
            switch (choice)
            {
                case "ballroom":
                        Console.WriteLine("\nYou return to the ballroom, you see a piano strike the keys by a seemingly invisible force along with floating violins being played.");
                        Console.WriteLine("\nThe lady resembled your late mother. She lowered her gaze, yearning for a waltz.");
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine("Press 1 to invite her to dance");
                        Console.ForegroundColor = ConsoleColor.White;
                        Game.Transition<BallroomQu1>();
                    break;
                case "1":
                    Console.WriteLine("\nThe older man softens as he hears your story.");
                    Console.WriteLine("\n'My sweet, darling Rosalind! I cannot be there with her for I am but a lowly worker, unbefitting to hold a noblewoman's hand... ");
                    Console.WriteLine("\nPlease, take good care in bringing her these.");
                    Console.WriteLine("\nShe will know my love persists, even if I am not there beside her.' ");
                    hasFlowers = true;
                    Inventory.AddItem(GameItem.Flowers);
                    var bf = new BinaryFormatter();
                    FileStream stream = File.OpenWrite(Program.SaveFile);
                    savedata.hasFlowers = true;
                    bf.Serialize(stream, savedata);
                    stream.Close();
                    Game.Transition<GardenRabbitInteraction>();
                    break;
                case "2":

                    Console.WriteLine("\n'HEY! I told you to stay away from those! Oleanders are not for silly children.");
                    Game.IncreaseFear(1);
                    Console.WriteLine("\nEmbarassed, you tell your story...");
                    Console.WriteLine("\nThe older man softens as he listens.");
                    Console.WriteLine("\n'My sweet, darling Rosalind! I cannot be there with her for I am but a lowly worker, unbefitting to hold a noblewoman's hand...");
                    Console.WriteLine("\nPlease, take good care in bringing her these. ");
                    Console.WriteLine("\nShe will know I love her still, even if I am not there.' "); 
                    
                    Inventory.AddItem(GameItem.Flowers);
                    hasFlowers = true;
                    Game.Transition<GardenRabbitInteraction>();
                    break;
                default:
                    //Console.WriteLine("Invalid command.");
                    //text is fixed do not change
                    Console.WriteLine("\nYou enjoy the view as you descend the marble stairs to the garden that remains colourful even in moonbathed darkness.");
                    Console.WriteLine("\nThere is a gardener ghost, a sullen man tending to pink flowers that smell of peaches.");
                    Console.WriteLine("\nYou approach him, and he grumblesat you to back away from his oleanders. "); 

                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("Press 1 to explain the problem and ask for flowers\t\tPress 2 to steal some when he is not looking");
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
            }
        }

    }

}


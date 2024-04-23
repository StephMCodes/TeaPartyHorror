using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeaPartyHorror_Game.Rooms.MinigameQuestions;
using static TeaPartyHorror_Game.Program;
using System.Diagnostics.Eventing.Reader;
using System.Runtime.Serialization.Formatters.Binary;

namespace TeaPartyHorror_Game.Rooms
{
    internal class Start : Room
    {
        static bool isFinished;

        internal override string CreateDescription()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            return "\nWELCOME TO TEA PARTY HORROR" +
                "\r\n\r\nYou are an orphaned young girl, adopted recently by your wealthy aunt and uncle." +
                "\r\nThey have no other children in the mansion, so you must make your own entertainment and play by yourself." +
                "\r\nThankfully, the house is full of spirits only you seem to notice..." +
                "\r\n\r\nWRITE START TO BEGIN";
        }
        internal override void ReceiveChoice(string choice)
        {
            // Display current Foreground color 
            //Console.WriteLine("Default Foreground Color: {0}", Console.ForegroundColor);

            // Set the Foreground color to blue 
            //Console.ForegroundColor
            // = ConsoleColor.Blue; 
            Console.ForegroundColor = ConsoleColor.White;

            switch (choice.ToUpper())
            {
                case "START":
                    {

                        //if (Program.savedata.saveRoom == "Bedroom")
                        //{
                        //    Game.Transition<BedroomAwake>();
                        //    break;
                        //}
                        //if (Program.savedata.saveRoom == "Hallway")
                        //{
                        //    Game.Transition<Hallway>();
                        //    break;
                        //}
                        if (savedata.hasMrBunnyRabbit == true)
                        {
                            Game.Transition<BedroomAwake>();
                        }
                        else
                        {

                            Console.WriteLine("\nYou jump out your bed, startled by the smell of smoke. ");
                            Console.WriteLine("\nThe door handle is warm to the touch, but you need to warn your parents. ");
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            Console.WriteLine("Press 1 to run inside and look for your parents\t\tPress 2 to climb out your window");
                            Console.ForegroundColor = ConsoleColor.White;

                            Game.Transition<BurningHouse>();
                        }
                    }
                        break;
                    
                case"DIE":
                        Game.IncreaseFear(10);
                    break;
                
                
                default:
                    Console.WriteLine("\nInvalid command.");
                    break;
            }
        }
    }
}

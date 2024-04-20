using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeaPartyHorror_Game.Rooms.MinigameQuestions;

namespace TeaPartyHorror_Game.Rooms
{
    internal class Start : Room
    {
        static bool isFinished;

        internal override string CreateDescription()
        {
            Console.ForegroundColor= ConsoleColor.Magenta;
            return "\nWELCOME TO TEA PARTY HORROR" +
                "\r\n\r\nYou are an orphaned young girl, adopted recently by your wealthy aunt and uncle." +
                "\r\nThey have no other children in the mansion, so you must make your own entertainment and play by yourself." +
                "\r\nThankfully, the house is full of spirits only you seem to notice..." + 
                "\r\n\r\nENTER START TO BEGIN"; 
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
                        //ask calvin + 4squad if press or enter
                        Console.WriteLine("You jump out your bed, startled by the smell of smoke. The door handle is warm to the touch, but you need to warn your  parents.");
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine("Press 1 to run inside and look for your parents\t\tPress 2 to climb out your window");
                        Console.ForegroundColor = ConsoleColor.White;
                        Game.Transition<BurningHouse>();
                        break;
                    }
                
                default:
                    Console.WriteLine("Invalid command.");
                    break;
            }
        }
    }
}

using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeaPartyHorror_Game.Rooms
{
    internal class End : Room
    {
        internal override string CreateDescription()
        {
            File.Delete(Program.SaveFile); 
            Game.Finish(); 

            Console.ForegroundColor = ConsoleColor.Magenta;
            string[] creators = 
                { "BELLA PEREZ", "STEPHANIE MICHIU" };
            string thankYouMessage = "\nTHANK YOU FOR PLAYING TEA PARTY HORROR\nCreators:\n";

            foreach (var creator in creators)
            {
                thankYouMessage += creator + "\n";
            }
            Console.ResetColor(); 
            return thankYouMessage;
        }
        internal override void ReceiveChoice(string choice)
        {
           
        }
    }
}



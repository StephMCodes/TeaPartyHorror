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
            File.Delete(Program.SaveFile); //correct spot
            Game.Finish();
            Console.ForegroundColor = ConsoleColor.Magenta;
            return "\nTHANK YOU FOR PLAYING TEA PARTY HORROR\nCreators:\nBELLA PEREZ\nSTEPHANIE MICHIU";


        }
        
       
        internal override void ReceiveChoice(string choice)
        {
            
            
        }
    }
}

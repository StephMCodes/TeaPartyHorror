using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeaPartyHorror_Game.Rooms.MinigameQuestions
{
    internal class DiningRoomQ2 :Room
    {
        internal override string CreateDescription() =>
       @"There is a smell of sweet treats, waiting to be eaten by hungry children. From the dining room, you can leave to the [hallway].";

        internal override void ReceiveChoice(string choice)
        {
            switch (choice.ToLower())
            {
                case "1":
                    Console.WriteLine("good");
                    break;

                case "2":
                    Console.WriteLine("bad");
                    break;
            }


        }
    }
}

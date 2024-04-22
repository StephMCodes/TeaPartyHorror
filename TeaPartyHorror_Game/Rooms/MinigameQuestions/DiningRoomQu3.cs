using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using static TeaPartyHorror_Game.Program;

namespace TeaPartyHorror_Game.Rooms.MinigameQuestions
{
    internal class DiningRoomQu3 : Room

    {
        internal static bool snackReceived;

        //public override void OnRoomEnter()
        //{
        //    //Game.items.Add(GameItem.Snack);
        //}

        internal override string CreateDescription() => @"";
        internal override void ReceiveChoice(string choice)
        {
            
            //Console.WriteLine("Question text");
            switch (choice.ToLower())
            {
                case "1":
                    Console.WriteLine("'No problem, dearie,' replies the dining room's ghost.");
                    
                    Inventory.AddItem(GameItem.Snack);
                    var bf = new BinaryFormatter();
                    bf.Serialize(File.OpenWrite(Program.SaveFile), savedata);

                    
                    savedata.snackReceived = true;
                    Game.Transition<DiningRoomComplete>();
                    snackReceived=true;
                    break;
                case "2":
                    Console.WriteLine("The dining room's ghost regards you angrily, moving a finger.Before you know it, a knife wooshes past you, narrowly     missing your face.");
                    Game.IncreaseFear(1);
                    Console.WriteLine("The ghost gives you the snack...begrudgingly.");
                    Inventory.AddItem(GameItem.Snack);
                    //Inventory.items.Add(GameItem.Snack);
                    Game.Transition<DiningRoomComplete>();
                    snackReceived=true;
                    break;
                

            }
        }
    }
}

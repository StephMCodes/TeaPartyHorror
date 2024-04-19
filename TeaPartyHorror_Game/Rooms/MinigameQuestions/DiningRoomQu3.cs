﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                    Console.WriteLine("The ghost approves");
                    Console.WriteLine("The ghost gives you the snack");
                    Inventory.items.Add(GameItem.Snack);
                    Game.Transition<DiningRoomComplete>();
                    snackReceived=true;
                    break;
                case "2":
                    Console.WriteLine("The ghost does NOT approve");
                    Game.IncreaseFear(1);
                    Console.WriteLine("The ghost gives you the snack...begrudgingly");
                    Inventory.items.Add(GameItem.Snack);
                    Game.Transition<DiningRoomComplete>();
                    snackReceived=true;
                    break;
                default:
                    
                    
                    break;

            }
        }
    }
}

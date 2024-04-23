using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeaPartyHorror_Game.Rooms.MinigameQuestions;

namespace TeaPartyHorror_Game.Rooms
{
    internal class GardenComplete : Room
    {
        internal override string CreateDescription() =>
      @"You can't see the gardener ghost, but you do hear him happily humming a waltz somewhere in the shrubbery. You can go backto the [ballroom] from here.";

        internal override void ReceiveChoice(string choice)
        {
            if (Hallway.ownsInvitation == false && BallroomQu4.hasDanced == true && DiningRoomQu3.snackReceived == true)
            {
                Console.WriteLine("\n'CAW, CAW!'");
                Console.WriteLine("\nYou are about to scream when a crow appears out of nowhere, heading straight for you.");
                Console.WriteLine("\nYour plushie jumps to hug you and calms you down. 'Dont worry, he is a friend!'");
                Console.WriteLine("\nThe bird gently alights on your shoulder, claws careful not to poke you. There is a letter in his beak!");
                Inventory.AddItem(GameItem.Invitation);
                Hallway.ownsInvitation = true;

            }
            switch (choice)
            {
                case "ballroom":
                    Console.WriteLine("\nYou make your way to the ballroom, the one-two-three rhythm still playing in your head.");
                    Game.Transition<Ballroom>();
                    break;
                
            }
        }
    }
}

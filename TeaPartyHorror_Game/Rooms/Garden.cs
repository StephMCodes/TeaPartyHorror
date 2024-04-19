using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeaPartyHorror_Game.Rooms.MinigameQuestions;

namespace TeaPartyHorror_Game.Rooms
{
    internal class Garden : Room
    {
        internal static bool HasFlowers;
        
        internal override string CreateDescription() =>
       @"You can go back to the [ballroom] from here.";

        internal override void ReceiveChoice(string choice)
        {
            if (Hallway.ownsInvitation == false && BallroomQu4.hasDanced == true && DiningRoomQu3.snackReceived == true)
            {
                Console.WriteLine("'CAW, CAW!'");
                Console.WriteLine("You are about to scream when a crow appears out of nowhere, heading straight for you.");
                Console.WriteLine("Your plushie jumps to hug you and calms you down. 'Dont worry, he is a friend!'");
                Console.WriteLine("The bird gently alights on your shoulder, claws careful not to poke you. There is a letter in his beak!");
                Inventory.items.Add(GameItem.Invitation);
                Hallway.ownsInvitation = true;

            }
            //no change text
            switch (choice)
            {
                case "ballroom":
                        Console.WriteLine("You return to the ballroom, you see a piano strike the keys by a seemingly invisible force along with floating violins being played.");
                        Console.WriteLine(" The lady resembled your late mother. She lowered her gaze, yearning for a waltz.");
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine("Press 1 to invite her to dance");
                        Console.ForegroundColor = ConsoleColor.White;
                        Game.Transition<BallroomQu1>();
                    break;
                case "1":
                    Console.WriteLine("The older man softens as he hears your story." +
                        "'My sweet, darling Rosalind! I cannot be there with her for I am but a     lowly worker,unbefitting to hold a noblewoman's hand..." +
                        "Please, take good care in bringing her these." +
                        " She will know my   love persists, even if I am not there beside her.'");
                    Console.WriteLine("You receive a lovely bouquet.");
                    HasFlowers = true;
                    Inventory.items.Add(GameItem.Flowers);
                    Game.Transition<GardenRabbitInteraction>();
                    break;
                case "2":

                    Console.WriteLine("'HEY! I told you to stay away from those! Oleanders are not for silly children.");
                    Game.IncreaseFear(1);
                    Console.WriteLine("Embarassed, you tell your story...");
                    Console.WriteLine("The older man softens as he listens." +
                        "'My sweet, darling Rosalind! I cannot be there with her for I am but a lowly worker,unbefitting to hold a noblewoman's hand..." +
                        "Please, take good care in bringing her these." +
                        " She will know I love her still, even if I am not there.'");
                    Console.WriteLine("You receive a lovely bouquet.");
                    HasFlowers = true;
                    Game.Transition<GardenRabbitInteraction>();
                    break;
                default:
                    //Console.WriteLine("Invalid command.");
                    //text is fixed do not change
                    Console.WriteLine("You enjoy the view as you descend the marble stairs to the garden that remains colourful even in moonbathed darkness.");
                    Console.WriteLine("There is a gardener ghost, a sullen man tending to pink flowers that smell of peaches. You approach him, and he grumblesat you to back away from his oleanders. ");

                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("Press 1 to explain the problem and ask for flowers\t\tPress 2 to steal some when he is not looking");
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
            }
        }

    }

}


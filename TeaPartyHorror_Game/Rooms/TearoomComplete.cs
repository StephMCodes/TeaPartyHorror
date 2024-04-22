using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeaPartyHorror_Game.Rooms
{
    internal class TearoomComplete : Room
    {
        internal override string CreateDescription() =>
@"You are in the tearoom complete";
        internal override void ReceiveChoice(string choice)
        {
            switch (choice)
            {
                case "1":
                    Console.WriteLine("You violently rip up your plushie, tears in your eyes. The plushie yells, 'NO! MY HOUSE, MY ROOM, MY-'");
                    Console.WriteLine("One final tear, and it stops moving. A cold draft passes through the room, destroying everything in sight..!");
                    Console.WriteLine("Finally, it ends, and you are left in a destroyed tearoom. The spirit is gone.");
                    Console.WriteLine("*");
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("NEUTRAL ENDING - [Press enter to continue.]");
                    Game.Transition<End>();
                    break;
                case "2":
                    Console.WriteLine("You take her in your arms, and feel the spirit's power begin to fade as she cries, magical tears falling from bead eyes.");
                    Console.WriteLine("'They said I was going to be okay... But I was bedridden for weeks before...' she trails off admist the sobs. 'Im not ready to go... I want to play teahouse, one last time. Please.");
                    Console.WriteLine("You spend half an hour playing with the spirit, until she calms down. 'Thank you... Take care of my family, of my... OUR Mama and Papa.'");
                    Console.WriteLine("As you promise to give them a big hug for her, she promises to give yours one too in the sky. 'Take care, Sister!'");
                    Console.WriteLine("*");
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("GOOD ENDING - [Press enter to continue.]");
                    Game.Transition<End>();
                    break;
                default:
                    if (GardenRabbitInteraction.Poisoned == true)
                    {
                        Console.WriteLine("You feel as if though you are about to faint...");
                        Console.WriteLine("Your plushie laughs maniacally, but there is a hint of bitterness. 'Oleanders! Poisonous! I did not know, either. Else I would reduced to this!'");
                        Game.IncreaseFear(2);
                    }
                    else
                    {
                        Console.WriteLine("You succeed, finding strength within.");
                        Console.WriteLine("Your plushie laughs maniacally, but there is a hint of bitterness. 'Oleanders! Poisonous! Shame you did not fall for it like I did. Reduced to this..!'");
                    }
                    Console.WriteLine("You recall a past child of this family that died of sickness... Ophelia.");
                    Console.WriteLine("When you call her by that name, the spirit loses focus. Now is your chance!");
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("Press 1 to tear your plushie up \t\tPress 2 to hug her and tell her everything is going to be okay");
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
            }
        }
    }
}

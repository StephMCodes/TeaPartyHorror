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
@"";
        internal override void ReceiveChoice(string choice)
        {
            switch (choice)
            {
                case "1":
                    Console.WriteLine("\nYou violently rip up your plushie, tears in your eyes.");
                    Console.WriteLine("\nThe plushie yells, 'NO! MY HOUSE, MY ROOM, MY-'");
                    Console.WriteLine("\nOne final tear, and it stops moving.");
                    Console.WriteLine("\nA cold draft passes through the room, destroying everything in sight..!"); 
                    Console.WriteLine("\nFinally, it ends, and you are left in a destroyed tearoom. The spirit is gone.");
                    Console.WriteLine("\nYou wonder about her, the young girl who just wanted to loved more than anything wreaking havoc beyond the grave.");
                    Console.WriteLine("\n'You don't have to worry anymore', you express.");
                    Console.WriteLine("\n'Please rest peacefully now', kissing her cheek goodbye.");
                    Console.WriteLine("*");
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("\nNEUTRAL ENDING - [Press enter to continue.]");
                    Game.Transition<End>();
                    break;
                case "2":
                    Console.WriteLine("\nYou take her in your arms, and feel the spirit's power begin to fade as she cries, magical tears falling from bead eyes.");
                    Console.WriteLine("\n'They said I was going to be okay... But I was bedridden for weeks before...' she trails off admist the sobs. ");
                    Console.WriteLine("\n'Im not   ready to go... I want to play teahouse, one last time. Please. ");
                    Console.WriteLine("\nYou spend half an hour playing with the spirit, until she calms down. ");
                    Console.WriteLine("\n'Thank you... Take care of my family, of my...OUR Mama and Papa.' ");
                    Console.WriteLine("\nAs you promise to give them a big hug for her, she promises to give yours one too in the sky. ");
                    Console.WriteLine("\n'Take care, Sister!'");
                    Console.WriteLine("*");
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("\nGOOD ENDING - [Press enter to continue.]");
                    Game.Transition<End>();
                    break;
                default:
                    if (GardenRabbitInteraction.Poisoned == true)
                    {
                        Console.WriteLine("\nYou feel as if though you are about to faint...");
                        Console.WriteLine("\nYour plushie laughs maniacally, but there is a hint of bitterness. ");
                        Console.WriteLine("\n'Oleanders! Poisonous! I did not know, either. Else I would reduced to this!' ");
                        Game.IncreaseFear(2);
                    }
                    else
                    {
                        Console.WriteLine("\nYou succeed, finding strength within.");
                        Console.WriteLine("\nYour plushie laughs maniacally, but there is a hint of bitterness. ");
                        Console.WriteLine("\n'Oleanders! Poisonous! Shame you did not fall for it like I did. Reduced to this..!' ");
                    }
                    Console.WriteLine("\nYou recall a past child of this family that died of sickness... Ophelia.");
                    Console.WriteLine("\nWhen you call her by that name, the spirit loses focus. Now is your chance!");
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("Press 1 to tear your plushie up \t\tPress 2 to hug her and tell her everything is going to be okay");
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
            }
        }
    }
}

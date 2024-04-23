using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using TeaPartyHorror_Game.Rooms.MinigameQuestions;
using static TeaPartyHorror_Game.Program;

namespace TeaPartyHorror_Game.Rooms
{
    internal class MUTBSnackInteraction : Room
    {
        internal static bool isMonsterFriend;
        internal override string CreateDescription() =>
       @"From your new bedroom, there is the [hallway] that leads to the rest of the mansion, and you hear strange noises under  your [bed].";

        internal override void ReceiveChoice(string choice)
        {
            //Console.WriteLine("Question text");
            switch (choice.ToLower())
            {
                case "1":
                    Console.WriteLine("\nYou carefully approach your snack towards the bed, and the monster immediately swipes it with surprising speed." );
                    Console.WriteLine("\nYou hearchewing noises, grumbling, and finally, a loud belch.");
                    Console.WriteLine("\nMr Bunny-Rabbit makes a face. 'And now what do we say..?'");
                    Console.WriteLine("\n'Excuse me.' The monster pokes his head from under his hiding place, and you can discern a smile from the darkness.");
                    Console.WriteLine("\n'Thaaaaank youuuuu... I promise only to eat your bad dreams from now on."); 
                    isMonsterFriend = true;
                    Inventory.UseItem(GameItem.Snack);
                    var bf = new BinaryFormatter();
                    FileStream stream = File.OpenWrite(Program.SaveFile);
                    savedata.isMUTBfriend = true;
                    bf.Serialize(stream, savedata);
                    stream.Close();
                    Game.Transition<BedroomAwake>();
                    break;
                case "2":
                    Console.WriteLine("\nYou back away, clutching your snack close to your chest. ");
                    Console.WriteLine("\nNo one shall take it from you!"); 
                    Game.Transition<BedroomAwake>();
                    break;
                
            }
        }
    }
}

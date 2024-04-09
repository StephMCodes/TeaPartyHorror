using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using TeaPartyHorror_Game.Rooms;

namespace TeaPartyHorror_Game
{
    internal class Program
    {
        [Serializable]
        public class SaveData
        {
            public int numbertToSave;
            public string stringToSave;

            public SaveData(int numberToSave, string stringToSave)
            {
                this.numbertToSave = numberToSave;
                this.stringToSave = stringToSave;
            }
        }

        static SaveData savedata;
        static void Main(string[] args)
        {
            
            var game = new Game();
            game.Add(new Start());
            game.Add(new BurningHouse());
            game.Add(new Bedroom());
            game.Add(new Hallway());
            game.Add(new Kitchen());
            game.Add(new Ballroom());
            game.Add(new Garden());
            game.Add(new Tearoom());


            while (!game.IsGameOver())
            {
                Console.WriteLine("--");
                Console.WriteLine(game.CurrentRoomDescription);
                string choice = Console.ReadLine().ToLower() ?? "";
                Console.Clear();
                game.ReceiveChoice(choice);
            }

            Console.WriteLine("END");
            Console.ReadLine();
            const string SaveFile = "Save.txt";
            if (!File.Exists(SaveFile))
            { File.CreateText(SaveFile); }

            //savedata = new SaveData(200, "Felix");
            var bf = new BinaryFormatter();
            //bf.Serialize(File.OpenWrite(SaveFile), savedata);
            savedata=bf.Deserialize(File.OpenRead(SaveFile)) as SaveData;

            // From Felix
            Console.WriteLine("Hello World");
            //BELLA IS STRUGGLING no more
        }
    }
}

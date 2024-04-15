using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using TeaPartyHorror_Game.Rooms;
using TeaPartyHorror_Game.Rooms.MinigameQuestions;

namespace TeaPartyHorror_Game
{
    internal class Program
    {
        [Serializable]
        public class SaveData
        {
            public int numberToSave;
            public string stringToSave;

            public SaveData(int numberToSave, string stringToSave)
            {
                this.numberToSave = numberToSave;
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
            game.Add(new BedroomAwake());
            game.Add(new Hallway());
            game.Add(new DiningRoom());
<<<<<<< Updated upstream
=======
            game.Add(new DiningRoomQ1());
            game.Add(new DiningRoomQ2());
            game.Add(new DiningRoomQ3());
>>>>>>> Stashed changes
            game.Add(new Ballroom());
            game.Add(new Garden());
            game.Add(new Tearoom());
            game.Add(new Inventory());


            while (!game.IsGameOver())
            {
                Console.WriteLine("---");
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

        }
    }
}

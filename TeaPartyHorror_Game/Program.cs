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
            game.Add(new MUTBSnackInteraction());
            game.Add(new Hallway());
            game.Add(new DiningRoom());
            game.Add(new DiningRoomQu1());
            game.Add(new DiningRoomQu2());
            game.Add(new DiningRoomQu3());
            game.Add(new DiningRoomComplete());
            game.Add(new Ballroom());
            game.Add(new BallroomQu1());
            game.Add(new BallroomQu2());
            game.Add(new BallroomQu3());
            game.Add(new BallroomQu4());
            game.Add(new Garden());
            game.Add(new GardenRabbitInteraction());
            game.Add(new GardenComplete());
            game.Add(new TearoomQu1());
            //game.Add(new Inventory());



            while (!game.IsGameOver())
            {
                Console.WriteLine("---");
                Console.WriteLine(game.CurrentRoomDescription);
                string choice = Console.ReadLine().ToLower() ?? "";
                Console.Clear();
                game.ReceiveChoice(choice);
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("Check out your current [inventory]! ");
                Console.ForegroundColor = ConsoleColor.White;
            }

            Console.ForegroundColor = ConsoleColor.Red;
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

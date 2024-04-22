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


            public string saveRoom;
            public bool snackReceived;

            //public SaveData(int numberToSave, string stringToSave, string saveRoom bool boolToSave)
            //{
            //    this.numberToSave = numberToSave;
            //    this.stringToSave = stringToSave;
            //    this.saveRoom = saveRoom;
            //}
        }

        public static SaveData savedata;
        public const string SaveFile = "Save.txt";
        static void Main(string[] args)
        {

            //const string SaveFile = "Save.txt";
            {
                if (!File.Exists(SaveFile))
                {
                    File.CreateText(SaveFile);
                    savedata = new SaveData();
                }
                else
                {
                    var bf = new BinaryFormatter();
                    //bf.Serialize(File.OpenWrite(SaveFile), savedata); //save file
                    FileStream stream = File.OpenRead(SaveFile);
                    if (stream.Length > 0)
                    {
                        savedata = bf.Deserialize(stream) as SaveData; //load file
                    }
                    else
                    {
                        savedata = new SaveData();
                    }
                    stream.Close();
                }
            }
            Console.WriteLine($"Has snack = {savedata.snackReceived}");

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
            game.Add(new TearoomQu2());
            game.Add(new TearoomQu3());
            game.Add(new TearoomComplete());
            game.Add(new End());
            //game.Add(new Inventory());



            while (!game.IsGameOver())
            {
                Console.WriteLine("---");
                Console.WriteLine(game.CurrentRoomDescription);
                string choice = Console.ReadLine().ToLower() ?? "";
                Console.Clear();
                game.ReceiveChoice(choice);
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("\nCheck out your current [inventory]! ");
                Console.ForegroundColor = ConsoleColor.White;
            }

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("The fear overwhelms you, leading to a game over.");
            Console.WriteLine("*");
            Console.WriteLine("BAD ENDING - [Press enter to quit.]");
            Game.Transition<End>();

            //Console.Clear();
            Console.ReadLine();
            //const string SaveFile = "Save.txt";
            //if (!File.Exists(SaveFile))
            //{ File.CreateText(SaveFile); }
            // File.WriteAllText("Save.txt", "Hello world");



        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Pipes;
using System.Runtime.InteropServices.ComTypes;
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
            public bool hasDanced;
            public bool hasFlowers;
            public bool hasMrBunnyRabbit;
            public int fearLevel;
            public bool isMUTBfriend;
            public bool ownsInvitation;
            public bool isPoisoned;
            //public Room lastRoom;


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
                        stream.Close();
                    }
                    else
                    {
                        savedata = new SaveData();
                        stream.Close();
                    }
                    stream.Close();
                    if (File.Exists(Program.SaveFile))
                    {
                        Console.WriteLine("\nItems from continued savefile:");
                        if (savedata.snackReceived == true && savedata.isMUTBfriend==false)
                        {
                            Inventory.AddItem(GameItem.Snack);
                            DiningRoomQu3.snackReceived = true;
                        }
                        if (savedata.snackReceived == true && savedata.isMUTBfriend == true)
                        {
                            DiningRoomQu3.snackReceived = true;
                        }
                        if (savedata.hasDanced == true)
                        {
                            Inventory.AddItem(GameItem.Amulet);
                            BallroomQu4.hasDanced = true;
                        }
                        if (savedata.hasFlowers == true)
                        {
                            Inventory.AddItem(GameItem.Flowers);
                            Garden.hasFlowers = true;
                        }
                        if (savedata.hasMrBunnyRabbit == true)
                        {
                            Inventory.AddItem(GameItem.MrBunnyRabbit);
                            Bedroom.hasMrBunnyRabbit = true;
                        }
                        if (savedata.ownsInvitation == true)
                        {
                            Inventory.AddItem(GameItem.Invitation);
                            Hallway.ownsInvitation = true;
                        }
                        if (savedata.isPoisoned == true)
                        {
                            GardenRabbitInteraction.Poisoned = true;
                        }
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("\nCurrent fear level:"); Console.WriteLine(savedata.fearLevel);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nLatest room location: "); Console.WriteLine(savedata.saveRoom);
                        //Console.WriteLine("You wake up from your nap in your bedroom again...");
                        //Game.Transition<BedroomAwake>();
                        stream.Close();
                    }
                    stream.Close();
                    
                } 
                
                

                //Console.WriteLine($"Has snack = {savedata.snackReceived}");

                
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




                while (!game.IsGameOver())
                {
                    Console.WriteLine("-----");
                    Console.WriteLine(game.CurrentRoomDescription);
                    string choice = Console.ReadLine().ToLower() ?? "";
                    Console.Clear();
                    game.ReceiveChoice(choice);
                    var bf = new BinaryFormatter();
                    FileStream stream = File.OpenWrite(Program.SaveFile);
                    savedata.saveRoom = choice;
                    bf.Serialize(stream, savedata);
                    stream.Close();
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("\nCheck out your current [inventory]! ");
                    Console.ForegroundColor = ConsoleColor.White;
                    if (Game.fearLevel >= 10)
                    {

                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("The fear overwhelms you, leading to a game over.");
                        Console.WriteLine("*");
                        Console.WriteLine("BAD ENDING - [Press enter to quit.]");
                        File.Delete(SaveFile);
                        Game.Transition<End>();



                    }

                }

                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("The fear overwhelms you, leading to a game over.");
                Console.WriteLine("*");
                Console.WriteLine("BAD ENDING - [Press enter to quit.]");
                File.Delete(SaveFile);
                Game.Transition<End>();

                //Console.Clear();
                //Console.ReadLine(); //
                //const string SaveFile = "Save.txt";
                //if (!File.Exists(SaveFile))
                //{ File.CreateText(SaveFile); }
                // File.WriteAllText("Save.txt", "Hello world");



            }
        }
    }
}

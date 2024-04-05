using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

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

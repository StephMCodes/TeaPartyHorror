using System;

namespace TeaPartyHorror_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {

            if (!File.Exists("Save.txt"))
            { File.CreateText("Save.txt"); }
            File.WriteAllText("Save.txt", "Hello World");
            // From Felix
            Console.WriteLine("Hello World");
            //BELLA IS STRUGGLING no more
        }
    }
}

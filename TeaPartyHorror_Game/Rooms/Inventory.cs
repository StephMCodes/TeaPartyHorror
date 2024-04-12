using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeaPartyHorror_Game.Rooms
{
    internal class Inventory : Room
    {
        internal override string CreateDescription()
        {
            throw new NotImplementedException(); //unsure if i should place this intellicode
        }

        internal override void ReceiveChoice(string choice)
        {
            throw new NotImplementedException(); //unsure if i should place this intellicode
        }

        public abstract class Item
        {
            public abstract string Name { get; set; }
            public abstract void Use();
        }
        public class Snack : Item //smt needs to be fixed here 
        {
            private static readonly string[] snackTypes = { "strawberry", "cookie", "brownie" };
            public Snack()
            {
                Random rnd = new Random();
                Name = snackTypes[rnd.Next(snackTypes.Length)] + "snack";
            }

            public override void Use()
            {
                Console.WriteLine($"Using{Name}.");

            }
        }
    }
}

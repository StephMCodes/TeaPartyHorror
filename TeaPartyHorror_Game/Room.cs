using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeaPartyHorror_Game
{
    internal abstract class Room //this is what all rooms will be taking from. Made abstract to not actually use "room" and only use its children.
    {
        internal abstract string CreateDescription();
        internal abstract void ReceiveChoice(string choice);
        ////these abstract methods get overridden in each room.
        //public virtual void OnRoomEnter() { }
        //internal abstract void RoomEnter(string choice);

        ////each room needs a text desc.
        //internal abstract string CreateDescription();
        ////each room needs to be able to take your choice
        //internal abstract void ReceiveChoice(string choice);
    }
}

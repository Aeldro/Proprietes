using System;
using System.Collections.Generic;
using System.Linq;

namespace Proprietes
{
    public class Program
    {
        public static void Main(string[] args)
        {
            House house = new House();
            Room room = new Room();
            Door houseDoor = new Door();
            Door roomDoor = new Door();
            house.Doors.Add(houseDoor);
            room.Doors.Add(roomDoor);
            house.Rooms.Add(room);
        }
    }
}
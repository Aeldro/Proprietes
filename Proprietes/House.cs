using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proprietes
{
    public class House
    {
        public List<Room> Rooms { get; }
        public List<Door> Doors { get; }

        public House()
        {
            Rooms = new List<Room>();
            Doors = new List<Door>();
        }
    }
}

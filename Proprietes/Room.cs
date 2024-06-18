using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proprietes
{
    public class Room
    {
        public List<Door> Doors { get; }

        public Room()
        {
            Doors = new List<Door>();
        }
    }
}

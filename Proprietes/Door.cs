using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proprietes
{
    public class Door
    {
        public bool _isOpen;

        public Door()
        {
            _isOpen = false;
        }

        public void Open()
        {
            if (_isOpen)
            {
                Console.WriteLine("Door already opened. Ain't done anything.");
            }
            else
            {
                _isOpen = true;
            }
        }

        public void Close()
        {
            if (!_isOpen)
            {
                Console.WriteLine("Door already closed. Ain't done anything.");
            }
            else
            {
                _isOpen = false;
            }
        }
    }
}

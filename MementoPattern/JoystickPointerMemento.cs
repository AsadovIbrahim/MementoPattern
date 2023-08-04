using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoPattern
{
    public class JoystickPointerMemento
    {
        public int X { get; set; }
        public int O { get; set; }

        public bool isPressed { get; set; }
    }
}

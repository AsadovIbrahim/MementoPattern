using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoPattern
{
    public class JoystickPointerOriginator
    {
        private JoystickPointerOriginator pointerOriginator;
        public int X { get; set; }
        public int O { get; set; }

        public bool isPressed { get; set; }

        public JoystickPointerOriginator()
        {
            pointerOriginator=new();
        }

        public void Save()
        {
            JoystickPointerMemento joystickPointerMemento = new JoystickPointerMemento();
            X= joystickPointerMemento.X;
            O= joystickPointerMemento.O;
            isPressed= joystickPointerMemento.isPressed;
        }
        public override string ToString()
        => $"X: {X}, O: {O}, Pressed: {isPressed}";
    }
}

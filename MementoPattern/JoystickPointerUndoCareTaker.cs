using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoPattern
{
    public class JoystickPointerUndoCareTaker
    {
        private Stack<JoystickPointerMemento> joystickPointerMementos;

        public JoystickPointerUndoCareTaker()
        {
            joystickPointerMementos = new Stack<JoystickPointerMemento>();
        }

        public JoystickPointerMemento JoystickPointerMemento
        {
            get
            {
                return joystickPointerMementos.Pop();
            }
            set
            {
                joystickPointerMementos.Push(value);
            }
        }
    }
}

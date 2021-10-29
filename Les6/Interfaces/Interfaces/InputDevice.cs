using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class InputDevice : IInputDevice
    {
        public float GetHorizontalAnalog()
        {
            throw new NotImplementedException();
        }

        public bool IsDown(GameButton button)
        {
            if(Console.KeyAvailable)
            {
                switch(button)
                {
                    case GameButton.JUMP:
                        if (Console.ReadKey().Key == ConsoleKey.Spacebar) return true;
                        break;
                }
            }

            return false;
        }
    }
}

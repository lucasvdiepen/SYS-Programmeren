using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public class PlayerController : ICharacterController
    {
        private IInputDevice inputDevice;

        public PlayerController(IInputDevice inputDevice)
        {
            this.inputDevice = inputDevice;
        }

        public void Logic(float frameTime)
        {
            if(inputDevice.IsDown(GameButton.JUMP))
            {
                Console.WriteLine("Player pressed jump button");
            }
        }

        public void SetCharacter(ICharacter character)
        {
            throw new NotImplementedException();
        }
    }
}

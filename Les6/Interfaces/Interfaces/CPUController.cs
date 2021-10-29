using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class CPUController : ICharacterController
    {
        //Gebruik random om dingen te doen

        public void Logic(float frameTime)
        {
            throw new NotImplementedException();
        }

        public void SetCharacter(ICharacter character)
        {
            throw new NotImplementedException();
        }
    }
}

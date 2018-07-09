using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
   abstract class Colleage
    {
        protected Mediator mediator;
        public Colleage(Mediator mediator)
        {
            this.mediator = mediator;
        }

    }
}

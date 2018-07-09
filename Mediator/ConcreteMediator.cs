using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    class ConcreteMediator : Mediator
    {
        public ConcreteColleage1 Colleage1 { get; set; }
        public ConcreteColleage2 Colleage2 { get; set; }
        public override void Send(string message, Colleage colleage)
        {
            if (colleage == Colleage1)
                Colleage1.Notify(message);
            else
                Colleage2.Notify(message);
        }
       
    }
}

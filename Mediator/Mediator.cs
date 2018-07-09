using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
   abstract class Mediator //仲介者
    {
        //發送消息方法 
        public abstract void Send(string message, Colleage colleage);
    }
}

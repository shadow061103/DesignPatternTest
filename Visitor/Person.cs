using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
   abstract class Person
    {
        //接受
        public abstract void Accept(Action visitor);
    }
}

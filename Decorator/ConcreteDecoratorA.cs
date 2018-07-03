using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class ConcreteDecoratorA: Decorator
    {
        private string addeState;
        public override void Operation()
        {
            base.Operation();
            addeState = "new State";
            Console.WriteLine("具體裝飾物件A的操作");
        }
    }
}

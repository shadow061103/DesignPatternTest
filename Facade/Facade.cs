using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    class Facade
    {
        SubSystem1 one;
        SubSystem2 two;
        SubSystem3 three;
        SubSystem4 four;

        public Facade()
        {
            one = new SubSystem1();
            two = new SubSystem2();
            three = new SubSystem3();
            four = new SubSystem4();
        }
        public void MethodA()
        {
            Console.WriteLine("方法組A");
            one.Method1();
            two.Method2();
            four.Method4();
        }
        public void MethodB()
        {
            Console.WriteLine("方法組B");
            
            two.Method2();
            three.Method3();
        }

    }
}

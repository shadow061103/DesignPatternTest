using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcreteMediator m = new ConcreteMediator();
            ConcreteColleage1 c1 = new ConcreteColleage1(m);//讓2個具體同事類別認識仲介者
            ConcreteColleage2 c2 = new ConcreteColleage2(m);

            m.Colleage1 = c1;
            m.Colleage2 = c2;

            c1.Send("今天吃什麼?");
            c2.Send("不知道");

            Console.ReadKey();

        }
    }
}

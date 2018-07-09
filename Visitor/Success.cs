using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    class Success : Action
    {
        public override void GetManConclusion(Man concreteElementA)
        {
            Console.WriteLine($"{concreteElementA.GetType().Name}{this.GetType().Name}時，背後多半有一個偉大的女人");
        }

        public override void GetWoManConclusion(Woman concreteElementA)
        {
            Console.WriteLine($"{concreteElementA.GetType().Name}{this.GetType().Name}時，背後大多有一個不成功的男人");
        }
    }
}

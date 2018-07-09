using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    class Failing : Action
    {
        public override void GetManConclusion(Man concreteElementA)
        {
            Console.WriteLine($"{concreteElementA.GetType().Name}{this.GetType().Name}時，悶頭喝酒，誰也不用勸");
        }

        public override void GetWoManConclusion(Woman concreteElementA)
        {
            Console.WriteLine($"{concreteElementA.GetType().Name}{this.GetType().Name}時，淚眼汪汪，誰也勸不了");
        }
    }
}

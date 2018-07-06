using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    class Leaf : Component
    {
        public Leaf(string name) : base(name)
        {
        }
        //葉子不會在增加分支 所以實現add和remove沒意義 但可以消除在抽象層式的區別
        public override void Add(Component c)
        {
            Console.WriteLine("cannot add to a leaf");
        }
        public override void Remove(Component c)
        {
            Console.WriteLine("cannot remove from a leaf");
        }
        public override void Display(int depth)
        {
            Console.WriteLine(new string('-', depth) + name);
        }
    }
}

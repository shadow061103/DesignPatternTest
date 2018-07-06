using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    class Composite : Component
    {
        private IList<Component> children = new List<Component>();
        public Composite(string name) : base(name)
        {
        }

        public override void Add(Component c)
        {
            children.Add(c);
        }

        public override void Display(int depth)
        {
            Console.WriteLine(new string('-',depth)+name);
            foreach (Component c in children)
                c.Display(depth + 2);
        }

        public override void Remove(Component c)
        {
            
            children.Remove(c);
        }
    }
}

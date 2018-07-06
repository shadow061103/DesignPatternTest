using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            Component root = new Composite("root");
            root.Add(new Leaf("leaf A"));
            root.Add(new Leaf("leaf B"));

            Component comp = new Composite("Composite X");
            comp.Add(new Leaf("leaf XA"));
            comp.Add(new Leaf("leaf XB"));

            root.Add(comp);

            Component comp2 = new Composite("Composite XY");
            comp2.Add(new Leaf("leaf XXA"));
            comp2.Add(new Leaf("leaf XXB"));

            comp.Add(comp2);

            root.Add(new Leaf("leaf C"));

            Leaf leaf = new Leaf("leaf D");
            root.Add(leaf);

            root.Remove(leaf);
            root.Display(1);

            Console.ReadKey();
        }
    }
}

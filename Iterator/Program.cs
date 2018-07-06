using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcreteAggregate a = new ConcreteAggregate();
            a[0] = "Abby";
            a[1] = "Kuan";
            a[2] = "小李";
            a[3] = "小王";
            a[4] = "小白";
            a[4] = "小偷";

            Iterator i = new ConcreteIterator(a);
            object item = i.First();
            while (!i.IsDone())
            {
                Console.WriteLine($"{i.CurrentItem()}請買票");
                i.Next();
            }
            Console.ReadKey();
        }
    }
}

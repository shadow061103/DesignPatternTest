using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            Director d = new Director();
            Builder b1 =new ConcreteBuild1();
            Builder b2 = new ConcreteBuild2();

            d.Construct(b1);
            Product p1 = b1.GetResult();
            p1.Show();

            d.Construct(b2);
            Product p2 = b2.GetResult();
            p2.Show();

            Console.ReadKey();
        }
    }
}

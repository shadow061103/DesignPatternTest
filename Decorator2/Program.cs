using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator2
{
    class Program
    {
        static void Main(string[] args)
        {
            //component 也可以改用interface
            Person p = new Person("Kuan");
            Console.WriteLine("第一種裝扮");
            Tshirt t = new Tshirt();
            Skirt s = new Skirt();
            BigTrouser b = new BigTrouser();
            t.Decorate(p);
            s.Decorate(t);
            s.Show();

            Console.WriteLine("第二種裝扮");
            b.Decorate(p);
            s.Decorate(b);
            t.Decorate(s);
            t.Show();

            Console.ReadKey();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Player a = new Forwards("James");
            a.Attack();

            Player b = new Guards("Kobe");
            b.Attack();

            Player c = new Translator("姚明");
            c.Attack();
            c.Defense();
            Console.ReadKey();
        }
    }
}

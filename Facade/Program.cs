using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            //迪米特法則加依賴倒置原則
            Facade fac = new Facade();
            fac.MethodA();
            fac.MethodB();
            Console.ReadKey();
        }
    }
}

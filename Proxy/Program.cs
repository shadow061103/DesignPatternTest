using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    class Program
    {
        static void Main(string[] args)
        {//webservice的參考也是代理模式

            SchoolGril yvonne = new SchoolGril();
            yvonne.Name = "Yvonne";
            Proxy kuan = new Proxy(yvonne);
            kuan.GiveChcoclate();
            kuan.GiveDools();
            kuan.GiveFlowers();
            Console.ReadKey();
        }
    }
}

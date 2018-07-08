using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    class Program
    {
        static void Main(string[] args)
        {
            //開店前準備
            Barbecuer boy = new Barbecuer();
            Command cmd1 = new BakeMuttonCommand(boy);
            Command cmd2 = new BakeMuttonCommand(boy);
            Command cmd3 = new BakeChickenWingCommand(boy);
            Waiter girl = new Waiter();

            //營業 點餐
            girl.SetOrder(cmd1);
            girl.SetOrder(cmd2);
            girl.SetOrder(cmd3);

            //點完通知廚房
            girl.Notify();
            Console.ReadKey();
        }
    }
}

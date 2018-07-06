using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer2
{
    class Program
    {
        static void Main(string[] args)
        {
            //缺點: A.抽象通知者還是依賴抽象觀察者
            //      B.具體觀察者不一定是Update方法要叫用
            //去掉抽象觀察者類別
            Boss boss = new Boss();
            BossEventArgs eventargs = new BossEventArgs() { Message = "燈愣!!" };
            StockObserver john = new StockObserver("john", boss);
            NBAObserver kevin = new NBAObserver("kevin", boss);

            boss.SubjectState = "老闆回來惹!";
            boss.UpdateEventHandler += new EventHandler(john.CloseStockMarket);
            boss.UpdateEventHandler += new EventHandler(kevin.CloseNBADirectSeeding);

            boss.Notify(eventargs);
            Console.ReadKey();
        }
    }
}

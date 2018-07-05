using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer2
{
    class StockObserver
    {
        private string name;
        private Subject sub;
        public StockObserver(string name, Subject sub)
        {
            this.name = name;
            this.sub = sub;
        }
        public void CloseStockMarket(object sender,EventArgs e)
        {
            string msg = (e as BossEventArgs).Message;
            Console.WriteLine(msg);
            Console.WriteLine($"{sub.SubjectState},{name}關閉股票行情，繼續工作");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class Program
    {
        
        static void Main(string[] args)
        {//還是工廠 CashFactory CashSuper會看到2個類別
            double total = 0d;
            CashSuper cs = CashFactory.createCashAccept("打8折");
            double totalprice = 0d;
            totalprice = cs.acceptCash(5000d)*5;//price*num
            total += totalprice;
            Console.WriteLine(total);

            //策略模式 只需要一個CashContext類別 收費演算法跟用戶端分離
            CashContext cc = null;
            cc = new CashContext("打8折");
             totalprice = 0d;
            totalprice = cc.GetResult(5000)*5;
            total += totalprice;
            Console.WriteLine(total);

            Console.ReadKey();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
   public abstract class CashSuper //收取現金的抽象方法
    {
        public abstract double acceptCash(double money);//參數原價 傳回現價
    }
}

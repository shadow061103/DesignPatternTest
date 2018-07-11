using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
   public class CashContext
    {
        private CashSuper cs;
        public CashContext(string type)
        {
            
            switch (type)
            {
                case "正常收費":
                    cs = new CashNormal();
                    
                    break;
                case "滿300送100":
                    cs = new CashReturn("300", "100");
                    
                    break;
                case "打8折":
                    cs = new CashRebate("0.8");
                   
                    break;
            }

        }
        public double GetResult(double money)
        {
            return cs.acceptCash(money);
        }
    }
}

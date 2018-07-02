﻿using System;
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
                    CashNormal cs0 = new CashNormal();
                    cs = cs0;
                    break;
                case "滿300送100":
                    CashReturn cs1 = new CashReturn("300", "100");
                    cs = cs1;
                    break;
                case "打8折":
                    CashRebate cs2 = new CashRebate("0.8");
                    cs = cs2;
                    break;
            }

        }
        public double GetResult(double money)
        {
            return cs.acceptCash(money);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
   public class CashNormal :CashSuper
    {
        public override double acceptCash(double money)
        {
            return money;//正常收費
        }
    }
}

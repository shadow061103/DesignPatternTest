using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    class Proxy:IGiveGift //代理
    {
        Pursuit gg;
        public Proxy(SchoolGril girl)
        {
            gg = new Pursuit(girl);
        }

        public void GiveChcoclate()
        {
            gg.GiveChcoclate();
        }

        public void GiveDools()
        {
            gg.GiveDools();
        }

        public void GiveFlowers()
        {
            gg.GiveFlowers();
        }
    }
}

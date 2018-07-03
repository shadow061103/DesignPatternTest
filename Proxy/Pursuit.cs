using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    class Pursuit : IGiveGift//追求者
    {
        SchoolGril girl;
        public Pursuit(SchoolGril girl)
        {
            this.girl = girl;
        }
        public void GiveChcoclate()
        {
            Console.WriteLine(girl.Name + "送你巧克力");
        }

        public void GiveDools()
        {
            Console.WriteLine(girl.Name+"送你洋娃娃");
        }

        public void GiveFlowers()
        {
            Console.WriteLine(girl.Name + "送你花");
        }
    }
}

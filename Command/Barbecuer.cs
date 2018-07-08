using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    class Barbecuer//烤肉者  Receiver
    {
        public void BakeMutton()
        {
            Console.WriteLine("烤羊肉串");
        }
        public void BakeChickenWing()
        {
            Console.WriteLine("烤雞翅");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator2
{
    class Tshirt:Finery
    {
        public override void Show()
        {
            Console.WriteLine("T shirt");
            base.Show();
        }
    }
}

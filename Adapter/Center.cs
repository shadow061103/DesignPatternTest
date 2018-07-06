using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class Center : Player//中鋒
    {
        public Center(string name) : base(name)
        {
        }
        public override void Attack()
        {
            Console.WriteLine($"中鋒{name}進攻");
        }
        public override void Defense()
        {
            Console.WriteLine($"中鋒{name}防守");
        }
    }
}

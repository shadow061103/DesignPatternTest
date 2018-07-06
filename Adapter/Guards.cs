﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class Guards : Player
    {
        public Guards(string name) : base(name)
        {
        }
        public override void Attack()
        {
            Console.WriteLine($"後衛{name}進攻");
        }
        public override void Defense()
        {
            Console.WriteLine($"後衛{name}防守");
        }
    }
}

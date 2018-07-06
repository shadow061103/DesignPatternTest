﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class Forwards : Player//前鋒
    {
        public Forwards(string name) : base(name)
        {
        }
        public override void Attack()
        {
            Console.WriteLine($"前鋒{name}進攻");
        }
        public override void Defense()
        {
            Console.WriteLine($"前鋒{name}防守");
        }
    }
}

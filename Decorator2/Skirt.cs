﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator2
{
    class Skirt:Finery
    {
        public override void Show()
        {
            Console.WriteLine("裙子");
            base.Show();
        }
    }
}

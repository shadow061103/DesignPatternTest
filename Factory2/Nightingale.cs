﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory2
{
    class Nightingale//南丁格爾
    {
        //也可以改成inerface 實作各自的方法
        public void Sweep()
        {
            Console.WriteLine("掃地");
        }
        public void Wash()
        {
            Console.WriteLine("洗衣");
        }
        public void BuyRice() {
            Console.WriteLine("買米");
        }
    }
}

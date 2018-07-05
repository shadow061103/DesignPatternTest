using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    class SleepingState:State
    {
        public override void WriteProgram(Work w)
        {
           
                Console.WriteLine($"當前時間{w.Hour}點，不行了，睡著了");
          
        }
    }
}

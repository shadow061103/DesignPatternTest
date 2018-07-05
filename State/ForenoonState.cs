using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    class ForenoonState:State
    {
        public override void WriteProgram(Work w)
        {
            if (w.Hour < 12)
                Console.WriteLine($"當前時間{w.Hour}點，上午工作，精神百倍");
            else
            {
                w.SetState(new NoonState());
                w.WriteProgram();
            }
                 
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    class NoonState : State
    {
        public override void WriteProgram(Work w)
        {
            if (w.Hour < 13)
                Console.WriteLine($"當前時間{w.Hour}點，餓了，覺得想睡");
            else
            {
                w.SetState(new AfternoonState());
                w.WriteProgram();
            }
        }
    }
}

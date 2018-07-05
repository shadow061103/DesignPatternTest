using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    class AfternoonState:State
    {
        public override void WriteProgram(Work w)
        {
            if (w.Hour < 17)
                Console.WriteLine($"當前時間{w.Hour}點，下午精神不錯，繼續努力");
            else
            {
                w.SetState(new EveningState());
                w.WriteProgram();
            }
        }
    }
}

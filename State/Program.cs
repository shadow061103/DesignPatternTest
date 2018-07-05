using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    class Program
    {
        static void Main(string[] args)
        {
            Work prj = new Work();
            prj.Hour = 9;
            prj.WriteProgram();
            prj.Hour = 10;
            prj.WriteProgram();
            prj.Hour = 12;
            prj.WriteProgram();
            prj.Hour = 13;
            prj.WriteProgram();
            prj.Hour = 14;
            prj.WriteProgram();
            prj.Hour = 17;
            
            prj.TaskFinished = false;
            prj.WriteProgram();
            prj.Hour = 19;
            prj.WriteProgram();
            prj.Hour = 22;
            prj.WriteProgram();

            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleFactory
{
    class Program
    {
        static void Main(string[] args)
        {//(1)可維護(2)可複用(3)可擴展(4)靈活性好
         //透過繼承、封裝、多型降低耦合度
            Operation oper;
            oper = OperationFactory.createOperation("+");
            oper.NumberA = 1;
            oper.NumberB = 2;
            double result = oper.GetResult();//多型 父類別叫用子類別方法
            Console.WriteLine(result);
            Console.ReadKey();
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory2
{
    class Program
    {
        static void Main(string[] args)
        {
            IFactory factory = new VolunteerFactory();//要修改只需要修改這邊
            Nightingale student = factory.CreateNightingale();
            student.BuyRice();
            student.Sweep();
            student.Wash();
            Console.ReadKey();
        }
    }
}

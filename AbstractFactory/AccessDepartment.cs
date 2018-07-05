using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class AccessDepartment : IDepartment
    {
        public Department GetDepartment(int id)
        {
            Console.WriteLine("在Access中根據ID得到Department一條紀錄");
            return null;
        }

        public void Insert(Department dept)
        {
            Console.WriteLine("在Access中給Department表增加一條紀錄");
        }
    }
}

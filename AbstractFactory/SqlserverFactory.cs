using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class SqlserverFactory : IFactory
    {
        public IDepartment CreateDepartment()
        {
            return  new SqlserverDepartment();
        }

        public IUser CreateUser()
        {
            return new SqlserverUser();
        }

    }
}

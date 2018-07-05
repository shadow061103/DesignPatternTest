using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class AccessFactory : IFactory
    {
        public IDepartment CreateDepartment()
        {
            return new AccessDepartment();
        }

        public IUser CreateUser()
        {
            return new AccessUser();
        }
    }
}

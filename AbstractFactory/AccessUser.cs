using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class AccessUser : IUser
    {
        public User GetUser(int id)
        {
            Console.WriteLine("在Access中根據ID得到User一條紀錄");
            return null;
        }

        public void Insert(User user)
        {
            Console.WriteLine("在Access中給User表增加一條紀錄");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class SqlserverUser : IUser
    {
        public User GetUser(int id)
        {
            Console.WriteLine("在 SQL SERVER中根據ID得到User一條紀錄");
            return null;
        }

        public void Insert(User user)
        {
            Console.WriteLine("在 SQL SERVER中給User表增加一條紀錄");
        }
    }
}

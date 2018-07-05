using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            //有兩張資料表 Access跟sqlserver資料庫可以替換
            User user = new User();
            Department dept = new Department();
            //法1 寫工廠
            //IFactory factory = new AccessFactory();
            IFactory factory = new SqlserverFactory();
            //法2 利用DataAccess 建立實體
            IUser iu = DataAccess.CreateUser(); //factory.CreateUser();

            iu.Insert(user);
            iu.GetUser(1);

            IDepartment ip = DataAccess.CreateDepartment();//factory.CreateDepartment();
            ip.Insert(dept);
            ip.GetDepartment(1);

            Console.ReadKey();
        }
    }
}

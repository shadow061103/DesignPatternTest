using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;//使用反射

namespace AbstractFactory
{
    class DataAccess
    {

        private static readonly string AssemblyName = "AbstractFactory";
        private static readonly string db = "Sqlserver";//資料庫名稱 可換成Access 這段可放在config
                                                     


        public static IUser CreateUser() {
            //原本寫法 用字串+switch判斷實體化哪個資料庫
            //IUser result = null;
            //switch (db)
            //{
            //    case "Sqlserver":
            //        result = new SqlserverUser();
            //        break;
            //    case "Access":
            //        result = new AccessUser();
            //        break;
            //}
            //return result;
            //新寫法 用反射
            string className = AssemblyName + "." + db + "User";
            return (IUser)Assembly.Load(AssemblyName).CreateInstance(className);

        }
        public static IDepartment CreateDepartment()
        {
            //IDepartment result = null;
            //switch (db)
            //{
            //    case "Sqlserver":
            //        result = new SqlserverDepartment();
            //        break;
            //    case "Access":
            //        result = new AccessDepartment();
            //        break;
            //}
            //return result;
            //新寫法 用反射
            string className = AssemblyName + "." + db + "Department";
            return (IDepartment)Assembly.Load(AssemblyName).CreateInstance(className);
        }
    }
}

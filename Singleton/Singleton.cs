using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class Singleton
    {
        //第一次被參考才會實體化 懶漢式
        private static Singleton instance;
        private static readonly object syncRoot = new object();
        private Singleton() { }
        public static Singleton GetInstance()
        {
            if (instance == null)//沒建立過實體才要鎖
             {
                lock (syncRoot)
                { //只能一個執行緒使用
                    if (instance == null)
                        instance = new Singleton();
                }
            }

            

           
            return instance;
        }
    }
}

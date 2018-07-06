using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
   public sealed class Singleton2
    {//一載入就實體化 餓漢式
        private static readonly Singleton2 instance =new Singleton2();
        private Singleton2() { }
        public static Singleton2 GetInstance()
        {
           
            return instance;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
   abstract class Observer //更新介面  這邊用interface也可以 抽象類別可以共用程式碼
    {
        public abstract void Update();//更新方法
    }
}

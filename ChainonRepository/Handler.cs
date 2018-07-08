using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainonRepository
{
   abstract class Handler
    {
        protected Handler successor;
        public void SetSuccessor(Handler successor)//設定繼任者
        {
            this.successor = successor;
        }
        public abstract void HandleRequest(int request);//處理請求的抽象方法
    }
}

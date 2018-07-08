using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
   abstract class Command
    {
        protected Barbecuer receiver;

        public Command(Barbecuer receiver) //這邊用interface更好 依賴倒置
        {
            this.receiver = receiver;
        }
        //執行命令
        abstract public void ExecuteCommand();//Execute
    }
}

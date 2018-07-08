using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{//將一個物件接收者綁死一個動作 叫用接收者相應的操作
    class BakeMuttonCommand : Command
    {
        public BakeMuttonCommand(Barbecuer receiver) : base(receiver)
        {
        }
        public override void ExecuteCommand()
        {
            receiver.BakeMutton();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainonRepository
{
    class ConcretHandler3 : Handler
    {
        public override void HandleRequest(int request)
        {
            if (request >= 20 && request < 30)
                Console.WriteLine($"{this.GetType().Name} 處理請求{request}");
            else if (successor != null)
                successor.HandleRequest(request);//轉移到下一位
        }
    }
}

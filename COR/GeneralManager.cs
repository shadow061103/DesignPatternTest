using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COR
{
    class GeneralManager : Manager
    {
        public GeneralManager(string name) : base(name)
        {
        }
        public override void RequestApplications(Request request)
        {
            //可准許任意天假期
            if (request.RequestType == "請假" )
            {
                Console.WriteLine($"{name}:{request.RequestContent} 數量 {request.Number}批准");
            }
            else if (request.RequestType == "加薪" && request.Number < 500)
                Console.WriteLine($"{name}:{request.RequestContent} 數量 {request.Number}批准");
            else if (request.RequestType == "加薪" && request.Number > 500)
                Console.WriteLine($"{name}:{request.RequestContent} 數量 {request.Number}再說吧");
        }
    }
}

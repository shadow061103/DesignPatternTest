using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COR
{//總監
    class Majordomo : Manager
    {
        public Majordomo(string name) : base(name)
        {

        }
        public override void RequestApplications(Request request)
        {
            
            if (request.RequestType == "請假" && request.Number < 5)
            {
                Console.WriteLine($"{name}:{request.RequestContent} 數量 {request.Number}批准");
            }
            else if (superior != null)
                superior.RequestApplications(request);
        }
    }
}

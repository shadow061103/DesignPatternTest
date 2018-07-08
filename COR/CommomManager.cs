using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COR
{
    class CommomManager : Manager
    {
        public CommomManager(string name) : base(name)
        {
        }
        public override void RequestApplications(Request request)
        {
            //經理權限是請假2天內
            if (request.RequestType == "請假" && request.Number < 2)
            {
                Console.WriteLine($"{name}:{request.RequestContent} 數量 {request.Number}批准");
            }
            else if (superior != null)
                superior.RequestApplications(request);
        }
    }
}

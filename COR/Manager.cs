using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COR
{
   abstract class Manager
    {
        protected string name;
        protected Manager superior;//管理者的上級
        public Manager(string name)
        {
            this.name = name;
        }
        //設定上級
        public void SetSuyperior(Manager superior)
        {
            this.superior = superior;
        }
        //申請請求
        abstract public void RequestApplications(Request request);
    }
}

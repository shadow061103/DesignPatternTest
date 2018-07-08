using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COR
{
    class Program
    {
        static void Main(string[] args)
        {
            CommomManager a = new CommomManager("經理");
            Majordomo b = new Majordomo("總監");
            GeneralManager c = new GeneralManager("總經理");

            a.SetSuyperior(b);
            b.SetSuyperior(c);//設定上級

            Request r = new Request();
            r.RequestType = "請假";
            r.RequestContent = "小菜請假";
            r.Number = 1;
            a.RequestApplications(r);

            Request r2 = new Request();
            r2.RequestType = "請假";
            r2.RequestContent = "小武請假";
            r2.Number = 3;
            a.RequestApplications(r2);

            Request r3 = new Request();
            r3.RequestType = "加薪";
            r3.RequestContent = "小武加薪";
            r3.Number = 400;
            a.RequestApplications(r3);

            Request r4 = new Request();
            r4.RequestType = "加薪";
            r4.RequestContent = "小武加薪";
            r4.Number = 1000;
            a.RequestApplications(r4);

            Console.ReadKey();


        }
    }
}

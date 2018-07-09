using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight2
{
    class Program
    {
        static void Main(string[] args)
        {
            WebsiteFactory f = new WebsiteFactory();
            Website w1 = f.GetWebsiteCategory("產品展示");
            w1.Use(new User("Kuan"));

            Website w2 = f.GetWebsiteCategory("產品展示"); //共用上方 不再實體化
            w2.Use(new User("Kuan"));

            Website w3 = f.GetWebsiteCategory("論壇");
            w3.Use(new User("Kuan"));

            Website w4 = f.GetWebsiteCategory("論壇");
            w4.Use(new User("Kevin"));

            Website w5 = f.GetWebsiteCategory("Blog");
            w5.Use(new User("Kevin"));

            Console.WriteLine("網站分類總數為" + f.GetWebsiteCount());
            Console.ReadKey();
        }
    }
}

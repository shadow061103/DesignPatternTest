using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight2
{
    class ConcreteWebsite:Website
    {
        private string name="";

        

        public ConcreteWebsite(string name)
        {
            this.name = name;
        }

        public override void Use(User user)
        {
            Console.WriteLine("網站分類:"+name+",用戶"+user.Name);
        }
    }
}

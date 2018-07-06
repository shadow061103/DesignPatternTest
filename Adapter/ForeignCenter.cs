using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class ForeignCenter//外籍中鋒
    {
        public string Name { get; set; }
       
        public  void 進攻()
        {
            Console.WriteLine($"外籍中鋒{Name}進攻");
        }
        public  void 防守()
        {
            Console.WriteLine($"外籍中鋒{Name}防守");
        }
    }
}

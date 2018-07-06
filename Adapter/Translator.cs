using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class Translator : Player
    {
        private ForeignCenter pp = new ForeignCenter();
        public Translator(string name) : base(name)
        {
            pp.Name = name;
        }
        public override void Attack()
        {
            pp.進攻();
        }
        public override void Defense()
        {
            pp.防守();
        }
    }
}

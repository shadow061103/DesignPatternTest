using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory2
{
    class UndergraduateFactory:IFactory
    {
        
        public Nightingale CreateNightingale()
        {
            return new Undergraduate();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class ConcreteBuild1 : Builder
    { private Product product = new Product();
        public override void BuildPartA()
        {
            product.Add("零件A");
        }

        public override void BuildPartB()
        {
            product.Add("零件B");
        }

        public override Product GetResult()
        {
            return product;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class ConcreteBuild2 : Builder
    {
        private Product product = new Product();
        public override void BuildPartA()
        {
            product.Add("零件X");
        }

        public override void BuildPartB()
        {
            product.Add("零件Y");
        }

        public override Product GetResult()
        {
            return product;
        }
    }
}

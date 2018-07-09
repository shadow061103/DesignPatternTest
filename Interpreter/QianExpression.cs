using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter
{//千位表達式
    class QianExpression : Expression
    {
        public override string GetPostFix()
        {
            return "千";
        }

        public override int Multiplier()
        {
            return 1000;
        }
    }
}

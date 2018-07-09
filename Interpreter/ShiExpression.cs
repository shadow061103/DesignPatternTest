using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter
{//十位表達式
    class ShiExpression : Expression
    {
        public override string GetPostFix()
        {
            return "十";
        }

        public override int Multiplier()
        {
            return 10;
        }
    }
}

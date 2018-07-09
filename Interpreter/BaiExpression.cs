using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter
{ //百位表達式
    class BaiExpression : Expression
    {
        public override string GetPostFix()
        {
            return "百";
        }

        public override int Multiplier()
        {
            return 100;
        }
    }
}

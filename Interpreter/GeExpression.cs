using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter
{ //個位表達式
    class GeExpression:Expression
    {
        public override string GetPostFix()
        {
            return "";
        }

        public override int Multiplier()
         {
           return 1;
        }
 
       public override int GetLength()
         {
            return 0;
         }
    }
}

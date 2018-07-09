using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter
{//萬位表達式
    class WanExpression : Expression
    {
        public override string GetPostFix()
        {
            return "萬";
        }

        public override int Multiplier()
        {
            return 10000;
        }
        public override void Interpreter(Context context)
        {
            if (context.Statement.Length == 0)
            {
                return;
            }

            ArrayList tree = new ArrayList();

            tree.Add(new GeExpression());
            tree.Add(new ShiExpression());
            tree.Add(new BaiExpression());
            tree.Add(new QianExpression());

            foreach (string key in table.Keys)
            {
                if (context.Statement.EndsWith(GetPostFix()))
                {
                    int temp = context.Data;
                    context.Data = 0;

                    context.Statement = context.Statement.Substring(0, context.Statement.Length - this.GetLength());

                    foreach (Expression exp in tree)
                    {
                    }
                    context.Data = temp + context.Data * this.Multiplier();
                }
            }
        }
    }
}

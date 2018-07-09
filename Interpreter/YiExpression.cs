using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter
{//億位表達式
    class YiExpression : Expression
    {
        public override string GetPostFix()
        {
            return "億";
        }

        public override int Multiplier()
        {
            return 100000000;
        }
        public override void Interpreter(Context context)
        {
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
                        exp.Interpreter(context);
                    }
                    context.Data = temp + context.Data * this.Multiplier();
                }
            }
        }
    }
}

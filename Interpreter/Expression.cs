using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter
{
    public abstract class Expression
    {
        protected Dictionary<string, int> table = new Dictionary<string, int>(9);
        protected Expression()
        {
            table.Add("一", 1);
            table.Add("二", 2);
            table.Add("三", 3);
            table.Add("四", 4);
            table.Add("五", 5);
            table.Add("六", 6);
            table.Add("七", 7);
            table.Add("八", 8);
            table.Add("九", 9);
        }
        public virtual void Interpreter(Context context)
        {
            if (context.Statement.Length == 0)
            {
                return;
            }

            foreach (string key in table.Keys)
            {
                int value = table[key];

                if (context.Statement.EndsWith(key + GetPostFix()))
                {
                    context.Data += value * this.Multiplier();
                    context.Statement = context.Statement.Substring(0, context.Statement.Length - this.GetLength());
                }
                if (context.Statement.EndsWith("零"))
                {
                    context.Statement = context.Statement.Substring(0, context.Statement.Length - 1);
                }
            }
        }

        public abstract string GetPostFix();

        public abstract int Multiplier();
        //這個可以通用，但是對於個位數字例外，所以用虛方法
        public virtual int GetLength()
        {
            return this.GetPostFix().Length + 1;
        }
    }
}

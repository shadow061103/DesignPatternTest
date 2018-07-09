using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    abstract class Action//Visitor
    {
        //得到男人結論或反應
        public abstract void GetManConclusion(Man concreteElementA);
        public abstract void GetWoManConclusion(Woman concreteElementA);
    }
}

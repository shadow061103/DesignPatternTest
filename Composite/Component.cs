using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
  abstract  class Component
    {
        protected string name;
        public Component(string name)
        {
            this.name = name;
        }
        //增加或移除樹葉樹枝
        public abstract void Add(Component c);
        public abstract void Remove(Component c);
        public abstract void Display(int depth);
    }
}

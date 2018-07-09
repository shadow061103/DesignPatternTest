using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    class ObjectStructure
    {
        //能枚舉他的元素 提供一個高層的介面允許訪問者使用
        private IList<Person> elements = new List<Person>();
        public void Attach(Person element)
        {
            elements.Add(element);
        }
        public void Detach(Person element)
        {
            elements.Remove(element);
        }
        //查看顯示
        public void Display(Action visitor)
        {
            foreach (Person e in elements)
                e.Accept(visitor);
        }

    }
}

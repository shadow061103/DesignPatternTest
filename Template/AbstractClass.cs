using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template
{
   abstract class AbstractClass
    {
        public abstract void PrimitiveOperation1();//抽象行為 放到子類別去實現
        public abstract void PrimitiveOperation2();

        public void TemplateMethod() { //給出邏輯的骨架 而邏輯的組成是依些相應的抽象操作 推遲到子類別去實現
            PrimitiveOperation1();
            PrimitiveOperation2();
            Console.WriteLine("");
        }
    }
}

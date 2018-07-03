using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator2
{
    class Person
    {
        private string name;
        public Person() { }
        public Person(string name) {
            this.name = name;

        }
        public virtual void Show() //virtual 可以override 不覆寫就是用父類方法
        {
            Console.WriteLine($"裝扮的{name}");
        } 
    }
}

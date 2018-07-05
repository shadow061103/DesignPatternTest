using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    class ConcreteObserver : Observer
    {
        private string name;
        private string observerState;
        public ConcreteSubject subject { get; set; }
        public ConcreteObserver(ConcreteSubject subject, string name)
        {
            this.subject = subject;
            this.name = name;
        }
        public override void Update()
        {
            observerState = subject.SubjectState;
            Console.WriteLine($"觀察者{name}的新狀態是{observerState}");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    class ConcreteSubject:Subject
    {
        
        public string SubjectState { get; set; }//具體被觀察者狀態
    }
}

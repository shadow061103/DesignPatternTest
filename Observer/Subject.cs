using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
   abstract class Subject //這邊用interface也可以
    {
         //還是依賴抽象類別
        private IList<Observer> obervers = new List<Observer>();
        //增加觀察者
        public void Attach(Observer oberver)
        {
            obervers.Add(oberver);
        }
        //移除觀察者
        public void Detach(Observer oberver)
        {
            obervers.Remove(oberver);
        }
        //通知
        public void Notify()
        {
            foreach (Observer o in obervers)
                o.Update();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP
{
    class People
    {
        private Stuffer stuffer;
        public People()
        {
            stuffer = new Hambuger();//依賴抽象
        }
        public void eat()
        {//填飽肚子

            stuffer.Stuff();
        }
    }
}

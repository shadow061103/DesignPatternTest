using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    abstract class HandsetBrand
    {
        protected HadnsetSoft soft;
        public void SetHandsetSoft(HadnsetSoft soft)
        {
            this.soft = soft;
        }
        public abstract void Run();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP
{
    class Patient : IRegister, ICure
    {
        public void DisPensed(string medicine)//領藥
        {
            throw new NotImplementedException();
        }

        public void Inquiry(Doctor doctor)//問診
        {
            throw new NotImplementedException();
        }

        public void Register()//掛號
        {
            throw new NotImplementedException();
        }
    }
}

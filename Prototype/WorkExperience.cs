using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    class WorkExperience:ICloneable
    {
        public string WorkDate { get; set; }
        public string Company { get; set; }
        public object Clone()
        {
            return (Object)this.MemberwiseClone();//淺層副本
        }
    }
}

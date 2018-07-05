using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer2
{
    interface Subject
    {
        void Notify(BossEventArgs e);
        string SubjectState { get; set; }
    }
}

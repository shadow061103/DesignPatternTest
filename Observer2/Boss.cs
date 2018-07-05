using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer2
{
    class Boss : Subject
    {
        private string action;
        public event EventHandler UpdateEventHandler;
        public string SubjectState
        {
            get
            {
                return action;
            }

            set
            {
                action = value;
            }
        }

        public void Notify(BossEventArgs e)
        {
            UpdateEventHandler(this,e);
        }
    }
}

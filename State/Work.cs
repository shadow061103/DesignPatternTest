using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    class Work
    {
        private State current;
        public double Hour { get; set; }
        private bool finish=false;
        public Work()
        {
            current = new ForenoonState();
        }
        public bool TaskFinished
        {
            get { return finish; }
            set { finish = value; }
        }
        public void SetState(State s)
        {
            current = s;
        }
        public void WriteProgram()
        {
            current.WriteProgram(this);
        }

    }
}

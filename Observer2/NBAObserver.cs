using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer2
{
    class NBAObserver
    {
        private string name;
        private Subject sub;
        public NBAObserver(string name, Subject sub)
        {
            this.name = name;
            this.sub = sub;
        }
        public void CloseNBADirectSeeding(object sender, EventArgs e)
        {
            string msg = (e as BossEventArgs).Message;
            Console.WriteLine(msg);
            Console.WriteLine($"{sub.SubjectState},{name}關閉NBA直播，繼續工作");
        }
    }
}

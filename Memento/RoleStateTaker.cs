using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    class RoleStateTaker//角色狀態管理者
    {
        private RoleStateMemento memento;

        internal RoleStateMemento Memento
        {
            get
            {
                return memento;
            }

            set
            {
                memento = value;
            }
        }
    }
}

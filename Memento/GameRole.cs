using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    class GameRole
    {
         //因為單一職責原則 所以另外建一個類別來記錄物件的狀態(屬性)
        private int vit;
        private int atk;
        private int def;
        
        //生命力
        public int Vitality
        {
            get
            {return vit; }

            set
            { vit = value;}
        }
        //攻擊力
        public int Attack
        {
            get
            {
                return atk;
            }

            set
            {
                atk = value;
            }
        }
        //防禦力
        public int Defense
        {
            get
            {
                return def;
            }

            set
            {
                def = value;
            }
        }
        //狀態顯示
        public void StateDisplay()
        {
            Console.WriteLine("角色當前狀態");
            Console.WriteLine($"體力{this.vit}");
            Console.WriteLine($"攻擊力{this.atk}");
            Console.WriteLine($"防禦力{this.def}");
        }
        //獲得初始狀態
        public void GetInitState()
        {
            this.vit = 100;
            this.atk = 100;
            this.def = 100;

        }
        //戰鬥
        public void Fight()
        {
            this.vit = 40;
            this.atk = 30;
            this.def = 50;
        }
        //保存角色狀態
        public RoleStateMemento SaveState()
        {
            return new RoleStateMemento(vit, atk, def);
        }
        public void RecoveryState(RoleStateMemento memento)
        {
            this.vit = memento.Vitality;
            this.atk = memento.Attack;
            this.def = memento.Defense;
        }
    }
}

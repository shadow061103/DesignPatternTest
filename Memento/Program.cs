using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    class Program
    {
        static void Main(string[] args)
        {//儲存物件的重要狀態
            //維護物件的封裝


            Console.WriteLine("大戰boss前 初始狀態");
           
            GameRole role = new GameRole();
            role.GetInitState();
            role.StateDisplay();

            Console.WriteLine("保存進度");
            RoleStateTaker stateAdmin = new RoleStateTaker();
            stateAdmin.Memento = role.SaveState(); //不知道封裝那些資料

            Console.WriteLine("開始Fight!!");
            role.Fight();
            role.StateDisplay();

            Console.WriteLine("恢復原始狀態");
            role.RecoveryState(stateAdmin.Memento);
            role.StateDisplay();

            Console.ReadKey();


        }
    }
}

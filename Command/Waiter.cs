﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    class Waiter//Invoker 要求命令執行請求
    {
        private IList<Command> orders = new List<Command>();
        //設定訂單
        public void SetOrder(Command command)
        {
            if (command.ToString() == "Command.BakeChickenWingCommand")
                Console.WriteLine("服務生:雞翅沒有了，請點別的燒烤");
            else
            {
                orders.Add(command);
                Console.WriteLine($"增加訂單{command.ToString()}時間 {DateTime.Now.ToString()}");
            }
        }
        //取消訂單
        public void CancelOrder(Command command)
        {
            orders.Remove(command);
            Console.WriteLine($"取消訂單{command.ToString()}時間 {DateTime.Now.ToString()}");
        }
        //通知全部執行
        public void Notify()
        {
            foreach (var cmd in orders)
                cmd.ExecuteCommand();
        }
    }
}

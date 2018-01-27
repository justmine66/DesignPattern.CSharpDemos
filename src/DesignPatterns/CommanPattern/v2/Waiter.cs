using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.CommanPattern.v2
{
    /// <summary>
    /// 服务员
    /// 不管用户想要点什么，反正都是命令，只管记录订单，然后通知“烤肉者”执行即可。
    /// </summary>
    public class Waiter
    {
        private Command _command;

        public void SerOrder(Command command)
        {
            _command = command;
        }

        public void Notify()
        {
            _command.Excute();
        }
    }
}

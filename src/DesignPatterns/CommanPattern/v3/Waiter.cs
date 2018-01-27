using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.CommanPattern.v3
{
    /// <summary>
    /// 服务员
    /// 不管用户想要点什么，反正都是命令，只管记录订单，然后通知“烤肉者”执行即可。
    /// </summary>
    public class Waiter
    {
        private IList<Command> _order = new List<Command>();

        public void SerOrder(Command command)
        {
            if (command.ToString() == "命令模式.BakeChickeWingCommand")
            {
                Console.WriteLine("服务员，鸡翅没有了，请点别的烧烤吧");
            }
            else
            {
                _order.Add(command);
                Console.WriteLine("增加订单: " + command.ToString() + " 时间: " + DateTime.Now.ToString());
            }
        }

        public void CancelOrder(Command command)
        {
            _order.Remove(command);
            Console.WriteLine("取消订单: " + command.ToString() + " 时间: " + DateTime.Now.ToString());
        }

        public void Notify()
        {
            foreach (var command in _order)
            {
                command.Excute();
            }
        }
    }
}

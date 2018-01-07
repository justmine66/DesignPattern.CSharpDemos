using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.ObserverPattern.v1
{
    /// <summary>
    /// 股票同事类
    /// </summary>
    public class StockObserver
    {
        public StockObserver(string name, Secretary secretary)
        {
            this.name = name;
            this.secretary = secretary;
        }

        readonly string name;
        readonly Secretary secretary;

        public void Update()
        {
            Console.WriteLine("{0} {1} 关闭股票行情，继续工作",
                secretary.SecretaryAction, 
                this.name);
        }
    }
}

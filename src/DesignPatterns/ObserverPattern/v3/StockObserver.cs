using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.ObserverPattern.v3
{
    /// <summary>
    /// 看股票的同事
    /// </summary>
    public class StockObserver
    {
        public StockObserver(string name)
        {
            this.name = name;
        }

        protected readonly string name;

        /// <summary>
        /// 关闭股票行情
        /// </summary>
        public void CloseStockMarket(object subject, EventArgs eventArgs)
        {
            Console.WriteLine("{0} {1} 关闭股票行情，继续工作",
                (subject as ISubject).SujectState,
                this.name);
        }
    }
}

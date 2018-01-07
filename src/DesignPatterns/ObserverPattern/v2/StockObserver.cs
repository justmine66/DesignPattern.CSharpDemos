using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.ObserverPattern.v2
{
    /// <summary>
    /// 股票同事类
    /// </summary>
    public class StockObserver : Observer
    {
        public StockObserver(string name, ISubject subject)
            : base(name, subject)
        {

        }

        public override void Update()
        {
            Console.WriteLine("{0} {1} 关闭股票行情，继续工作",
                subject.SujectState,
                this.name);
        }
    }
}

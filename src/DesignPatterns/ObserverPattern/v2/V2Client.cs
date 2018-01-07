using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.ObserverPattern.v2
{
    public class V2Client
    {
        public void Main()
        {
            //老板
            var boss = new Boss();
            //看股票的同事
            var stockObserver = new StockObserver("小明", boss);
            NBAObserver nbaObserver = new NBAObserver("小王", boss);
            boss.Attach(stockObserver);
            boss.Attach(nbaObserver);
            boss.Detach(nbaObserver);

            //老板回来
            boss.SujectState = "老板回来了";
            //通知
            boss.Notify();
        }
    }
}

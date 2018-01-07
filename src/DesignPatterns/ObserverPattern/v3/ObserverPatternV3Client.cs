using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.ObserverPattern.v3
{
    public class ObserverPatternV3Client
    {
        public void Main()
        {
            //老板
            var boss = new Boss();
            //看股票的同事
            var stock = new StockObserver("小明");
            //看NBA直播的同事
            var nba = new NBAObserver("小王");

            boss.Update += stock.CloseStockMarket;
            boss.Update += nba.CloseNBADirectSeeding;

            boss.SujectState = "老板回来了";
            boss.Notify();
        }
    }
}

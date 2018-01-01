using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.StrategyPattern.two.v2
{
    public class StrategyTest
    {
        public void Main()
        {
            var cc = new CashContext("正常收费");
            double totalPrices = cc.GetResult(100);
        }
    }
}

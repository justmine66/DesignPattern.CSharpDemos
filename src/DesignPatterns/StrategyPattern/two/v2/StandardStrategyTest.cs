using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.StrategyPattern.two.v2
{
    /// <summary>
    /// 标准策略模式测试类
    /// </summary>
    public class StandardStrategyTest
    {
        public void Main()
        {
            //通过对context的GetResult方法的调用，可以得到收费费用的结果，让具体算法与客户进行了隔离。
            StandardCashContext cc = this.GetCashContext("正常收费");
            double totalPrices = cc.GetResult(100);
        }

        private StandardCashContext GetCashContext(string type)
        {
            StandardCashContext cc = default(StandardCashContext);

            switch (type)
            {
                case "正常收费":
                    cc = new StandardCashContext(new CashNormal());
                    break;
                case "满300返100":
                    cc = new StandardCashContext(new CashReturn(300, 100));
                    break;
                case "打8折":
                    cc = new StandardCashContext(new CashRebate(0.8));
                    break;
            }

            return cc;
        }
    }
}

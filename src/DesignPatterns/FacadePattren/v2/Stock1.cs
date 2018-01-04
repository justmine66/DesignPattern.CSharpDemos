using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.FacadePattren.v2
{
    /// <summary>
    /// 股票1
    /// </summary>
    public class Stock1
    {
        /// <summary>
        /// 卖股票
        /// </summary>
        public void Sell()
        {
            Console.WriteLine("股票1卖出");
        }

        /// <summary>
        /// 买股票
        /// </summary>
        public void Buy()
        {
            Console.WriteLine("股票1买入");
        }
    }
}

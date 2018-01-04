using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.FacadePattren.v1
{
    public class Stock2
    {
        /// <summary>
        /// 卖股票
        /// </summary>
        public void Sell()
        {
            Console.WriteLine("股票2卖出");
        }

        /// <summary>
        /// 买股票
        /// </summary>
        public void Buy()
        {
            Console.WriteLine("股票2买入");
        }
    }
}

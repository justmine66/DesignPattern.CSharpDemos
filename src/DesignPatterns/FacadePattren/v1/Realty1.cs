using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.FacadePattren.v1
{
    /// <summary>
    /// 房地产1
    /// </summary>
    public class Realty1
    {
        /// <summary>
        /// 卖房地产
        /// </summary>
        public void Sell()
        {
            Console.WriteLine("房地产1卖出");
        }

        /// <summary>
        /// 买房地产
        /// </summary>
        public void Buy()
        {
            Console.WriteLine("房地产1买入");
        }
    }
}

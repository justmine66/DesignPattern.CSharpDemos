using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.FacadePattren.v1
{
    /// <summary>
    /// 国债1
    /// </summary>
    public class NationalDebt1
    {
        /// <summary>
        /// 卖国债
        /// </summary>
        public void Sell()
        {
            Console.WriteLine("国债1卖出");
        }

        /// <summary>
        /// 买国债
        /// </summary>
        public void Buy()
        {
            Console.WriteLine("国债1买入");
        }
    }
}

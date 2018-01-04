using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.FacadePattren.v2
{
    /// <summary>
    /// 基金
    /// </summary>
    public class Fund
    {
        public Fund()
        {
            this.stock1 = new Stock1();
            this.stock2 = new Stock2();
            this.stock3 = new Stock3();
            this.nationalDebt1 = new NationalDebt1();
            this.realty1 = new Realty1();
        }

        readonly Stock1 stock1;
        readonly Stock2 stock2;
        readonly Stock3 stock3;
        readonly NationalDebt1 nationalDebt1;
        readonly Realty1 realty1;

        /// <summary>
        /// 买基金
        /// </summary>
        public void Buy()
        {
            stock1.Buy();
            stock2.Buy();
            stock3.Buy();
            nationalDebt1.Buy();
            realty1.Buy();
        }

        /// <summary>
        /// 卖基金
        /// </summary>
        public void Sell()
        {
            stock1.Sell();
            stock2.Sell();
            stock3.Sell();
            nationalDebt1.Sell();
            realty1.Sell();
        }
    }
}

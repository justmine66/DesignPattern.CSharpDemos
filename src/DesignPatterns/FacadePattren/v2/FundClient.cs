using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.FacadePattren.v2
{
    public class FundClient
    {
        public void Main()
        {
            var fund = new Fund();
            //基金购买
            fund.Buy();
            //基金赎回
            fund.Sell();
        }
    }
}

using DesignPatterns.StrategyPattern.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.StrategyPattern.BasePriceRules
{
    /// <summary>
    /// 运费计价规则
    /// </summary>
    public class ShippingFeeBasePriceRule : IBasePriceRule
    {
        public decimal CalculateBasePrice(OrderItem orderItem)
        {
            throw new NotImplementedException();
        }
    }
}

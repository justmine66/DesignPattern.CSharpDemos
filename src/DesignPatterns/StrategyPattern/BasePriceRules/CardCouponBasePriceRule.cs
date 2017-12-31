using DesignPatterns.StrategyPattern.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.StrategyPattern.BasePriceRules
{
    /// <summary>
    /// 卡券基价规则
    /// </summary>
    class CardCouponBasePriceRule : IBasePriceRule
    {
        public decimal CalculateBasePrice(OrderItem orderItem)
        {
            throw new NotImplementedException();
        }
    }
}

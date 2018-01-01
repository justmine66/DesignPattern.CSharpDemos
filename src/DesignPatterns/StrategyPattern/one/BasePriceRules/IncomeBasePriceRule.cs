using DesignPatterns.StrategyPattern.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.StrategyPattern.BasePriceRules
{
    /// <summary>
    /// 收入计价规则
    /// </summary>
    public class IncomeBasePriceRule : IBasePriceRule
    {
        public decimal CalculateBasePrice(OrderItem orderItem)
        {
            throw new NotImplementedException();
        }
    }
}

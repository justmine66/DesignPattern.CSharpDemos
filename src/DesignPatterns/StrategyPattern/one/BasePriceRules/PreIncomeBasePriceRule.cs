using DesignPatterns.StrategyPattern.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.StrategyPattern.BasePriceRules
{
    /// <summary>
    /// 预收入计价规则
    /// </summary>
    public class PreIncomeBasePriceRule : IBasePriceRule
    {
        public decimal CalculateBasePrice(OrderItem orderItem)
        {
            throw new NotImplementedException();
        }
    }
}

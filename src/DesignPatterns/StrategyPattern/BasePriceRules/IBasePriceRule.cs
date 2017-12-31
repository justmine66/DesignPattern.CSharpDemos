using DesignPatterns.StrategyPattern.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.StrategyPattern.BasePriceRules
{
    /// <summary>
    /// 基价计算规则
    /// </summary>
    public interface IBasePriceRule
    {
        decimal CalculateBasePrice(OrderItem orderItem);
    }
}

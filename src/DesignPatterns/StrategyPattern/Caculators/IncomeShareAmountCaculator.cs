using System;
using System.Collections.Generic;
using System.Text;
using DesignPatterns.StrategyPattern.BasePriceRules;
using DesignPatterns.StrategyPattern.Models;

namespace DesignPatterns.StrategyPattern.Caculators
{
    /// <summary>
    /// 订单计价因子
    /// </summary>
    public class IncomeShareAmountCaculator : IShareAmountCalculator
    {
        public IncomeShareAmountCaculator(IBasePriceRule basePriceRule)
        {
            this._basePriceRule = new IncomeBasePriceRule();
        }

        readonly IBasePriceRule _basePriceRule;

        public decimal CalculateBasePrice(OrderItem orderItem)
        {
            return this._basePriceRule.CalculateBasePrice(orderItem);
        }

        public IEnumerable<OrderItem> GetSharedItems()
        {
            throw new NotImplementedException();
        }

        public decimal GetShareTotalAmount()
        {
            throw new NotImplementedException();
        }

        public decimal GetTotalBaseAmount()
        {
            throw new NotImplementedException();
        }
    }
}

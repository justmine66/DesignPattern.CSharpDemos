using DesignPatterns.StrategyPattern.BasePriceRules;
using DesignPatterns.StrategyPattern.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.StrategyPattern.Caculators
{
    /// <summary>
    /// 订单计价因子
    /// </summary>
    public class OrderShareAmountCaculator : IShareAmountCalculator
    {
        public OrderShareAmountCaculator(IBasePriceRule basePriceRule)
        {
            this._basePriceRule = basePriceRule ?? throw new ArgumentNullException(nameof(basePriceRule));
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

using DesignPatterns.StrategyPattern.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.StrategyPattern.Caculators
{
    /// <summary>
    /// 摘要：
    ///     (分摊)金额计算因子
    /// 备注：
    ///     金额计算核心在于商品金额分摊计算
    /// </summary>
    public interface IShareAmountCalculator
    {
        /// <summary>
        /// 分摊商品总基价
        /// </summary>
        /// <returns></returns>
        decimal GetTotalBaseAmount();

        /// <summary>
        /// 分摊金额
        /// </summary>
        /// <returns></returns>
        decimal GetShareTotalAmount();

        /// <summary>
        /// 计算单个分摊商品基价
        /// </summary>
        /// <param name="orderItem"></param>
        /// <returns></returns>
        decimal CalculateBasePrice(OrderItem orderItem);

        /// <summary>
        /// 被分摊的商品集合
        /// </summary>
        /// <returns></returns>
        IEnumerable<OrderItem> GetSharedItems();
    }
}

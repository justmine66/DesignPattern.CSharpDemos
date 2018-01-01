using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.StrategyPattern.two.v2
{
    /// <summary>
    /// 策略与简单工厂结合，使具体的收费算法彻底与客户端分离
    /// </summary>
    public class CashContext
    {
        /// <summary>
        /// 初始化 CashContext
        /// 通过构造函数传入具体的收费策略
        /// 注意此时传入的不是收费策略对象，而是一个字符串，表示收费类型
        /// </summary>
        /// <param name="cashSuper"></param>
        public CashContext(string type)
        {
            this.cashSuper = CashFactory.CreateCashAccept(type);
        }

        readonly CashSuper cashSuper;

        public double GetResult(double money)
        {
            return this.cashSuper.AcceptCash(money);
        }
    }
}

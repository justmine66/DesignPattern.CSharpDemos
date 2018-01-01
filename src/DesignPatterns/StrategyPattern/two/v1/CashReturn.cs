using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.StrategyPattern.two.v1
{
    /// <summary>
    /// 返利收费子类
    /// 场景：满300返100
    /// </summary>
    public class CashReturn : CashSuper
    {
        public CashReturn(double moneyCondition, double moneyReturn)
        {
            this.moneyCondition = moneyCondition;
            this.moneyReturn = moneyReturn;
        }

        readonly double moneyCondition = 0.0d;//返利条件
        readonly double moneyReturn = 0.0d;//返利值

        public override double AcceptCash(double money)
        {
            double result = default(double);

            if (money > this.moneyCondition)
            {
                result = money - Math.Floor(money / moneyCondition) * moneyReturn;
            }

            return result;
        }
    }
}

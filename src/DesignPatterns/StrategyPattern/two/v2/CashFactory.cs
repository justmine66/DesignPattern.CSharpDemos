using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.StrategyPattern.two.v2
{
    /// <summary>
    /// 收费对象工厂类
    /// </summary>
    public class CashFactory
    {
        /// <summary>
        /// 根据条件，创建收费对象
        /// </summary>
        /// <param name="type">类型</param>
        /// <returns></returns>
        public static CashSuper CreateCashAccept(string type)
        {
            CashSuper cashSuper = default(CashSuper);

            switch (type)
            {
                case "正常收费":
                    cashSuper = new CashNormal();
                    break;
                case "满300返100":
                    cashSuper = new CashReturn(300, 100);
                    break;
                case "打8折":
                    cashSuper = new CashRebate(0.8);
                    break;
            }

            return cashSuper;
        }
    }
}

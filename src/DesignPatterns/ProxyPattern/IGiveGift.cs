using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.ProxyPattern
{
    /// <summary>
    /// 送礼物
    /// </summary>
    public interface IGiveGift
    {
        /// <summary>
        /// 送洋娃娃
        /// </summary>
        void GiveDolls();

        /// <summary>
        /// 送花
        /// </summary>
        void GiveFlowers();

        /// <summary>
        /// 送巧克力
        /// </summary>
        void GiveChocolates();
    }
}

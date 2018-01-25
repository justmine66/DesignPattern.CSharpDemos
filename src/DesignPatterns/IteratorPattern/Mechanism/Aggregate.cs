using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.IteratorPattern.Mechanism
{
    /// <summary>
    /// 聚合抽象类
    /// </summary>
    public abstract class Aggregate
    {
        /// <summary>
        /// 创建迭代器
        /// </summary>
        /// <returns></returns>
        public abstract Iterator CreateIterator();
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.IteratorPattern.Mechanism
{
    /// <summary>
    /// 迭代器抽象类
    /// </summary>
    public abstract class Iterator
    {
        /// <summary>
        /// 得到开始对象
        /// </summary>
        public abstract Object First();
        /// <summary>
        /// 得到下一个对象
        /// </summary>
        /// <returns></returns>
        public abstract object Next();
        /// <summary>
        /// 是否到结尾
        /// </summary>
        /// <returns></returns>
        public abstract bool IsDone();
        /// <summary>
        /// 当前对象
        /// </summary>
        /// <returns></returns>
        public abstract object CurrentItem();
    }
}

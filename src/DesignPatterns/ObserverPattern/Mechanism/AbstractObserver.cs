using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.ObserverPattern.Mechanism
{
    /// <summary>
    /// 抽象的观察者类
    /// </summary>
    public abstract class AbstractObserver
    {
        /// <summary>
        /// 在得到主题的通知时，更新自己
        /// </summary>
        public abstract void Update();
    }
}

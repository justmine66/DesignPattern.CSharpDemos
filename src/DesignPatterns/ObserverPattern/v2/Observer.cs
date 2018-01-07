using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.ObserverPattern.v2
{
    /// <summary>
    /// 抽象的观察者
    /// </summary>
    public abstract class Observer
    {
        public Observer(string name, ISubject subject)
        {
            this.name = name;
            this.subject = subject;
        }

        protected readonly string name;
        protected readonly ISubject subject;

        /// <summary>
        /// 更新观察者状态
        /// </summary>
        public abstract void Update();
    }
}

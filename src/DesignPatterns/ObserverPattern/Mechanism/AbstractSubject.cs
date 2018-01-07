using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.ObserverPattern.Mechanism
{
    /// <summary>
    /// 抽象通知者
    /// </summary>
    public abstract class AbstractSubject
    {
        private IList<AbstractObserver> observers = new List<AbstractObserver>();
        
        /// <summary>
        ///增加观察者
        /// </summary>
        /// <param name="observer"></param>
        public void Attach(AbstractObserver observer)
        {
            observers.Add(observer);
        }

        /// <summary>
        /// 移除观察者
        /// </summary>
        /// <param name="observer"></param>
        public void Detach(AbstractObserver observer)
        {
            observers.Remove(observer);
        }

        /// <summary>
        /// 通知观察者
        /// </summary>
        public void Notify()
        {
            foreach (var observer in this.observers)
            {
                observer.Update();
            }
        }
    }
}

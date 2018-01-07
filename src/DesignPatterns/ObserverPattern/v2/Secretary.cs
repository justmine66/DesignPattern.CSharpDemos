using System.Collections.Generic;

namespace DesignPatterns.ObserverPattern.v2
{
    /// <summary>
    /// 前台秘书类
    /// </summary>
    public class Secretary : ISubject
    {
        //同事列表
        IList<Observer> observers = new List<Observer>();
        string action;
        //增加
        public void Attach(Observer observer)
        {
            this.observers.Add(observer);
        }
        //通知
        public void Notify()
        {
            foreach (var stockObserver in this.observers)
            {
                stockObserver.Update();
            }
        }
        //减少
        public void Detach(Observer observer)
        {
            throw new System.NotImplementedException();
        }

        //前台状态
        public string SujectState
        {
            get { return this.action; }
            set { this.action = value; }
        }
    }
}
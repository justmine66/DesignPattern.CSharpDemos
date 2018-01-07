using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.ObserverPattern.v1
{
    /// <summary>
    /// 前台秘书类
    /// </summary>
    public class Secretary
    {
        //同事列表
        IList<StockObserver> stockObservers = new List<StockObserver>();
        string action;
        //增加
        public void Attach(StockObserver stockObserver)
        {
            this.stockObservers.Add(stockObserver);
        }
        //通知
        public void Notify()
        {
            foreach (var stockObserver in this.stockObservers)
            {
                stockObserver.Update();
            }
        }
        //前台状态
        public string SecretaryAction
        {
            get { return this.action; }
            set { this.action = value; }
        }
    }
}

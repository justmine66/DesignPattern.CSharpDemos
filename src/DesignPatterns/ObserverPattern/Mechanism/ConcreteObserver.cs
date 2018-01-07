using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.ObserverPattern.Mechanism
{
    /// <summary>
    /// 具体观察者
    /// </summary>
    public class ConcreteObserver : AbstractObserver
    {
        private string name;
        private string state;
        private ConcreteSuject suject;

        public ConcreteObserver(ConcreteSuject suject, string name)
        {
            this.suject = suject;
            this.name = name;
        }

        public override void Update()
        {
            this.state = this.suject.State;
            Console.WriteLine("观察者{0}的新状态是{1}", this.name, this.state);
        }
    }
}

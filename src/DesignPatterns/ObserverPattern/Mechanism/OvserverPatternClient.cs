using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.ObserverPattern.Mechanism
{
    public class OvserverPatternClient
    {
        public void Main()
        {
            var suject = new ConcreteSuject();
            suject.Attach(new ConcreteObserver(suject, "小明"));
            suject.Attach(new ConcreteObserver(suject, "小芳"));

            suject.State = "abc";
            suject.Notify();
        }
    }
}

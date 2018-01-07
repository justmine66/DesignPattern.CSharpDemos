using DesignPatterns.ObserverPattern.v2;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.ObserverPattern.v2
{
    public class Boss : ISubject
    {
        IList<Observer> observers = new List<Observer>();
        public string SujectState { get; set; }

        public void Attach(Observer observer)
        {
            this.observers.Add(observer);
        }

        public void Detach(Observer observer)
        {
            this.observers.Remove(observer);
        }

        public void Notify()
        {
            foreach (var observer in this.observers)
            {
                observer.Update();
            }
        }
    }
}

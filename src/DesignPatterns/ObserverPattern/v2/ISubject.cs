using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.ObserverPattern.v2
{
    /// <summary>
    /// 通知者接口
    /// </summary>
    public interface ISubject
    {
        void Attach(Observer observer);
        void Detach(Observer observer);
        void Notify();
        string SujectState { get; set; }
    }
}

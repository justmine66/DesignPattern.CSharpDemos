using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.ObserverPattern.Mechanism
{
    /// <summary>
    /// 具体的主题类
    /// </summary>
    public class ConcreteSuject : AbstractSubject
    {
        public string State { get; set; }
    }
}

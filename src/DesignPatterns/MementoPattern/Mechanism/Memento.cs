using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.MementoPattern.Mechanism
{
    /// <summary>
    /// 备忘录类
    /// </summary>
    public class Memento
    {
        private string state;

        public Memento(string state)
        {
            this.state = state;
        }

        public string State { get; }
    }
}

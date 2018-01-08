using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.MementoPattern.Mechanism
{
    /// <summary>
    /// 管理者类
    /// </summary>
    public class Caretaker
    {
        public Memento Memento { get; set; }
    }
}

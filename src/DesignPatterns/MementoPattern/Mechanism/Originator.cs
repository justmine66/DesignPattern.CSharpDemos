using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.MementoPattern.Mechanism
{
    /// <summary>
    /// 发起人
    /// </summary>
    public class Originator
    {
        public string State { get; set; }

        /// <summary>
        /// 创建备忘录
        /// </summary>
        /// <returns></returns>
        public Memento CreateMemento()
        {
            return new Memento(this.State);
        }

        /// <summary>
        /// 恢复备忘录
        /// 导入Memento，并恢复数据
        /// </summary>
        /// <param name="memento"></param>
        public void SerMemento(Memento memento)
        {
            this.State = memento.State;
        }

        public void Show()
        {
            Console.WriteLine("State=" + this.State);
        }
    }
}

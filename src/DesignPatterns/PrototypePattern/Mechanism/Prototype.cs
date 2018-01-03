using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.PrototypePattern.Mechanism
{
    /// <summary>
    /// 原型类
    /// </summary>
    public abstract class Prototype
    {
        private string id;

        public Prototype(string id)
        {
            this.id = id;
        }

        public string ID { get { return this.id; } }

        public abstract Prototype Clone();//关键就是这个克隆方法
    }
}

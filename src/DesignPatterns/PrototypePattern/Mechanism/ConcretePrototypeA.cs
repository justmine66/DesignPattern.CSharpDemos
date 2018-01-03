using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.PrototypePattern.Mechanism
{
    /// <summary>
    /// 具体原型类A
    /// </summary>
    public class ConcretePrototypeA : Prototype
    {
        public ConcretePrototypeA(string id) 
            : base(id)
        {
        }

        public override Prototype Clone()
        {
            //创建当前对象的浅表副本。
            //方法是创建一个新对象，然后将当前字段的非静态字段复制到该新对象。如果是值类型，则对该字段进行逐位复制；如果是引用类型，则复制引用但不复制引用的对象，因此原始对象及其副本引用同一对象。
            return this.MemberwiseClone() as Prototype;
        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.FlyweightPattern.Mechanism
{
    /// <summary>
    /// 享元工厂
    /// 用来创建并管理Flyweight对象。它主要是用来确保合理地共享Flyweight，当用户请求一个Flyweight时，FlyweightFactory对象提供一个已创建的实例和创建一个（如果不存在的话）
    /// </summary>
    public class FlyweightFactory
    {
        Hashtable _hashtable = new Hashtable();

        public FlyweightFactory()
        {
            _hashtable.Add("x",new ConcreteFlayweight());
            _hashtable.Add("y",new ConcreteFlayweight());
            _hashtable.Add("z",new ConcreteFlayweight());
        }

        public Flyweight GetFlyweight(string key)
        {
            return _hashtable[key] as Flyweight;
        }
    }
}

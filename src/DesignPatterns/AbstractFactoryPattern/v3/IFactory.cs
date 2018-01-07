using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.AbstractFactoryPattern.v3
{
    /// <summary>
    /// IFactory接口，定义一个创建访问User表对象的抽象的工厂接口
    /// </summary>
    public interface IFactory
    {
        IUser CreateUser();
        IDepartment CreateDepartment();
    }
}

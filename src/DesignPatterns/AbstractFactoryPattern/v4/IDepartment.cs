using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.AbstractFactoryPattern.v4
{
    /// <summary>
    /// IDepartment接口
    /// 用于客户端访问，解耦与具体数据库访问的耦合
    /// </summary>
    public interface IDepartment
    {
        void Insert(Department department);
        Department GetDepartment(int? id);
    }
}

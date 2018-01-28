using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.MediatorPattern.v1
{
    /// <summary>
    /// 联合国机构 相当于Mediator类
    /// </summary>
    public abstract class UnitedNations
    {
        public abstract void Declare(string message, Country country);
    }
}

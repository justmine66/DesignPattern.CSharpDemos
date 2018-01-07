using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.AbstractFactoryPattern.v2
{
    /// <summary>
    /// AccessFactory类，实现IFactory接口，实例化AccessUser
    /// </summary>
    public class AccessFactory : IFactory
    {
        public IUser CreateUser()
        {
            return new AccessUser();
        }
    }
}

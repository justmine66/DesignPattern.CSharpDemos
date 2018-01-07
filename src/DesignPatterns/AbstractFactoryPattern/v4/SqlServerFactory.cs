using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.AbstractFactoryPattern.v4
{
    /// <summary>
    /// SqlServerFactory类，实现IFactory接口，实例化SqlServerUser
    /// </summary>
    public class SqlServerFactory : IFactory
    {
        public IDepartment CreateDepartment()
        {
            return new SqlserverDepartment();
        }

        public IUser CreateUser()
        {
            return new SqlServerUser();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.AbstractFactoryPattern.v3
{
    /// <summary>
    /// SqlServerFactory类，实现IFactory接口
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

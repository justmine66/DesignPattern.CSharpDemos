using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.AbstractFactoryPattern.v4
{
    /// <summary>
    /// 数据访问类
    /// </summary>
    public class DataAccess
    {
        private static readonly string db = "SqlServer";

        public static IUser CreateUser()
        {
            IUser user = default(IUser);

            switch (db)
            {
                case "SqlServer":
                    user = new SqlServerUser();
                    break;
                case "Acess":
                    user = new AccessUser();
                    break;
            }

            return user;
        }

        public static IDepartment CreateDepartment()
        {
            IDepartment department = default(IDepartment);

            switch (db)
            {
                case "SqlServer":
                    department = new SqlserverDepartment();
                    break;
                case "Acess":
                    department = new AccessDepartment();
                    break;
            }

            return department;
        }
    }
}

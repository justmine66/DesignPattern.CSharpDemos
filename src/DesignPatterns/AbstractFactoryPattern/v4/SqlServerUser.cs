using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.AbstractFactoryPattern.v4
{
    public class SqlServerUser : IUser
    {
        public User GetUser(int? id)
        {
            Console.WriteLine("在SQL Server中根据ID获得User表一条记录");
            return default(User);
        }

        public void Insert(User user)
        {
            Console.WriteLine("在SQL Server中给User表插入一条记录");
        }
    }
}

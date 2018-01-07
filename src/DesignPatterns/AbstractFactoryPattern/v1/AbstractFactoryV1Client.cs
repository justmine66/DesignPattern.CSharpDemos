using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.AbstractFactoryPattern.v1
{
    public class AbstractFactoryV1Client
    {
        public void Main()
        {
            var user = new User();
            var sqlServerUser = new SqlServerUser();
            sqlServerUser.Insert(user);
            sqlServerUser.GetUser(1);
        }
    }
}

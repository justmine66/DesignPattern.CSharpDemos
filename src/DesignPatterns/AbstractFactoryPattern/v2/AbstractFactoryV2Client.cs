using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.AbstractFactoryPattern.v2
{
    public class AbstractFactoryV2Client
    {
        public void Main()
        {
            var user = new User();
            //若需要改成Access数据库，只需要将本句改成IFactory factory = new AccessFactory();
            IFactory factory = new SqlServerFactory();
            IUser iu = factory.CreateUser();
            iu.Insert(user);
            iu.GetUser(1);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.AbstractFactoryPattern.v3
{
    public class AbstractFactoryV3Client
    {
        public void Main()
        {
            var user = new User();
            var department = new Department();
            //若需要改成Access数据库，只需要将本句改成IFactory factory = new AccessFactory();
            IFactory factory = new SqlServerFactory();

            IUser iu = factory.CreateUser();
            iu.Insert(user);
            iu.GetUser(1);

            IDepartment id = factory.CreateDepartment();
            id.Insert(department);
            id.GetDepartment(1);
        }
    }
}

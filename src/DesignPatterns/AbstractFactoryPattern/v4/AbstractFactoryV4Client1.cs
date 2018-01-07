using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.AbstractFactoryPattern.v4
{
    public class AbstractFactoryV4Client1
    {
        public void Main()
        {
            var user = new User();
            var department = new Department();

            IFactory factory = DataAccess1.CreateFactory();

            IUser iu = factory.CreateUser();
            iu.Insert(user);
            iu.GetUser(1);

            IDepartment id = factory.CreateDepartment();
            id.Insert(department);
            id.GetDepartment(1);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.AbstractFactoryPattern.v4
{
    public class AbstractFactoryV4Client
    {
        public void Main()
        {
            var user = new User();
            var department = new Department();

            IUser iu = DataAccess.CreateUser();
            iu.Insert(user);
            iu.GetUser(1);

            IDepartment id = DataAccess.CreateDepartment();
            id.Insert(department);
            id.GetDepartment(1);
        }
    }
}

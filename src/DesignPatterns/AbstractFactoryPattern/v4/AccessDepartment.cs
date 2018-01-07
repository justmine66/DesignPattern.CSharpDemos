using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.AbstractFactoryPattern.v4
{
    /// <summary>
    /// AccessDepartment,用户访问Access的Department
    /// </summary>
    public class AccessDepartment : IDepartment
    {
        public Department GetDepartment(int? id)
        {
            Console.WriteLine("在Access中根据ID获得Department表一条记录");
            return default(Department);
        }

        public void Insert(Department department)
        {
            Console.WriteLine("在Access中给Department表插入一条记录");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.AbstractFactoryPattern.v4
{
    /// <summary>
    /// SqlserverDepartment,用户访问SQL Server的Department
    /// </summary>
    public class SqlserverDepartment : IDepartment
    {
        public Department GetDepartment(int? id)
        {
            Console.WriteLine("在SQL Server中根据ID获得Department表一条记录");
            return default(Department);
        }

        public void Insert(Department department)
        {
            Console.WriteLine("在SQL Server中给Department表插入一条记录");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.CompositePattern.v1
{
    /// <summary>
    /// 人力资源部 树叶节点
    /// </summary>
    public class HRDepartment : CompanyBase
    {
        public HRDepartment(string name) : base(name)
        {
        }

        public override void Add(CompanyBase company)
        {
        }

        public override void Display(int depth)
        {
            Console.WriteLine(new string('-', depth) + this.Name);
        }

        public override void LineOfDuty()
        {
            Console.WriteLine("{0} 员工招聘培训管理", this.Name);
        }

        public override void Remove(CompanyBase company)
        {
        }
    }
}

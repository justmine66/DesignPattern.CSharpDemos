using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.CompositePattern.v1
{
    /// <summary>
    /// 财务部 树叶节点
    /// </summary>
    public class FinanceDepartment : CompanyBase
    {
        public FinanceDepartment(string name) : base(name)
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
            Console.WriteLine("{0} 公司财政收支管理", this.Name);
        }

        public override void Remove(CompanyBase company)
        {
        }
    }
}

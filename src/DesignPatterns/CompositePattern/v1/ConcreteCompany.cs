using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.CompositePattern.v1
{
    /// <summary>
    /// 具体公司类 树枝节点
    /// </summary>
    public class ConcreteCompany : CompanyBase
    {
        private IList<CompanyBase> _children = new List<CompanyBase>();

        public ConcreteCompany(string name) : base(name)
        {
        }

        public override void Add(CompanyBase company)
        {
            _children.Add(company);
        }

        public override void Display(int depth)
        {
            Console.WriteLine(new string('-', depth) + this.Name);

            foreach (CompanyBase company in this._children)
            {
                company.Display(depth + 2);
            }
        }

        public override void LineOfDuty()
        {
            foreach (CompanyBase company in _children)
            {
                company.LineOfDuty();
            }
        }

        public override void Remove(CompanyBase company)
        {
            _children.Remove(company);
        }
    }
}

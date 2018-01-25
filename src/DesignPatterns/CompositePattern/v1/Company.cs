using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.CompositePattern.v1
{
    public abstract class CompanyBase
    {
        protected string Name;

        public CompanyBase(string name)
        {
            this.Name = name;
        }

        public abstract void Add(CompanyBase company);
        public abstract void Remove(CompanyBase company);
        public abstract void Display(int depth);
        /// <summary>
        /// 需要履行的职责
        /// </summary>
        public abstract void LineOfDuty();
    }
}

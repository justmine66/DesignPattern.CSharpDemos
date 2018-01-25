using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.CompositePattern.v1
{
    public class CompositePatternV1Client
    {
        public void Main()
        {
            var root = new ConcreteCompany("北京总公司");
            root.Add(new HRDepartment("总公司人力资源部"));
            root.Add(new FinanceDepartment("总公司财务部"));

            var subCompany = new ConcreteCompany("上海华东分公司");
            subCompany.Add(new HRDepartment("华东分公司人力资源部"));
            subCompany.Add(new FinanceDepartment("华东分公司财务部"));
            root.Add(subCompany);

            var subCompany1 = new ConcreteCompany("南京办事处");
            subCompany1.Add(new HRDepartment("南京办事处人力资源部"));
            subCompany1.Add(new FinanceDepartment("南京办事处财务部"));
            root.Add(subCompany1);

            var subCompany2 = new ConcreteCompany("杭州办事处");
            subCompany2.Add(new HRDepartment("杭州办事处人力资源部"));
            subCompany2.Add(new FinanceDepartment("杭州办事处财务部"));
            subCompany.Add(subCompany2);

            Console.WriteLine("\n 结构图");
            root.Display(1);

            Console.WriteLine("\n 职责");
            root.LineOfDuty();

            Console.Read();
        }
    }
}

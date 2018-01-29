using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.VisitorPattern.Mechanism
{
    public class ConcreteVisitor2 : AbstractVisitor
    {
        public override void VisitConcreteElementA(ConcreteElementA elementA)
        {
            Console.WriteLine("{0}被{1}访问", elementA.GetType().Name, this.GetType().Name);
        }

        public override void VisitConcreteElementB(ConcreteElementB elementB)
        {
            Console.WriteLine("{0}被{1}访问", elementB.GetType().Name, this.GetType().Name);
        }
    }
}

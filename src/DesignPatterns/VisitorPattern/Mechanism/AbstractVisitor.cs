using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.VisitorPattern.Mechanism
{
    public abstract class AbstractVisitor
    {
        public abstract void VisitConcreteElementA(ConcreteElementA elementA);
        public abstract void VisitConcreteElementB(ConcreteElementB elementB);
    }
}

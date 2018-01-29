using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.VisitorPattern.Mechanism
{
    public class VisitorPatternClient
    {
        public void Main()
        {
            var structure = new ObjectStructure();
            structure.Attacth(new ConcreteElementA());
            structure.Attacth(new ConcreteElementB());

            structure.Accept(new ConcreteVisitor1());
            structure.Accept(new ConcreteVisitor2());

            Console.Read();
        }
    }
}

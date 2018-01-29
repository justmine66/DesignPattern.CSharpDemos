using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.VisitorPattern.Mechanism
{
    public class ObjectStructure
    {
        IList<AbstractElement> elements = new List<AbstractElement>();

        public void Attacth(AbstractElement element)
        {
            elements.Add(element);
        }

        public void Detach(AbstractElement element)
        {
            elements.Remove(element);
        }

        public void Accept(AbstractVisitor visitor)
        {
            foreach (var element in elements)
            {
                element.Accept(visitor);
            }
        }
    }
}

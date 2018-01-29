using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.VisitorPattern.Mechanism
{
    public abstract class AbstractElement
    {
        public abstract void Accept(AbstractVisitor visitor);
    }
}

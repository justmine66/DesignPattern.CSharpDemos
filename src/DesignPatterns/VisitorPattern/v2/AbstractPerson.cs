using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.VisitorPattern.v2
{
    public abstract class AbstractPerson
    {
        public abstract void Accept(AbstractAction visitor);
    }
}

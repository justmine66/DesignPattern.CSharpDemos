using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.VisitorPattern.v1
{
    public abstract class AbstractPerson
    {
        public string Action { get; set; }

        public abstract void GetConclusion();
    }
}

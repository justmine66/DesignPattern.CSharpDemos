using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.FactoryMethodPattern
{
    public class OperationMul : Operation
    {
        public override double GetResult()
        {
            return base.NumberA * base.NumberB;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.BuilderPattern.Mechanism
{
    public class ConcreteBuilder2 : IBuilder
    {
        public ConcreteBuilder2()
        {
            this.product = new Product();
        }

        readonly Product product;

        public void BuilderPartA()
        {
            product.Add("部件X");
        }

        public void BuilderPartB()
        {
            product.Add("部件Y");
        }

        public Product Build()
        {
            return this.product;
        }
    }
}

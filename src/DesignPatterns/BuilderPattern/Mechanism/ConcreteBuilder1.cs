using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.BuilderPattern.Mechanism
{
    public class ConcreteBuilder1 : IBuilder
    {
        public ConcreteBuilder1()
        {
            this.product = new Product();
        }

        readonly Product product;

        public Product Build()
        {
            return this.product;
        }

        public void BuilderPartA()
        {
            product.Add("部件A");
        }

        public void BuilderPartB()
        {
            product.Add("部件B");
        }
    }
}

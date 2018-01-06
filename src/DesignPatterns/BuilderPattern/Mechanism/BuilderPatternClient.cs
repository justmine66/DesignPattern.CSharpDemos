using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.BuilderPattern.Mechanism
{
    public class BuilderPatternClient
    {
        public void Main()
        {
            IBuilder builder = new ConcreteBuilder1();
            Director director = new Director(builder);
            Product product = director.CreateProduct();
            product.Show();
        }
    }
}

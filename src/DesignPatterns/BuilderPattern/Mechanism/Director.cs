using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.BuilderPattern.Mechanism
{
    public class Director
    {
        public Director(IBuilder builder)
        {
            this.builder = builder;
        }

        readonly IBuilder builder;

        public Product CreateProduct()
        {
            builder.BuilderPartA();
            builder.BuilderPartB();
            return builder.Build();
        }
    }
}

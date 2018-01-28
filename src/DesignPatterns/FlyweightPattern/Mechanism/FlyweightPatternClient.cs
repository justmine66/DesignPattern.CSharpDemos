using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.FlyweightPattern.Mechanism
{
    public class FlyweightPatternClient
    {
        public void Main()
        {
            int extrinsicState = 20;

            var factory = new FlyweightFactory();

            Flyweight fx = factory.GetFlyweight("x");
            fx.Operation(--extrinsicState);

            Flyweight fy = factory.GetFlyweight("y");
            fy.Operation(--extrinsicState);

            Flyweight fz = factory.GetFlyweight("z");
            fz.Operation(--extrinsicState);

            var unshared = new UnsharedConcreteFlyweight();
            unshared.Operation(--extrinsicState);

            Console.Read();
        }
    }
}

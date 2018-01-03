using DesignPatterns.DecoratorPattern.Mechanism;
using DesignPatterns.DecoratorPattern.v1;
using DesignPatterns.DecoratorPattern.v2;
using DesignPatterns.DecoratorPattern.v3;
using System;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {    
            //测试职责链模式-标准
            //new StandardCORPTest().Main();
            //测试职责链模式-功能链
            //new FunctionalChainCORPTest().Main();
            //测试简单工厂模式
            //new SimpleFactoryPatternTest().Main();
            //测试装饰者模式
            //new DecoratorTest().Main();
            //new DecoratorV1Test().Main();
            //new DecoratorV2Test().Main();
            new DecoratorV3Test().Main();
            Console.Read();
        }
    }
}

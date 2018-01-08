using DesignPatterns.AbstractFactoryPattern.v3;
using DesignPatterns.BuilderPattern.Mechanism;
using DesignPatterns.ChainOfResponsibilityPattern.FunctionalChain;
using DesignPatterns.ChainOfResponsibilityPattern.Standard;
using DesignPatterns.DecoratorPattern.Mechanism;
using DesignPatterns.DecoratorPattern.v1;
using DesignPatterns.DecoratorPattern.v2;
using DesignPatterns.DecoratorPattern.v3;
using DesignPatterns.MementoPattern.v2;
using DesignPatterns.ObserverPattern.v1;
using DesignPatterns.ObserverPattern.v3;
using DesignPatterns.PrototypePattern.Mechanism;
using DesignPatterns.PrototypePattern.v2;
using DesignPatterns.PrototypePattern.v3;
using DesignPatterns.PrototypePattern.v4;
using DesignPatterns.SimpleFactoryPattern;
using DesignPatterns.StatePattern.Mechanism;
using DesignPatterns.StatePattern.v3;
using System;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            //测试职责链模式-标准
            //new StandardCORPClient().Main();
            //测试职责链模式-功能链
            //new FunctionalChainCORPClient().Main();
            //测试简单工厂模式
            //new SimpleFactoryPatternClient().Main();
            //测试装饰者模式
            //new DecoratorClient().Main();
            //new DecoratorV1Client().Main();
            //new DecoratorV2Client().Main();
            //new DecoratorV3Client().Main();
            //测试原型模式
            //new PrototypePatternClient().Main();
            //new ResumeV2Client().Main();
            //new ResumeV3Client().Main();
            //new ResumeV4Client().Main();
            //测试建造者模式
            //new BuilderPatternClient().Main();
            //测试观察者模式
            //new ObserverPatternV1Client().Main();
            //new ObserverPatternV3Client().Main();
            //测试抽象工厂模式
            //new AbstractFactoryV3Client().Main();
            //测试状态模式
            //new StatePatternClient().Main();
            //new StatePatternV3Client().Main();
            //测试备忘录模式
            new MementoPatternV2Client().Main();

            Console.Read();
        }
    }
}

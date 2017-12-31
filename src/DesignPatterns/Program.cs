using DesignPatterns.ChainOfResponsibilityPattern.FunctionalChain;
using DesignPatterns.ChainOfResponsibilityPattern.Standard;
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
            new FunctionalChainCORPTest().Main();

            Console.Read();
        }
    }
}

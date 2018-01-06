using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.BuilderPattern.Mechanism
{
    /// <summary>
    /// 抽象建造者类，确定产品由两个部件(A、B)组成
    /// </summary>
    public interface IBuilder
    {
        void BuilderPartA();
        void BuilderPartB();
        Product Build();
    }
}

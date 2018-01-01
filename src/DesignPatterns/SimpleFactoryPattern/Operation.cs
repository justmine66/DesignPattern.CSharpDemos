using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.SimpleFactoryPattern
{
    /// <summary>
    /// 运算类
    /// </summary>
    public abstract class Operation
    {
        public double NumberA { get; set; }
        public double NumberB { get; set; }

        public abstract double GetResult();
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.BuilderPattern
{
    /// <summary>
    /// 抽象一个建造人的类，把整个构建过程稳定下来，不要让任何人遗忘当中的任何一步
    /// </summary>
    public abstract  class PersonBuilder
    {
        public PersonBuilder(Graphics g, Pen pen)
        {
            this.g = g;
            this.pen = pen;
        }

        readonly Graphics g;
        readonly Pen pen;

        public abstract void BuildHead();
        public abstract void BuildBody();
        public abstract void BuildArmLeft();
        public abstract void BuildArmRight();
        public abstract void BuildLegLeft();
        public abstract void BuildLegRight();
    }

    public class Pen
    {
    }

    public class Graphics
    {
    }
}

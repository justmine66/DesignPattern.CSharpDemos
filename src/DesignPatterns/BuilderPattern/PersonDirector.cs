using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.BuilderPattern
{
    /// <summary>
    /// 指挥者
    /// 控制整个建造过程，也用它来隔离用户与创建过程的关联
    /// </summary>
    public class PersonDirector
    {
        public PersonDirector(PersonBuilder builder)
        {
            this.builder = builder;
        }

        readonly PersonBuilder builder;

        public void CreatePerson()
        {
            builder.BuildHead();
            builder.BuildBody();
            builder.BuildArmLeft();
            builder.BuildArmRight();
            builder.BuildLegLeft();
            builder.BuildLegRight();
        }
    }
}

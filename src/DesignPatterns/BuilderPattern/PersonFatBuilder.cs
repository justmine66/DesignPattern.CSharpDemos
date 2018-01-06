using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.BuilderPattern
{
    public class PersonFatBuilder : PersonBuilder
    {
        public PersonFatBuilder(Graphics g, Pen pen) : base(g, pen)
        {
        }

        public override void BuildArmLeft()
        {
            throw new NotImplementedException();
        }

        public override void BuildArmRight()
        {
            throw new NotImplementedException();
        }

        public override void BuildBody()
        {
            throw new NotImplementedException();
        }

        public override void BuildHead()
        {
            throw new NotImplementedException();
        }

        public override void BuildLegLeft()
        {
            throw new NotImplementedException();
        }

        public override void BuildLegRight()
        {
            throw new NotImplementedException();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.CommanPattern.v2
{
    public class BakeMuttonCommand : Command
    {
        public BakeMuttonCommand(Barbecuer receiver) : base(receiver)
        {
        }

        public override void Excute()
        {
            _barbecuer.BakeMutton();
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.CommanPattern.v3
{
    public class BakeChickenWingCommand : Command
    {
        public BakeChickenWingCommand(Barbecuer barbecuer) : base(barbecuer)
        {
        }

        public override void Excute()
        {
            _barbecuer.BakeChickenWing();
        }
    }
}

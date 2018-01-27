using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.CommanPattern.v2
{
    /// <summary>
    /// 抽象命令
    /// </summary>
    public abstract class Command
    {
        protected Barbecuer _barbecuer;

        public Command(Barbecuer barbecuer)
        {
            _barbecuer = barbecuer;
        }

        public abstract void Excute();
    }
}

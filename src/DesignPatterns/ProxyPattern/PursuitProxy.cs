using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.ProxyPattern
{
    /// <summary>
    /// 追求者代理
    /// </summary>
    public class PursuitProxy : IGiveGift
    {
        public PursuitProxy(SchoolGirl schoolGirl)
        {
            if (schoolGirl == null)
            {
                throw new ArgumentNullException(nameof(schoolGirl));
            }

            this.pursuit = new Pursuit(schoolGirl);
        }

        readonly Pursuit pursuit;

        public void GiveChocolates()
        {
            pursuit.GiveChocolates();
        }

        public void GiveDolls()
        {
            pursuit.GiveDolls();
        }

        public void GiveFlowers()
        {
            pursuit.GiveFlowers();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.VisitorPattern.v2
{
    public class Success : AbstractAction
    {
        public override void GetManConclusion(Man man)
        {
            Console.WriteLine("男人{0}{1}时，背后多半有一个伟大的女人。", this.GetType().Name);
        }

        public override void GetWomanConclusion(Woman woman)
        {
            Console.WriteLine("女人{0}{1}时，背后大多有一个不成功的男人。", this.GetType().Name);
        }
    }
}

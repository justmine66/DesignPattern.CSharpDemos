using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.VisitorPattern.v2
{
    public class Failure : AbstractAction
    {
        public override void GetManConclusion(Man man)
        {
            Console.WriteLine("男人{0}时，闷头喝酒，谁也不用劝。", this.GetType().Name);
        }

        public override void GetWomanConclusion(Woman woman)
        {
            Console.WriteLine("女人{0}时，眼泪汪汪，谁也劝不住。", this.GetType().Name);
        }
    }
}

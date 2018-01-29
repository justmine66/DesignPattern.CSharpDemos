using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.VisitorPattern.v2
{
    public class Amativeness : AbstractAction
    {
        public override void GetManConclusion(Man man)
        {
            Console.WriteLine("男人{0}时，凡事不懂也装懂。", this.GetType().Name);
        }

        public override void GetWomanConclusion(Woman woman)
        {
            Console.WriteLine("女人{0}时，遇事懂也装作不懂。", this.GetType().Name);
        }
    }
}

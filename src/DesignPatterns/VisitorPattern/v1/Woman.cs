using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.VisitorPattern.v1
{
    /// <summary>
    /// 女人类
    /// </summary>
    public class Woman : AbstractPerson
    {
        public override void GetConclusion()
        {
            if (Action == "成功")
            {
                Console.WriteLine("{0}{1}时，背后大多有一个不成功的男人。", this.GetType().Name, Action);
            }
            else if (Action == "失败")
            {
                Console.WriteLine("{0}{1}时，眼泪汪汪，谁也劝不住。", this.GetType().Name, Action);
            }
            else if (Action == "恋爱")
            {
                Console.WriteLine("{0}{1}时，遇事懂也装作不懂。", this.GetType().Name, Action);
            }
        }
    }
}

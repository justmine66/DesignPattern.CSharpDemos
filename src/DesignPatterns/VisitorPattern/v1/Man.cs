using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.VisitorPattern.v1
{
    /// <summary>
    /// 男人类
    /// </summary>
    public class Man : AbstractPerson
    {
        public override void GetConclusion()
        {
            if (Action == "成功")
            {
                Console.WriteLine("{0}{1}时，背后多半有一个伟大的女人。", this.GetType().Name,Action);
            }
            else if (Action == "失败")
            {
                Console.WriteLine("{0}{1}时，闷头喝酒，谁也不用劝。", this.GetType().Name, Action);
            }
            else if (Action == "恋爱")
            {
                Console.WriteLine("{0}{1}时，凡事不懂也装懂。", this.GetType().Name, Action);
            }
        }
    }
}

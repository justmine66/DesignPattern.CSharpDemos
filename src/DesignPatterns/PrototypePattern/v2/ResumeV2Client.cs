using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.PrototypePattern.v2
{
    public class ResumeV2Client
    {
        public void Main()
        {
            var a = new Resume("小明");
            a.SetPersonalInfo("男", "18");
            a.SetWorkExprience("1998-2000", "阿里巴巴");

            var b = a.Clone() as Resume;
            b.SetPersonalInfo("男", "20");
            b.SetWorkExprience("1998-2000", "腾讯");

            a.Display();
            b.Display();
        }
    }
}

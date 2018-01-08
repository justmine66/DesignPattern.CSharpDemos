using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.AdapterPattern.Mechanism
{
    public class AdapterPatternClient
    {
        public void Main()
        {
            //对于客户端来说，调用的就是Target.Request()
            Target target = new Adapter();
            target.Request();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.ProxyPattern.Mechanism
{
    /// <summary>
    /// 定义RealObject和Proxy的公用接口，这样在任何使用RealObject的地方都可以使用Proxy
    /// </summary>
    public abstract class Subject
    {
        public abstract void Request();
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.ProxyPattern.Mechanism
{
    /// <summary>
    /// 定义Proxy所代表的真实对象
    /// </summary>
    public class RealObject : Subject
    {
        public override void Request()
        {
            Console.WriteLine("真实的请求");
        }
    }
}

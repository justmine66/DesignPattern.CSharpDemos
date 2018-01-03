using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.ProxyPattern.Mechanism
{
    /// <summary>
    /// 代理类
    /// 保存一个引用使得代理可以访问实体，并提供与Subject接口相同的接口方法，这样代理就可以用来替代实体了
    /// </summary>
    public class Proxy : Subject
    {
        public Proxy()
        {
            realObject = new RealObject();
        }

        readonly RealObject realObject;

        public override void Request()
        {
            if (realObject != null)
            {
                realObject.Request();
            }
        }
    }
}

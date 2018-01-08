using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.AdapterPattern.Mechanism
{
    /// <summary>
    /// 这是客户所期待的接口。目标可以是具体的或抽象类，也可以是接口
    /// </summary>
    public class Target
    {
        public virtual void Request()
        {
            Console.WriteLine("普通请求");
        }
    }
}

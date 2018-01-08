using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.AdapterPattern.Mechanism
{
    /// <summary>
    /// 受改造者，需要适配的类
    /// </summary>
    public class Adaptee
    {
        public void SpecificRequest()
        {
            Console.WriteLine("特殊请求");
        }
    }
}

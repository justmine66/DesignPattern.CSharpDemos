using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.AdapterPattern.Mechanism
{
    /// <summary>
    /// 适配器类，通过内部包装一个Adaptee对象，把源接口转换成目标接口
    /// </summary>
    public class Adapter : Target
    {
        private Adaptee adaptee = new Adaptee();

        /// <summary>
        /// 这样就可以把调用Request()方法变成实际调用SpecificRequest()
        /// </summary>
        public override void Request()
        {
            adaptee.SpecificRequest();
        }
    }
}

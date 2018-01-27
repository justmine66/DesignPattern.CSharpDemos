using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.BridgePattern.v1
{
    /// <summary>
    /// 手机通讯录
    /// </summary>
    public class HandSetAddressList : HandSetSoftBase
    {
        public override void Run()
        {
            Console.WriteLine("允许手机通讯录");
        }
    }
}

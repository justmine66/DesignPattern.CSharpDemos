using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.BridgePattern.v1
{
    /// <summary>
    /// 手机游戏
    /// </summary>
    public class HandSetGame : HandSetSoftBase
    {
        public override void Run()
        {
            Console.WriteLine("运行手机游戏");
        }
    }
}

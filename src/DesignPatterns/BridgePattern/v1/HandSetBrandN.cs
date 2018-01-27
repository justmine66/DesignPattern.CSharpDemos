using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.BridgePattern.v1
{
    /// <summary>
    /// 手机品牌N
    /// </summary>
    public class HandSetBrandN : HandSetBrandBase
    {
        public override void Run()
        {
            _soft.Run();
        }
    }
}

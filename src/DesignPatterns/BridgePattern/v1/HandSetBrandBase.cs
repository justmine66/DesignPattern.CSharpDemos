using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.BridgePattern.v1
{
    /// <summary>
    /// 手机品牌
    /// </summary>
    public abstract class HandSetBrandBase
    {
        protected HandSetSoftBase _soft;

        /// <summary>
        /// 设置软件
        /// 品牌需要关注软件，所以可在机器中安装软件，以备允许
        /// </summary>
        public void SetSoft(HandSetSoftBase soft)
        {
            _soft = soft;
        }

        public abstract void Run();
    }
}

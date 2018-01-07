using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.ObserverPattern.v3
{
    /// <summary>
    /// 主题(通职者)接口
    /// </summary>
    public interface ISubject
    {
        /// <summary>
        /// 状态
        /// </summary>
        string SujectState { get; set; }

        /// <summary>
        /// 通知方法
        /// </summary>
        void Notify();
    }
}

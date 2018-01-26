using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.SingletonPattern
{
    /// <summary>
    /// 饿汉式单例类
    /// sealed 阻止发生派生，而派生可能会增加多个实例。
    /// </summary>
    public sealed class Singleton
    {
        /// <summary>
        /// 在第一次引用类的任何成员时，创建实例。公共语言运行库负责处理变量初始化。
        /// </summary>
        private static readonly Singleton _instance = new Singleton();
        private Singleton() { }
        public static Singleton GetSingleton()
        {
            return _instance;
        }
    }
}

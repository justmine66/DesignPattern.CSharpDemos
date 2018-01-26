using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.SingletonPattern
{
    /// <summary>
    /// 懒汉式单例类
    /// 需要使用双检锁，保证多线程下实例的唯一性。
    /// </summary>
    public class LazySingleton
    {
        private static LazySingleton _instance;
        private static readonly object _latchLock = new object();
        private LazySingleton() { }
        public static LazySingleton GetInstance()
        {
            if (_instance == null)
            {
                lock (_latchLock)
                {
                    if (_instance == null)
                    {
                        _instance = new LazySingleton();
                    }
                }
            }

            return _instance;
        }
    }
}

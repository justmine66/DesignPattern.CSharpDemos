using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.MediatorPattern.Mechanism
{
    /// <summary>
    /// 抽象中介者类
    /// </summary>
    public abstract class MediatorBase
    {
        public abstract void Send(string message,CollageBase collage);
    }
}

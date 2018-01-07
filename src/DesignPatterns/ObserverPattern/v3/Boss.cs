using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.ObserverPattern.v3
{
    /// <summary>
    /// 老板类
    /// </summary>
    public class Boss : ISubject
    {
        //声明一个事件Update,类型为EventHandler委托
        public event EventHandler Update;

        public string SujectState { get; set; }

        public void Notify()
        {
            //当访问“通知”方法时，调用更新
            if (this.Update != null)
            {
                this.Update(this, EventArgs.Empty);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.ObserverPattern.v3
{
    /// <summary>
    /// 看NBA直播的同事
    /// </summary>
    public class NBAObserver
    {
        public NBAObserver(string name)
        {
            this.name = name;
        }

        protected readonly string name;

        /// <summary>
        /// 关闭股票行情
        /// </summary>
        public void CloseNBADirectSeeding(Object subject, EventArgs eventArgs)
        {
            Console.WriteLine("{0} {1} 关闭NBA直播，继续工作",
                (subject as ISubject).SujectState,
                this.name);
        }
    }
}

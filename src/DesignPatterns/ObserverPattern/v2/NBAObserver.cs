using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.ObserverPattern.v2
{
    /// <summary>
    /// 看NBA直播的同事
    /// </summary>
    public class NBAObserver : Observer
    {
        public NBAObserver(string name, ISubject subject)
            : base(name, subject)
        {

        }

        public override void Update()
        {
            Console.WriteLine("{0} {1} 关闭NBA直播，继续工作",
                subject.SujectState,
                this.name);
        }
    }
}

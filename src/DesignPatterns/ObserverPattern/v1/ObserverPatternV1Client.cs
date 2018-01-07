using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.ObserverPattern.v1
{
    public class ObserverPatternV1Client
    {
        public void Main()
        {
            //前台小姐小芳
            var secretary = new Secretary();
            //看股票的同事
            var xiaowang = new StockObserver("小王", secretary);
            var xiaoming = new StockObserver("小明", secretary);

            //前台记下两名同事
            secretary.Attach(xiaowang);
            secretary.Attach(xiaoming);

            //发现老板回来了
            secretary.SecretaryAction = "老板回来了";
            //通知两个同事
            secretary.Notify();
        }
    }
}

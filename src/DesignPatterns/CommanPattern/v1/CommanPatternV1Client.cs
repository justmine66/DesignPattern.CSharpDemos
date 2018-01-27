using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.CommanPattern.v1
{
    public class CommanPatternV1Client
    {
        public void Main()
        {
            //客户端程序与烤肉者紧耦合，尽管简单，但却极为僵化，有许许多多的隐患。
            //如果用户多了，请求多了，就极为混乱。
            var barbecuer = new Barbecuer();
            barbecuer.BakeMutton();
            barbecuer.BakeMutton();
            barbecuer.BakeMutton();
            barbecuer.BakeChickenWing();
            barbecuer.BakeChickenWing();

            Console.Read();
        }
    }
}

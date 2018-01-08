using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DesignPatterns.AdapterPattern.v1
{
    public class AdapterPatternV1Client
    {
        public void Main()
        {
            Player b =new Forwards("巴蒂尔");
            b.Attack();
            Player m = new Guards("哈登");
            m.Attack();

            Player ym = new Translator("姚明");
            //姚明问Attack和Defense什么意思？
            ym.Attack();
            ym.Defense();
        }
    }
}

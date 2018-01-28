using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.FlyweightPattern.v2
{
    public class FlyweightPatternV2Client
    {
        public void Main()
        {
            var factory = new WebSiteFactory();

            WebSite fx = factory.GetWebSiteCategory("产品展示");
            fx.Use(new User("小菜"));
            WebSite fy = factory.GetWebSiteCategory("产品展示");
            fy.Use(new User("大鸟"));
            WebSite fz = factory.GetWebSiteCategory("产品展示");
            fz.Use(new User("娇娇"));

            WebSite f1 = factory.GetWebSiteCategory("博客");
            f1.Use(new User("老顽童"));
            WebSite f2 = factory.GetWebSiteCategory("博客");
            f2.Use(new User("桃谷六仙"));
            WebSite f3 = factory.GetWebSiteCategory("博客");
            f3.Use(new User("南海鳄神"));

            Console.WriteLine("网站分类总数：{0}", factory.GetWebSiteCount());

            Console.Read();
        }
    }
}

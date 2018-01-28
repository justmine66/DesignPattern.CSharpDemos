using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.FlyweightPattern.v1
{
    public class FlyweightPatternV1Client
    {
        public void Main()
        {
            var factory = new WebSiteFactory();

            WebSite fx = factory.GetWebSiteCategory("产品展示");
            fx.Use();
            WebSite fy = factory.GetWebSiteCategory("产品展示");
            fy.Use();
            WebSite fz = factory.GetWebSiteCategory("产品展示");
            fz.Use();

            WebSite f1 = factory.GetWebSiteCategory("博客");
            f1.Use();
            WebSite f2 = factory.GetWebSiteCategory("博客");
            f2.Use();
            WebSite f3 = factory.GetWebSiteCategory("博客");
            f3.Use();

            Console.WriteLine("网站分类总数：{0}", factory.GetWebSiteCount());

            Console.Read();
        }
    }
}

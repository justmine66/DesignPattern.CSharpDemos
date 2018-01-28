using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.FlyweightPattern.v1
{
    public class WebSiteFactory
    {
        Hashtable _flyweights = new Hashtable();

        public WebSite GetWebSiteCategory(string key)
        {
            if (!_flyweights.Contains(key))
            {
                _flyweights.Add(key,new ConcreteWebSite(key));
            }

            return _flyweights[key] as WebSite;
        }

        public int GetWebSiteCount()
        {
            return _flyweights.Count;
        }
    }
}

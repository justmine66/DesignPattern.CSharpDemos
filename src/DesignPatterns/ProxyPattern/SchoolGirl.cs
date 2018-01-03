using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.ProxyPattern
{
    /// <summary>
    /// 学生妹
    /// </summary>
    public class SchoolGirl
    {
        public SchoolGirl(string name)
        {
            this.Name = name;
        }
        public string Name { get; private set; }
    }
}

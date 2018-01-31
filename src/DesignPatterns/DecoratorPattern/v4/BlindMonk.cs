using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.DecoratorPattern.v4
{
    /// <summary>
    /// 盲僧
    /// </summary>
    public class BlindMonk : IHero
    {
        string _name;

        public BlindMonk(string name)
        {
            _name = name;
        }

        public void LearnSkills()
        {
            Console.WriteLine("{0}学习了以下技能", _name);
        }
    }
}

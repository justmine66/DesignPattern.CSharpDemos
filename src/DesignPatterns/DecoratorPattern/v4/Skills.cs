using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.DecoratorPattern.v4
{
    /// <summary>
    /// 技能栏-装饰器
    /// </summary>
    public class Skills : IHero
    {
        IHero _hero;

        public Skills(IHero hero)
        {
            _hero = hero;
        }

        public virtual void LearnSkills()
        {
            if (_hero!=null)
            {
                _hero.LearnSkills();
            }
        }
    }
}

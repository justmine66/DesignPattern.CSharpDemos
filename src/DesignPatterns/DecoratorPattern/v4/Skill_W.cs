using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.DecoratorPattern.v4
{
    public class Skill_W : Skills
    {
        private String _skillName;

        public Skill_W(IHero hero, string skillName) : base(hero)
        {
            _skillName = skillName;
        }

        public override void LearnSkills()
        {
            base.LearnSkills();
            Console.WriteLine("学习了技能W: " + _skillName);
        }
    }
}

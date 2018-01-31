using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.DecoratorPattern.v4
{
    public class Skill_Q : Skills
    {
        private String _skillName;

        public Skill_Q(IHero hero, string skillName) : base(hero)
        {
            _skillName = skillName;
        }

        public override void LearnSkills()
        {
            base.LearnSkills();
            Console.WriteLine("学习了技能Q: " + _skillName);
        }
    }
}

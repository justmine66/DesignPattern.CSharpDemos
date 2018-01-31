using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.DecoratorPattern.v4
{
    /// <summary>
    /// 召唤师-客户端
    /// </summary>
    public class Player
    {
        public void Main()
        {
            //选择英雄
            IHero hero = new BlindMonk("李青");

            var skills = new Skills(hero);
            Skills w = new Skill_W(skills, "金钟罩/铁布衫");
            Skills q = new Skill_Q(w, "天音波/回音击");

            q.LearnSkills();

            Console.Read();
        }
    }
}

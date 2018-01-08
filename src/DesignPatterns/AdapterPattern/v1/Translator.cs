using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.AdapterPattern.v1
{
    public class Translator : Player
    {
        public Translator(string name) : base(name)
        {
            foreignCenter = new ForeignCenter(name);
        }

        private ForeignCenter foreignCenter;

        public override void Attack()
        {
            foreignCenter.进攻();
        }

        public override void Defense()
        {
            foreignCenter.防守();
        }
    }
}

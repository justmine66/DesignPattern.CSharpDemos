using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.AdapterPattern.v1
{
    /// <summary>
    /// 后卫
    /// </summary>
    public class Guards : Player
    {
        public Guards(string name) : base(name)
        {
        }

        public override void Attack()
        {
            Console.WriteLine("后卫 {0} 进攻", this.name);
        }

        public override void Defense()
        {
            Console.WriteLine("后卫 {0} 防守", this.name);
        }
    }
}

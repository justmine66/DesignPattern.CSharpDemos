using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.AdapterPattern.v1
{
    /// <summary>
    /// 中锋
    /// </summary>
    public class Center : Player
    {
        public Center(string name) : base(name)
        {
        }

        public override void Attack()
        {
            Console.WriteLine("中锋 {0} 进攻", this.name);
        }

        public override void Defense()
        {
            Console.WriteLine("中锋 {0} 防守", this.name);
        }
    }
}

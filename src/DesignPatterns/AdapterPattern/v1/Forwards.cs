using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.AdapterPattern.v1
{
    /// <summary>
    /// 前锋
    /// </summary>
    public class Forwards : Player
    {
        public Forwards(string name) : base(name)
        {
        }

        public override void Attack()
        {
            Console.WriteLine("前锋 {0} 进攻", this.name);
        }

        public override void Defense()
        {
            Console.WriteLine("前锋 {0} 防守", this.name);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.AdapterPattern.v1
{
    /// <summary>
    /// 外籍中锋
    /// </summary>
    public class ForeignCenter
    {
        public ForeignCenter(string name) 
        {
            this.name = name;
        }

        public string name { get; }

        public void 进攻()
        {
            Console.WriteLine("外籍中锋 {0} 进攻", this.name);
        }

        public void 防守()
        {
            Console.WriteLine("外籍中锋 {0} 防守", this.name);
        }
    }
}

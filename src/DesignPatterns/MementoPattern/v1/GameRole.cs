using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.MementoPattern.v1
{
    /// <summary>
    /// 游戏角色
    /// </summary>
    public class GameRole
    {
        /// <summary>
        /// 生命力
        /// </summary>
        public int Vitality { get; set; }

        /// <summary>
        /// 攻击力
        /// </summary>
        public int Attack { get; set; }

        /// <summary>
        /// 防御力
        /// </summary>
        public int Defense { get; set; }

        public void StateDisplay()
        {
            Console.WriteLine("角色当前状态：");
            Console.WriteLine("生命力：" + this.Vitality);
            Console.WriteLine("攻击力：" + this.Attack);
            Console.WriteLine("防御力：" + this.Defense);
        }

        public void GetInitState()
        {
            this.Vitality = 100;
            this.Attack = 100;
            this.Defense = 100;
        }
    
        /// <summary>
        /// 与大Boss战斗后，游戏数据损耗变为0
        /// </summary>
        public void Fight()
        {
            this.Vitality = 0;
            this.Attack = 0;
            this.Defense = 0;
        }
    }
}

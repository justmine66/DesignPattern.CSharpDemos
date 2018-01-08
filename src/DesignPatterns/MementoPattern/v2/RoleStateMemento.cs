using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.MementoPattern.v2
{
    /// <summary>
    /// 角色状态备忘录
    /// </summary>
    public class RoleStateMemento
    {
        public RoleStateMemento(int vitality, int attack, int defense)
        {
            this.Vitality = vitality;
            this.Attack = attack;
            this.Defense = defense;
        }

        /// <summary>
        /// 生命力
        /// </summary>
        public int Vitality { get; }

        /// <summary>
        /// 攻击力
        /// </summary>
        public int Attack { get; }

        /// <summary>
        /// 防御力
        /// </summary>
        public int Defense { get; }
    }
}

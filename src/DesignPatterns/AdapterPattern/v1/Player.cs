using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.AdapterPattern.v1
{
    /// <summary>
    /// 球员
    /// </summary>
    public abstract class Player
    {
        public Player(string name)
        {
            this.name = name;
        }

        public readonly string name;

        /// <summary>
        /// 进攻
        /// </summary>
        public abstract void Attack();

        /// <summary>
        /// 防守
        /// </summary>
        public abstract void Defense();
    }
}

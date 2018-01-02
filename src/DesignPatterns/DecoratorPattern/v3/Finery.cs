using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.DecoratorPattern.v3
{
    /// <summary>
    /// 服饰类(Decorator)
    /// </summary>
    public class Finery : Person
    {
        protected Person component;

        /// <summary>
        /// 打扮
        /// </summary>
        /// <param name="person"></param>
        public void Decorate(Person component)
        {
            this.component = component;
        }

        public override void Show()
        {
            if (this.component != null)
            {
                this.component.Show();
            }
        }
    }
}

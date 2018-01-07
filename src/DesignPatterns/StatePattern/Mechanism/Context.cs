using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.StatePattern.Mechanism
{
    /// <summary>
    /// 维护一个ConcreteState子类的实例，这个实例定义当前的状态
    /// </summary>
    public class Context
    {
        public Context(State state)
        {
            this._state = state;
        }

        private State _state;

        /// <summary>
        /// 可读写的状态
        /// 用于读取当前状态和设置新状态
        /// </summary>
        public State State
        {
            get { return this._state; }
            set
            {
                this._state = value;
                Console.WriteLine("当前状态：{0}", this._state.GetType().Name);
            }
        }

        /// <summary>
        /// 对请求做处理，并设置下一个状态
        /// </summary>
        public void Request()
        {
            this._state.Handle(this);
        }
    }
}

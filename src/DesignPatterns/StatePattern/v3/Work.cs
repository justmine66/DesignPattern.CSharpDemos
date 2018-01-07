using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.StatePattern.v3
{
    public class Work
    {
        private State _state;

        public Work()
        {
            this._state = new ForenoonState();
        }

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
        /// 钟点
        /// </summary>
        public int Hour { get; set; }

        /// <summary>
        /// 工作是否完成
        /// </summary>
        public bool WorkFinished { get; set; }

        public void SetState(State state)
        {
            this._state = state;
        }

        public void WriteProgram()
        {
            this._state.WriteProgram(this);
        }
    }
}

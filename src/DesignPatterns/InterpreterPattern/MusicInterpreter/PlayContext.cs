using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.InterpreterPattern.MusicInterpreter
{
    /// <summary>
    /// 演奏上下文
    /// </summary>
    public class PlayContext
    {
        /// <summary>
        /// 演奏内容
        /// </summary>
        public string Text { get; set; }
    }
}

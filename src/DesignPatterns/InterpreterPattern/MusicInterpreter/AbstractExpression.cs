using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.InterpreterPattern.MusicInterpreter
{
    /// <summary>
    /// 抽象的表达式基类
    /// </summary>
    public abstract class AbstractExpression
    {
        /// <summary>
        /// 解释器
        /// </summary>
        /// <param name="context"></param>
        public void Interpret(PlayContext context)
        {
            if (string.IsNullOrWhiteSpace(context.Text))
            {
                return;
            }

            string playKey = context.Text.Substring(0, 1);
            context.Text = context.Text.Substring(2);
            double doublePlayValue = Convert.ToDouble(context.Text.Substring(0, context.Text.IndexOf(" ")));
            context.Text = context.Text.Substring(context.Text.IndexOf(" ") + 1);

            this.Execute(playKey, doublePlayValue);
        }

        /// <summary>
        /// 执行文法的模板方法
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        public abstract void Execute(string key, double value);
    }
}

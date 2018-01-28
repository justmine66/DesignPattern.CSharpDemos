using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.InterpreterPattern.Mechanism
{
    /// <summary>
    /// 非终结符解释器
    /// </summary>
    public class NonTerminalExpression : AbstractExpression
    {
        public override void Interpret(Context context)
        {
            Console.WriteLine("非终端解释器");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.InterpreterPattern.Mechanism
{
    /// <summary>
    /// 终结符表达式，实现与文法中终结符相关的解释操作。实现抽象表达式中所要求的接口，主要是一个Interpret()方法。文法中每一个终结符都有一个具体终结表达式与之对应。
    /// </summary>
    public class TerminalExpression : AbstractExpression
    {
        public override void Interpret(Context context)
        {
            Console.WriteLine("终端解释器");
        }
    }
}

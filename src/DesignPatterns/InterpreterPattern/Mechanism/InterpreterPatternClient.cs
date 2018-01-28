using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.InterpreterPattern.Mechanism
{
    public class InterpreterPatternClient
    {
        public void Main()
        {
            var context = new Context();
            IList<AbstractExpression> list = new List<AbstractExpression>();
            list.Add(new TerminalExpression());
            list.Add(new NonTerminalExpression());
            list.Add(new TerminalExpression());
            list.Add(new TerminalExpression());

            foreach (AbstractExpression exp in list)
            {
                exp.Interpret(context);
            }

            Console.Read();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.InterpreterPattern.MusicInterpreter
{
    /// <summary>
    /// 节拍速度文法
    /// </summary>
    public class SpeedExpression : AbstractExpression
    {
        public override void Execute(string key, double value)
        {
            string speed = string.Empty;
            if (value < 500)
            {
                speed = "快速";
            }
            else if (value > 1000)
            {
                speed = "慢速";
            }
            else {
                speed = "中速";
            }

            Console.WriteLine(speed);
        }
    }
}

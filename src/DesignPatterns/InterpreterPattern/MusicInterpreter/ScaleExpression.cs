using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.InterpreterPattern.MusicInterpreter
{
    /// <summary>
    /// 音阶文法类
    /// </summary>
    public class ScaleExpression : AbstractExpression
    {
        /// <summary>
        /// 处理音阶文法
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        public override void Execute(string key, double value)
        {
            string scale = "";
            switch (Convert.ToInt32(value))
            {
                case 1:
                    scale = "低音";
                    break;
                case 2:
                    scale = "中音";
                    break;
                case 3:
                    scale = "高音";
                    break;
                default:
                    scale = "超低音";
                    break;
            }

            Console.Write(scale + " ");
        }
    }
}

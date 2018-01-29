using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.InterpreterPattern.MusicInterpreter
{
    /// <summary>
    /// 音符文法类
    /// </summary>
    class NoteExpression : AbstractExpression
    {
        /// <summary>
        /// 处理音符文法
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        public override void Execute(string key, double value)
        {
            string note = string.Empty;
            switch (key)
            {
                case "C":
                    note = "1";
                    break;
                case "D":
                    note = "2";
                    break;
                case "E":
                    note = "3";
                    break;
                case "F":
                    note = "4";
                    break;
                case "G":
                    note = "5";
                    break;
                case "A":
                    note = "6";
                    break;
                case "B":
                    note = "7";
                    break;
                case "P":
                    note = "8";
                    break;
                default:
                    note = "0";
                    break;
            }

            Console.Write(note + " ");
        }
    }
}

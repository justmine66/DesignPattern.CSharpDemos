using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.InterpreterPattern.MusicInterpreter
{
    public class InterpreterPatternV1Client
    {
        public void Main()
        {
            var context = new PlayContext();
            Console.WriteLine("音乐上海滩: ");
            context.Text = "T 500 o 2 E 0.5 G 0.5 A 3 E 0.5 G 0.5";
            AbstractExpression expression = null;
            try
            {
                while (context.Text.Length > 0)
                {
                    string str = context.Text.Substring(0, 1);
                    switch (str)
                    {
                        case "o":
                            expression = new ScaleExpression();
                            break;
                        case "T":
                            expression = new SpeedExpression();
                            break;
                        case "C":
                        case "D":
                        case "E":
                        case "F":
                        case "A":
                        case "B":
                        case "P":
                            expression = new NoteExpression();
                            break;
                    }
                    expression.Interpret(context);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.Read();
        }
    }
}

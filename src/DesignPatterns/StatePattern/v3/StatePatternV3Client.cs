using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.StatePattern.v3
{
    public class StatePatternV3Client
    {
        public void Main()
        {
            var work = new Work();

            work.Hour = 9;
            work.WriteProgram();
            work.Hour = 10;
            work.WriteProgram();
            work.Hour = 12;
            work.WriteProgram();
            work.Hour = 13;
            work.WriteProgram();
            work.Hour = 14;
            work.WriteProgram();
            work.Hour = 17;
            work.WriteProgram();

            work.WorkFinished = false;

            work.Hour = 19;
            work.WriteProgram();
            work.Hour = 20;
            work.WriteProgram();
            work.Hour = 22;
            work.WriteProgram();
        }
    }
}

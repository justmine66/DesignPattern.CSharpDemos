using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.StatePattern.v2
{
    public class StatePatternV2Client
    {
        public void Main()
        {
            var workState = new WorkStateWithClassify();

            workState.Hour = 9;
            workState.WriteProgram();
            workState.Hour = 10;
            workState.WriteProgram();
            workState.Hour = 12;
            workState.WriteProgram();
            workState.Hour = 13;
            workState.WriteProgram();
            workState.Hour = 14;
            workState.WriteProgram();
            workState.Hour = 17;
            workState.WriteProgram();

            workState.WorkFinished = true;

            workState.Hour = 19;
            workState.WriteProgram();
            workState.Hour = 22;
            workState.WriteProgram();
        }
    }
}

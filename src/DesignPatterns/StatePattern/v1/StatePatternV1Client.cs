using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.StatePattern.v1
{
    public class StatePatternV1Client
    {
        public void Main()
        {
            WorkStateWithFunction.Hour = 9;
            WorkStateWithFunction.WriteProgram();
            WorkStateWithFunction.Hour = 10;
            WorkStateWithFunction.WriteProgram();
            WorkStateWithFunction.Hour = 12;
            WorkStateWithFunction.WriteProgram();
            WorkStateWithFunction.Hour = 13;
            WorkStateWithFunction.WriteProgram();
            WorkStateWithFunction.Hour = 14;
            WorkStateWithFunction.WriteProgram();
            WorkStateWithFunction.Hour = 17;
            WorkStateWithFunction.WriteProgram();

            WorkStateWithFunction.WorkFinished = true;

            WorkStateWithFunction.Hour = 19;
            WorkStateWithFunction.WriteProgram();
            WorkStateWithFunction.Hour = 22;
            WorkStateWithFunction.WriteProgram();
        }
    }
}

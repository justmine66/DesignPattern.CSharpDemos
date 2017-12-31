using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.ChainOfResponsibilityPattern.FunctionalChain
{
    public class Client
    {
        public Client(String leaveName, int leaveDays)
        {
            this._leaveName = leaveName;
            this._leaveDays = leaveDays;
        }

        readonly string _leaveName;
        readonly int _leaveDays;

        public int GetLeaveDays()
        {
            return this._leaveDays;
        }

        public string GetLeaveName()
        {
            return this._leaveName;
        }
    }
}

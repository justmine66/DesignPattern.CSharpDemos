using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.MediatorPattern.v1
{
    /// <summary>
    /// 联合国安全理事会
    /// </summary>
    public class UnitedNationsSecruityConcil : UnitedNations
    {
        protected USA _usa;
        protected Iraq _iraq;

        public USA SetUsa { set { _usa = value; } }
        public Iraq SetIraq { set { _iraq = value; } }

        public UnitedNationsSecruityConcil()
        {
        }

        public override void Declare(string message, Country country)
        {
            if (country == _usa)
            {
                _iraq.GetMessage(message);
            }
            else
            {
                _usa.GetMessage(message);
            }
        }
    }
}

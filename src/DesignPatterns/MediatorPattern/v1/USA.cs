using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.MediatorPattern.v1
{
    public class USA : Country
    {
        public USA(UnitedNations unitedNations) : base(unitedNations)
        {
        }

        public void Declare(string message)
        {
            _unitedNations.Declare(message, this);
        }

        public void GetMessage(string message)
        {
            Console.WriteLine("美国方面收到消息："+message);
        }
    }
}

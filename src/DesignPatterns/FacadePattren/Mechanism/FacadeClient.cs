using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.FacadePattren.Mechanism
{
    public class FacadeClient
    {
        public void Main()
        {
            var facade = new Facade();

            facade.MethodA();
            facade.MethodB();
        }
    }
}

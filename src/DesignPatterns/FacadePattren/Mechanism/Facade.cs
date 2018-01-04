using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.FacadePattren.Mechanism
{
    /// <summary>
    /// 外观类
    /// </summary>
    public class Facade
    {
        public Facade()
        {
            this.subSystemOne = new SubSystemOne();
            this.subSystemTwo = new SubSystemTwo();
            this.subSystemThree = new SubSystemThree();
            this.subSystemFour = new SubSystemFour();
        }

        readonly SubSystemOne subSystemOne;
        readonly SubSystemTwo subSystemTwo;
        readonly SubSystemThree subSystemThree;
        readonly SubSystemFour subSystemFour;

        public void MethodA()
        {
            Console.WriteLine("方法组A");
            this.subSystemOne.MenthodOne();
            this.subSystemTwo.MenthodTwo();
            this.subSystemThree.MenthodThree();
        }

        public void MethodB()
        {
            Console.WriteLine("方法组B");
            this.subSystemOne.MenthodOne();
            this.subSystemTwo.MenthodTwo();
            this.subSystemThree.MenthodThree();
            this.subSystemFour.MenthodFour();
        }
    }
}

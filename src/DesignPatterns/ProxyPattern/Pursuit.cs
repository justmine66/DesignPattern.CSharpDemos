using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.ProxyPattern
{
    /// <summary>
    /// 追求者
    /// </summary>
    public class Pursuit : IGiveGift
    {
        public Pursuit(SchoolGirl schoolGirl)
        {  
            this.schoolGirl = schoolGirl ?? throw new ArgumentNullException(nameof(schoolGirl));
        }

        readonly SchoolGirl schoolGirl;

        public void GiveChocolates()
        {
            Console.WriteLine("送" + schoolGirl.Name + "巧克力");
        }

        public void GiveDolls()
        {
            Console.WriteLine("送" + schoolGirl.Name + "洋娃娃");
        }

        public void GiveFlowers()
        {
            Console.WriteLine("送" + schoolGirl.Name + "鲜花");
        }
    }
}

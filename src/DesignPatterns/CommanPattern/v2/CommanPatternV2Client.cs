using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.CommanPattern.v2
{
    public class CommanPatternV2Client
    {
        public void Main()
        {
            //开店前准备
            var barbecuer = new Barbecuer();
            Command bakeMutton = new BakeMuttonCommand(barbecuer);
            Command bakeChickenWing = new BakeChickenWingCommand(barbecuer);
            var waiter = new Waiter();

            //开门营业
            waiter.SerOrder(bakeMutton);
            waiter.Notify();
            waiter.SerOrder(bakeChickenWing);
            waiter.Notify();

            Console.Read();
        }
    }
}

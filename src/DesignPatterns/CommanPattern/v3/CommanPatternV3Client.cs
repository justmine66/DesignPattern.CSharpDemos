using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.CommanPattern.v3
{
    public class CommanPatternV3Client
    {
        public void Main()
        {
            //开店前准备
            var barbecuer = new Barbecuer();
            Command bakeMutton = new BakeMuttonCommand(barbecuer);
            Command bakeChickenWing = new BakeChickenWingCommand(barbecuer);
            var waiter = new Waiter();

            //开门营业 顾客点菜
            waiter.SerOrder(bakeMutton);
            waiter.SerOrder(bakeChickenWing);

            //点菜完毕，通知厨房
            waiter.Notify();

            Console.Read();
        }
    }
}

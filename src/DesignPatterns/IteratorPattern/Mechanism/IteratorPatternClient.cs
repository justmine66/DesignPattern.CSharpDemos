using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.IteratorPattern.Mechanism
{
    public class IteratorPatternClient
    {
        public void Main()
        {
            //公交车，即聚合对象
            var aggregate = new ConcreteAggregate();
            //新上来的乘客，即对象数组
            aggregate[0] = "大鸟";
            aggregate[1] = "小菜";
            aggregate[2] = "行李";
            aggregate[3] = "老外";
            aggregate[4] = "公交内部员工";
            aggregate[4] = "小偷";
            //售票员出场，先看好上车的是哪些人，即传入聚合对象
            //Iterator iterator = new ConcreteIterator(aggregate);
            Iterator iterator = new ConcreteIteratorDesc(aggregate);
            //从第一个乘客开始
            object first = iterator.First();
            while (!iterator.IsDone())
            {
                //当前乘客买票
                Console.WriteLine("{0} 请买票!", iterator.CurrentItem());
                //下一个乘客
                iterator.Next();
            }

            Console.Read();
        }
    }
}

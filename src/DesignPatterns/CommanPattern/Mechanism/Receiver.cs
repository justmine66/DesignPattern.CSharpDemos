using System;

namespace DesignPatterns.CommanPattern.Mechanism
{
    public class Receiver
    {
        public void Action()
        {
            Console.WriteLine("收到一个命令");
        }
    }
}
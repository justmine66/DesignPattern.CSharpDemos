using DesignPatterns.ChainOfResponsibilityPattern.Standard;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.ChainOfResponsibilityPattern.Standard
{
    public class StandardCORPTest
    {
        public StandardCORPTest()
        {
            this.groupLeader = new GroupLeader("王明");
            this.manager = new Manager("赵强");
            this.hr = new HRDepartment("李波");
        }

        readonly Handler groupLeader, manager, hr;

        public void Main()
        {
            // 构建职责链条
            this.groupLeader.SetSuccessor(manager); 
            this.manager.SetSuccessor(hr);

            // 构建示例
            Client lr1 = new Client("张三", 1);
            groupLeader.handleRequest(lr1);

            Client lr2 = new Client("李四", 2);
            groupLeader.handleRequest(lr2);

            Client lr3 = new Client("王五", 5);
            groupLeader.handleRequest(lr3);

            Client lr4 = new Client("赵六", 10);
            groupLeader.handleRequest(lr4);
        }
    }
}
